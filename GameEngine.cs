using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace GADES2
{
    class GameEngine
    {
        const string SAVE_FILE_NAME = "gamesave.txt";
        public Map newMap;
        bool isGameOver;

        public Map Map
        {
            get { return Map; }
        }
        public Hero Player
        {
            get { return Player; }
        }
        public Enemy[] enemy
        {
            get { return enemy; }
        }
        public string PlayerStats
        {
            get { return newMap.Player.ToString(); }
        }
        public bool IsGameOver
        {
            get { return isGameOver; }
        }
        public GameEngine()
        {
            newMap = new Map(10,20,10,20,10,10);
        }

        public bool MovePlayer(Character.Movement direction)
        {
            if (newMap.Player.IsDead())
            {
                return false;
            }

            if (newMap.Player.ReturnMove(direction)==Character.Movement.NO_MOVEMENT)
            {
                return false;
            }

            int oldPlayerX = newMap.Player.X;
            int oldPlayerY = newMap.Player.Y;
            newMap.Player.Move(direction);

            EnemiesMove();
            EnemiesAttack();

            newMap.UpdateMap();
            newMap.UpdateVision();

            Item pickedUpItem = newMap.GetItemAtPosition(newMap.Player.X, newMap.Player.Y);
            int itemAmount = 0;
            if (pickedUpItem!= null)
            {
               
                itemAmount++;
            }
            newMap.player.UpdateGold(itemAmount);
            if (newMap.Player.IsDead())
            {
                return false;
            }
            return true;
            //comment out ?
            var validMove = newMap.player.ReturnMove(direction);

            if (newMap.player.ReturnMove(direction) != Character.Movement.NO_MOVEMENT)
            {
                newMap.map[newMap.player.X, newMap.player.Y] = null;

                switch (direction)
                {
                    case Character.Movement.UP:
                        newMap.player.X -= 1;
                        break;
                    case Character.Movement.DOWN:
                        newMap.player.Y += 1;
                        break;
                    case Character.Movement.RIGHT:
                        newMap.player.X += 1;
                        break;
                    case Character.Movement.LEFT:
                        newMap.player.X -= 1;
                        break;
                }

                newMap.map[newMap.player.X, newMap.player.Y] = newMap.player;
            }
        }

        public override string ToString()
        {
            return newMap.ToString();
        }

        public Character  PlayerAttack(Character.Movement direction)
        {
            if (isGameOver)
            {
                return null;
            }

            int visionIndex = (int)direction;
            if (newMap.Player.Vision[visionIndex]is Character)
            {
                Character target = (Character)newMap.Player.Vision[visionIndex];
                newMap.Player.Attack(target);
                return target;
            }
            return null;
        }

        private void EnemiesMove()
        {
            foreach(Enemy enemy in Map.enemies)
            {
                if (enemy.IsDead())
                {
                    continue;
                }
                Character.Movement move = enemy.ReturnMove();
                enemy.Move(move);

               
               
            }
        }
        private void EnemiesAttack()
        {
            foreach (Enemy enemy in Map.enemies)
            {
                if (enemy.IsDead())
                {
                    continue;
                }
                if (enemy is Mage)
                {
                    MageAttack((Mage)enemy);
                }
               
                else if(enemy is Goblin)
                {
                    GoblinAttack((Goblin)enemy);
                }
            }
            //commit push
            
        }
        private void GoblinAttack(Goblin goblin)
        {
            if (goblin.CheckRange(Map.player))
            {
                goblin.Attack(Map.player);
            }
        }
        private void MageAttack(Mage mage)
        {
            if (mage.CheckRange(Map.player))
            {
                mage.Attack(Map.player);
            }
            foreach (Enemy target in Map.enemies)
            {
                if (mage == target)
                {
                    continue;
                }
                if (target.IsDead())
                {
                    continue;
                }
                if (!mage.CheckRange(target))
                {
                    continue;
                }

                mage.Attack(target);
            }
        }


        public string BuildMap()
        {
            var mapString = new StringBuilder();
            for (int y = 0; y<= newMap.map.GetUpperBound(1); y++)
            {
                for (int x = 0; x <= newMap.map.GetUpperBound(0); x++)
                {
                    mapString.Append(GetSymbol(newMap.map[x, y]?.TileType)+"     ");
                }
                mapString.AppendLine();
            }
            return mapString.ToString();
        }

        private char GetSymbol(Tile.TILETYPE? tileType)
        {
            switch (tileType)
            {
                case Tile.TILETYPE.hero:
                    return 'H';
                case Tile.TILETYPE.goblin:
                    return 'G';
                case Tile.TILETYPE.obstacle:
                    return 'X';
                case Tile.TILETYPE.emptyTile:
                    return '.';
                default:
                    return '_';
            }
        }

        public void Save()
        {
            FileStream stream = new FileStream(SAVE_FILE_NAME, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, Map);
            stream.Close();
        }
        public bool Load()
        {
            if (!File.Exists(SAVE_FILE_NAME))
            {
                return false;
            }
            FileStream stream = new FileStream(SAVE_FILE_NAME, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();

           newMap = (Map)bf.Deserialize(stream);
            stream.Close();
            return true;

        }
    }
}
