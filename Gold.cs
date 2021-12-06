using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
    class Gold : Item
    {
        const int MINGOLDAMNT = 1;
        const int MACGOLDAMNT = 5;

        private int goldAmount;
        private static Random rng = new Random();
        public int Amount
        {
            get { return goldAmount; }
        }
        public Gold(int x, int y): base(x, y)
        {
            goldAmount = rng.Next(MINGOLDAMNT, MACGOLDAMNT+1);
        }
        public override string ToString()
        {
            return ""+ goldAmount;
        }
        // private int goldAmount;
        /* public int GoldAmount
          {
              get { return goldAmount; }
              set { goldAmount = value;
                  Item rngGold = new Item();
                  Random rngGold2 = new Random();

              }


          }*/

    }
}
