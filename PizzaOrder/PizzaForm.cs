/* Program ID: SDraper_Assignment2
 * 
 * Purpose: create an order form for a user to select a pizza and dress it accordingly
 * 
 * History:
 *      created by Stephen Draper, june 2020
 */

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class PizzaForm : Form
    {
        RadioButton pizza = null; // allows us to save the most recently selected pizza radio box for use in assignment
        

        public PizzaForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event occurs when the user clicks "Start Order". It will check the number they have input, validate it, and then create a number of radio buttons to emulate
        /// pizzas according to the number that they have input. It also checks against the pre-existing number of pizzas, in cases of them changing the number of pizzas that they input,
        /// or simply clicking the button more than once.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartOrder_Click(object sender, EventArgs e)
        {
            bool valid = false; // basic validate bool
            
            if (int.TryParse(txtPizzaNumber.Text, out int num)) // checks if their character is an int
            {
                if(num < 1) // if it is, but it's less than one
                {
                    MessageBox.Show("Please enter a 1-9 number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // error message
                    txtPizzaNumber.Text = string.Empty; // empties the text box
                    txtPizzaNumber.Focus(); // focuses them back in the box
                }
                else
                {
                    valid = true; // yay they passed
                }    
            }   
            else // their character wasn't an int
            {
                MessageBox.Show("Please enter a 1-9 number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // we tell them off
                txtPizzaNumber.Text = string.Empty; // scrub their pitiful answer
                txtPizzaNumber.Focus(); // give them another chance, like the benevolent gods we are
            }
            
            if (valid) // if they passed our validation
            {
                int length = pnlPizzas.Controls.Count; // we'll use this enough that I didn't want to write it out every time. Control.
                                                       // Count simply tallies the number of radiobuttons(pizzas) in the panel, since those are the only controls that will ever be in there.
                if (num < length) // if they enter a number smaller than the currently created number of pizzas, and we have to delete some
                {
                    for(int i = (length-1); i>(num-1);i--) // gotta step backwards through our loop or we throw index errors (I could have just deleted at num each time instead of i, I just didn't think of it until later)
                    {
                        RadioButton deletePizza = pnlPizzas.Controls[i] as RadioButton; // target the correct pizza for deletion
                        pnlPizzas.Controls.Remove(deletePizza); // remove it using the container controls. Since the class is stored within the tag, this deletes the associated class as well.
                    }
                    RadioButton focus = pnlPizzas.Controls[0] as RadioButton; // if they had previously been focusing a pizza that got deleted, it would leave up the information for that pizza.
                    focus.Focus();                                            // so I just focused the first pizza. It won't ever index error because we already catch 0.
                }

                else if (num > length) // if they enter a number larger than the current number of pizzas
                {
                    int Hspacing = 30; // int to hold the horizontal spacing - not actually necessary to put here, but for easy changes later we'll leave it
                    int Vspacing = 20; // int to hold vertical spacing
                    for (int i = length; i < num; i++) // start at the previous stopping point by targetting the length, then go until we hit the new desired length
                    {
                        RadioButton pizza = new RadioButton(); // yo we made a new pizza we're baking students now (simply creates the new button that will be placed and gives it a name for us to reference)
                        pizza.Location = new Point(Hspacing, (150 * i + Vspacing * (i + 1))); // location for our new button
                        pizza.Appearance = Appearance.Button; // changes it to look like a button instead of a radio button
                        pizza.Size = new Size(150, 150); // size change
                        pizza.Click += new EventHandler(pizza_Click); // adds our on-click event handler to the newly created button
                        Pizza pizzaClass = new Pizza(i + 1); // adds a new Pizza Class, fittingly named pizzaClass. It indexes it, which we don't actually end up using, but still isn't the worst thing to have.
                        pizza.Tag = pizzaClass; // stores the newly created class inside of the tag of the newly created button - ties them together, and creates a reference point for us
                        pnlPizzas.Controls.Add(pizza); // actually adds the new button to the Pizzas panel
                        if (i == 0) // if this is the first time we've created a pizza, it focuses the first pizza, so that they aren't in limbo before clicking a pizza manually.
                        {
                            pizza.Focus();
                        }
                    }
                    pnlToppings.Enabled = true; // enables the toppings/sauces/cheese/etc for the user to play with
                }
            }
        }

        /// <summary>
        /// This event handles when the user clicks one of the radio buttons which are our pizzas. It changes all of the radio buttons and checkboxes in the center panel to
        /// be equal to the previous values for the clicked pizza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pizza_Click(object sender, EventArgs e)
        {
            pizza = sender as RadioButton; // grabs the clicked 'pizza'
            Pizza pizzaClass = pizza.Tag as Pizza; // pulls the class out of the tag of the pulled pizza

            foreach(var button in grbToppings.Controls.OfType<CheckBox>()) // runs through each checkbox within the toppings group box
            {
                int index = int.Parse(button.Tag.ToString()); // we added tags to each of the checkboxes relative to thir position within the panel, 0 indexed, horizontal first. 
                                                              // This pulls them for each, as we are stepping through.
                for (int i = 0; i < 11; i++) // simply counts 0-10
                {
                    if(index == i) // if the index that we pulled matches i, it continues
                    {
                        if(pizzaClass.ToppingsBool[i]) // checks if that position within the class boolean array is true or false, and either checks or unchecks the button.
                        {
                            button.Checked = true;
                        }
                        else if(!pizzaClass.ToppingsBool[i])
                        {
                            button.Checked = false;
                        }
                    }
                }
            }

            foreach(var button in grbSauce.Controls.OfType<RadioButton>()) // runs through each radiobutton within the sauce group box
            {
                if(pizzaClass.Sauce == button) // checks the saved .Sauce class and if it is equal to the current button we are checking, marks it true
                {
                    button.Checked = true;
                }
                else if(pizzaClass.Sauce != button) // if not, marks it false. This part is not redundant because they might not have selected anything previously.
                {
                    button.Checked = false;
                }
            }

            foreach (var button in grbCheese.Controls.OfType<RadioButton>()) // runs through each radiobutton within the cheese group box
            {
                if (pizzaClass.Cheese == button) // same as above, checks the class and if the class equals the button, checks it, if not, unchecks it
                {
                    button.Checked = true;
                }
                else if (pizzaClass.Cheese != button)
                {
                    button.Checked = false;
                }
            }

            txtSpecialInstructions.Text = pizzaClass.SpecialInstructions; // pulls the special instructions from the class and overwrites the special instructions text box
        }

        
        /// <summary>
        /// Event occurs when the user selects a sauce. Simply saves the sauce off to the active pizza (last selected radio box).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sauce_Click(object sender, EventArgs e)
        {
            Pizza pizzaClass = pizza.Tag as Pizza; // pulls the active radio button and checks the class stored in its tag
            pizzaClass.Sauce = sender as RadioButton; // assigns the user's selection to the Sauce class
            
        }

        /// <summary>
        /// This event occurs whenever the user clicks on any of the checkboxes within the toppings group box. It pulls the tags (which have been numbered, 0 indexed) and 
        /// matches them up to a same-size array of booleans in order to record their position. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Toppings_Click(object sender, EventArgs e)
        {
            Pizza pizzaClass = pizza.Tag as Pizza; // pulls active radio button and pulls the class that was stored within the tag
            CheckBox Topping = sender as CheckBox; // pulls the clicked topping
            int index = int.Parse(Topping.Tag.ToString()); // parses the tag (that I have assigned 0-10) as an int
            if (pizzaClass.ToppingsBool[index] == false) // if the boolean at the index that I pulled out of the tag was previously false...
            {
                pizzaClass.ToppingsBool[index] = true; // set it to true
            }
            else if(pizzaClass.ToppingsBool[index] == true) // if it was previously true...
            {
                pizzaClass.ToppingsBool[index] = false; // set it to false. Both are needed in case they uncheck things they had previously checked.
            }

        }

        /// <summary>
        /// Occurs when the user clicks Check Out. Validates they have selected the Sauce and Cheese for each pizza, then if they have, disables the 
        /// toppings panel, resizes the form, and outputs their order on a form that is revealed to the right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            
            lblOrderSummary.Text = ""; // wipes the order summary, just in case
            int index = pnlPizzas.Controls.Count; // checks how many pizzas they are checking out with
            bool valid = false; // easy validator

            for (int i = 0; i <index; i++) // runs through each instance of pizza
            {
                RadioButton activePizza = pnlPizzas.Controls[i] as RadioButton; // pulls pizza at index i
                Pizza pizzaClass = activePizza.Tag as Pizza; // pulls the class stored within the active pizza
                if (pizzaClass.Sauce == null) // if they haven't selected a pizza sauce for that pizza
                {
                    MessageBox.Show($"Please select the Sauce type you'd like for pizza {i + 1}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); // tells them off
                    return; // jumps out of the if statement so it doesn't pop up 12 errors if they left the sauce and cheese off 6 pizzas
                }
                else if (pizzaClass.Cheese == null) // if they haven't selected a cheese type for that pizza
                {
                    MessageBox.Show($"Please select the Cheese type you'd like for pizza {i+1}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); // tells them off
                    return; // jumps out of statement
                }
                else if(pizzaClass.Cheese != null && pizzaClass.Sauce != null) // if all cheese and sauce has been selected for each pizza
                {
                    valid = true; // valid!
                }
            }
            if (valid) // if valid
            {
                this.Size = new Size(999, 660); // resizes window to show the order summary
                lblOrderHeader.Visible = true; // we keep the header invisible until they check out, just in case they resize the window manually
                btnNewOrder.Visible = true; // same as above
                pnlToppings.Enabled = false; // turns off the toppings panel when they check out
                for (int i = 0; i < index; i++) // steps through each instance of pizza
                {
                    RadioButton activePizza = pnlPizzas.Controls[i] as RadioButton; // targets pizzas sequentially
                    Pizza pizzaClass = activePizza.Tag as Pizza; // pulls class from active pizza's tag

                    lblOrderSummary.Text += $"Pizza #{i + 1}\r\n"; // outputs the pizza number into order summary
                    lblOrderSummary.Text += $"Sauce: {pizzaClass.Sauce.Text}\r\n"; // outputs sauce type
                    lblOrderSummary.Text += "Toppings: \r\n";
                    for (int j = 0; j < 11; j++) // runs the loop 11 times for each instance within the toppings array
                    {
                        if (pizzaClass.ToppingsBool[j]) // for each boolean, if it is true, continue
                        {
                            lblOrderSummary.Text += $"      {pizzaClass.Toppings[j]}\r\n";  // outputs the topping if the corresponding boolean was true
                                                                                            // I used manual tabs instead of /t because it was the start of the line and was problematic
                        }
                    }
                    lblOrderSummary.Text += $"Cheese: {pizzaClass.Cheese.Text}\r\n"; // outputs cheese type
                    lblOrderSummary.Text += $"Special Instructions: {pizzaClass.SpecialInstructions}\r\n \r\n"; // outputs special instructions

                }
            }
        }


        /// <summary>
        /// Exact same as the sauce. Occurs when the user selects a cheese button. Sends it to the class stored in the active radio button's tag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cheese_Click(object sender, EventArgs e) 
        {
            Pizza pizzaClass = pizza.Tag as Pizza; // pulls class out of active pizza's tag
            pizzaClass.Cheese = sender as RadioButton; // sets cheese within the class to be the chosen button
        }

        /// <summary>
        /// Event occurs when user enters special instructions, each time they change the text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSpecialInstructions_TextChanged(object sender, EventArgs e)
        {
            Pizza pizzaClass = pizza.Tag as Pizza; // pulls class out of active pizza's tag
            pizzaClass.SpecialInstructions = txtSpecialInstructions.Text; // sets special instructions stored within class to be what the user has changed the text to
        }

        /// <summary>
        /// Occurs when user clicks Start New Order. Checks the number of pizzas and runs through a for loop to delete them. Clears all the active buttons, resizes
        /// the window, and basically resets everything back to beginning state. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            for(int i = (pnlPizzas.Controls.Count-1); i>=0;i--) // checks how many created pizzas there are and then steps through the loop backwards to avoid index errors.
            {
                RadioButton deletePizza = pnlPizzas.Controls[i] as RadioButton; // deletes the button at i. In retrospect I could have had the for loop go forwards and delete at 0 each time. Next time!
                pnlPizzas.Controls.Remove(deletePizza); // deletes the targetted button, and the class associated with it
            }
            this.Size = new Size(642, 660); // sizes the form back to the original size
            btnNewOrder.Visible = false; // hides the start new order button, just in case
            lblOrderHeader.Visible = false; // hides the order header just in case
            lblOrderSummary.Visible = false; // hides the order summary just in case
            foreach(var button in grbToppings.Controls.OfType<CheckBox>()) // runs through each checkbox within the toppings box and sets it to false
            {
                button.Checked = false;
            }
            foreach(var button in grbCheese.Controls.OfType<RadioButton>()) // runs through each radiobutton within the cheese box and sets it to false
            {
                button.Checked = false;
            }
            foreach (var button in grbSauce.Controls.OfType<RadioButton>()) // runs through each radiobutton within the sauce box and sets it to false
            {
                button.Checked = false;
            }
            txtSpecialInstructions.Text = string.Empty; // empties special instructions
            txtPizzaNumber.Text = string.Empty; // empties the number of pizzas from the last order
            txtPizzaNumber.Focus(); // focuses the number of pizzas text box
        }
    }
}