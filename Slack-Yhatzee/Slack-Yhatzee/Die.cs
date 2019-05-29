using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Slack_Yhatzee
{
    class Die
    {
        //"Die" is the singular of "Dice" FYI
        private int value;
        private int imageIndex;


        public int Value { get => value; }
        public int ImageIndex { get => imageIndex; } //Image number in the array

        public void roll()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int randomNumber = rand.Next(0, 6);
            imageIndex = randomNumber;
            value = randomNumber + 1;
        }

        //public int randomNumber()
        //{
        //    int number;

        //    Random rand = new Random(Guid.NewGuid().GetHashCode());
        //    number = rand.Next(0, 6);

        //    return number;
        //}

        
    }
}
