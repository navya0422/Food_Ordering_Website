using Food_Ordering_Website;
using Pizza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_Website
{
    public partial class Settings : Form
    {
        Functions Con;

        public Settings()
        {
            
            InitializeComponent();
            Con = new Functions();
        }

        //Back
        private void label5_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
            this.Hide();
        }

        //Submit
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string Key;
            try
            {
               
                 int Pr =Convert.ToInt32(PriceTb.Text);

                // Use the "pr" variable in your code below...

                if (IceCb.SelectedIndex== -1)
                {
                    MessageBox.Show("Please select an Ice Cream");
                }
                else if(IceCb.SelectedIndex == 0)
                {

                    Key = "Vanilla";
                    string Query = "Update PizzaTable set Price ={0} where Item ='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.SetData(Query);
                    MessageBox.Show("price updated!");
                }
                else if (IceCb.SelectedIndex == 1)
                {

                    Key = "Strawberry";
                    string Query = "Update PizzaTable set Price ={0} where Item ='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.SetData(Query);
                    MessageBox.Show("price updated!");
                }
                else if (IceCb.SelectedIndex == 2)
                {

                    Key = "Chocolate";
                    string Query = "Update PizzaTable set Price ={0} where Item ='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.SetData(Query);
                    MessageBox.Show("price updated!");
                }
                else if (IceCb.SelectedIndex == 3)
                {

                    Key = "Rocky Road";
                    string Query = "Update PizzaTable set Price ={0} where Item ='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.SetData(Query);
                    MessageBox.Show("price updated!");
                }
                else if (IceCb.SelectedIndex == 4)
                {

                    Key = "Chocolate Chip";
                    string Query = "Update PizzaTable set Price ={0} where Item ='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.SetData(Query);
                    MessageBox.Show("price updated!");
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
