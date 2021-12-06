using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
    class Map
    {
        public Tile[,] map;
        public Hero player;
        public Enemy[] enemies;
        Item[] items;

        public int width;
        public int height;
        Random random;

        public Hero Player
        {
            get { return player; }
        }

        public Enemy[] Enemies
        {
            get { return enemies; }
        }

        public Item[] Items
        {
            get { return items; }
        }

        public Map(int minWidth, int maxWidth, int minHeight , int maxHeight, int numEnemies, int numItems)
        {
            random = new Random();
            height = random.Next(minHeight, maxHeight + 1);
            width = height;//  width = random.Next(minHeight, maxHeight + 1);
            map = new Tile[height, height];

            enemies = new Enemy[numEnemies];
            items = new Item[numItems];

            UpdateMap();

            int xMax = map.GetUpperBound(0);
            var yMax = width - 1;

            for (int x = 0; x <= xMax; x++)
            {
                map[0,x] = new Obstacle(0,x);
                map[xMax, x] = new Obstacle(xMax,x);
            }
            for (int y = 0; y <= xMax ; y++)
            {
                map[y,0] = new Obstacle(y,0);
                map[y,xMax ] = new Obstacle(y,xMax );
            }
            /*
            for (int x = 1; x <= xMax -1; x++)
            {
                for (int y = 1; y <= xMax-1; y++)
                {
                    map[y, x] = new EmptyTile(y, x);
                }
            }
            */
                    player = Create(Tile.TILETYPE.hero) as Hero;
            for (int x = 0; x < enemies.Length; x++)
            {
                var enemy = Create(Tile.TILETYPE.enemy);

                enemies[x] = enemy as Enemy;

            }
            int randPosX = random.Next(0, height);
            int randPosY = random.Next(0, height);
            while (map[randPosX,randPosY] != null)
            {
                 randPosX = random.Next(0, height);
                 randPosY = random.Next(0, height);
            }
            map[randPosX, randPosY] = new Hero(randPosX,randPosY,100); 

            UpdateVision();
        }

        /* public bool Movehero(Character.Movement direction)
         {
             if (Map.pla)
             {

             }
             return true;
         }*/
        private void PopulateMap()
        {
            for (int y = 0; y <= height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                    {
                        map[x, y] = new Obstacle(x, y);
                    }
                    else
                    {
                        map[x, y] = new EmptyTile(x, y);
                    }
                }
            }
        }

        public string NewMap()
        {
            map = new Tile[width, height];
            PopulateMap();
            for (int i = 0; i < enemies.Length; i++)
            {
                map[enemies[i].X, enemies[i].Y] = enemies[i];
            }
            if (Player != null)
            {
                map[Player.X, Player.Y] = player;
            }
            map.ToString();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    continue;
                }
                else
                {
                    map[items[i].X, items[i].Y] = items[i];
                }
            }
            return "";
        }
        public void UpdateMap()
        {

        }
        public void UpdateVision()
        {
            foreach (var tile in map)
            {
                if (tile != null && (tile.TileType == Tile.TILETYPE.hero || tile.TileType == Tile.TILETYPE.enemy))
                {
                    Character character = tile as Character;

                    character.Vision = new Tile[]
                    {
                        map[character.X, character.Y - 1],
                        map[character.X, character.Y + 1],
                        map[character.X + 1, character.Y],
                        map[character.X - 1, character.Y]
                    };

                    map[character.X, character.Y] = character;
                }
            }
        }

        public Tile GetTileAt(int x, int y)
        {
            if (x < 0 || x >= width || y < 0 || y >= height)
            {
                return null;
            }
            return map[x, y];
        }
        public void SetEmptyTile(int x, int y)
        {
            if (x > 1 || x < width - 1 || y > 1 || y < height - 1)
            {

            }
        }
        public Item GetItemAtPosition(int x, int y)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i]==null)//Guarding if statement
                {
                    continue;
                }
                if (items[i].X == x && items[i].Y == y)
                {
                    Item item = items[i];
                    items[i] = null;
                    return item;
                }
            }
            return null;

        }
  //update map
        private Tile Create(Tile.TILETYPE tileType)
        {
            Tile tile = null;

            while (tile == null)  //1 == 1)
            {
                int rand1 = random.Next(1, width);
                int rand2 = random.Next(1, height);

                if (map[rand1, rand2] == null)
                {
                    string temp =tileType.ToString();
                    System.Diagnostics.Debug.WriteLine("Found"+temp);
                    switch (tileType)
                    {
                        case Tile.TILETYPE.hero:
                            tile = new Hero(rand1, rand2, 100);
                            break;
                        case Tile.TILETYPE.enemy:
                            tile = new Goblin(rand1, rand2);
                            break;
                        case Tile.TILETYPE.mage:
                            tile = new Mage(rand1, rand2);
                            break;
                        case Tile.TILETYPE.leader:
                            tile = new Leader(rand1, rand2);
                            break;
                    }

                    map[rand1, rand2] = tile;

                    return tile;
                }
            }

            return tile;
        }


        public override string ToString()
        {
            string value = "";
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x== player.X && y == player.Y)
                    {
                        value += "H";
                        continue;
                    }
                    if (map[x,y] is EmptyTile)
                    {
                        value += ".";
                     
                    }
                    else if (map[x, y] is Obstacle)
                    {
                        value += "X";

                    }

                    if (map[x,y] is Goblin)
                    {
                        enemy = (Enemy)map[x, y];
                        if (enemy.IsDead(enemy)==true)
                        {
                            value += 'x';
                        }
                        else
                        {
                            value += 'G';
                        }

                    }
                    else if (map[x,y] is Mage)
                    {
                        enemy = (Enemy)map[x, y];
                        if (enemy.IsDead(enemy) == true)
                        {
                            value += 'x';
                        }
                        else
                        {
                            value += 'M';
                        }
                    }
                    else if (map[x, y] is Leader)
                    {
                        enemy = (Enemy)map[x, y];
                        if (enemy.IsDead(enemy) == true)
                        {
                            value += 'x';
                        }
                        else
                        {
                            value += 'L';
                        }
                    }
                    else if (map[x, y] is Gold)
                    {
                       
                            value += '$';
                    }
                    else if (map[x, y] is MeleeWeapon)
                    {

                        value += '>';
                    }
                    else if (map[x, y] is RangedWeapon)
                    {

                        value += ')';
                    }


                }
                value += "/n";
            }
            return value; 
        }
    }

}
