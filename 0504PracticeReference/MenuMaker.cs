using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0504PracticeReference
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Beef", "Salami", "Turkey", "Ham", "Pork" };
        string[] Condiments = { "Yellow Mustard", "ketchup", "Honey Mustard", "mayo", "relish", "french dressing" };
        string[] Breads = { "Rye Bread", "White Bread", "Wheat Bread", "Pumpernickel Bread", "Italian Bread(Focaccia)", "A Roll" };

        //每個字串陣列隨機 .Next(length)
        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string ramdomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string ramdomBreads = Condiments[Randomizer.Next(Breads.Length)];
            return randomMeat + "  +  " + ramdomBreads + "  with  " + ramdomCondiments;
        }
    }
}
