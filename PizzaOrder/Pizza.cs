using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    class Pizza
    {
        private int index;
        
        public RadioButton Sauce;
        public RadioButton Cheese = null;
        public string SpecialInstructions;
        public bool[] ToppingsBool = new bool[11];
        public string[] Toppings = {"Pepperoni", "Bacon", "Ham", "Mushroom", "Pineapple", "Tomato", "Green Peppers", "Onion", "Spinach", "Olive, Black", "Olive, Green"};

        public Pizza(int index)
        {
            this.index = index;
        }
    }
}
