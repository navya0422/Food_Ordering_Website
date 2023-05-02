using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Ordering_Website;
using NSubstitute.ReceivedExtensions;
using Pizza;

namespace Food_Ordering_Website
{
    public partial class Billing : Form
    {
        Functions Con;
        public Billing()
        {
            Con = new Functions();
            InitializeComponent();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            obj.Show();
            this.Hide();
        }

        int Price = 0;
        private void GetPrice(int Key)
        {
            
            string IceCream = "";
            if (Key == 1)
            {
                IceCream = "Vanilla";
            }
            if (Key == 2)
            {
                IceCream = "Strawberry";
            }
            if (Key == 3)
            {
                IceCream = "Chocolate";
            }
            if (Key == 4)
            {
                IceCream = "Rocky Road";
            }
            if (Key == 5)
            {
                IceCream = "Chocolate Chip";
            }
            string Query = "Select * from PizzaTable where Item ='{0}'";
            Query =string.Format(Query, IceCream);
            Price= Convert.ToInt32(Con.GetData(Query).Rows[0][1].ToString());
        }

        int Key = 0;
        string Item;
        int n = 0;
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if (VanillaBtn.Checked == true)
            {
                Key = 1;
                Item = "Vanilla";
            }
            if (StraBtn.Checked == true)
            {
                Key = 2;
                Item = "Strawberry";
            }
            if (ChocBtn.Checked == true)
            {
                Key = 3;
                Item = "Chocolate";
            }
            if (RockyBtn.Checked == true)
            {
                Key = 4;
                Item = "Rocky Road";
            }
            if (ChocChipBtn.Checked == true)
            {
                Key = 5;
                Item = "Chocolate Chip";
            }
            GetPrice(Key);
            int Qty = Convert.ToInt32(QtyTb.Text);
            int total = Qty * Price;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BillDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value= Item;
            newRow.Cells[2].Value = Price;
            newRow.Cells[3].Value = QtyTb.Text;
            newRow.Cells[4].Value = total;
            BillDGV.Rows.Add(newRow);
            n++;
            


        }
        int GrdTotal = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (VanilaBtn.Checked == true)
            {
                Key = 1;
                Item = "Vanilla";
            }
            if (StrawBerryBtn.Checked == true)
            {
                Key = 2;
                Item = "Strawberry";
            }
            if (ChocolateBtn.Checked == true)
            {
                Key = 3;
                Item = "Chocolate";
            }
            if (RockyRoadBtn.Checked == true)
            {
                Key = 4;
                Item = "Rocky Road";
            }
            if (ChocolateChipBtn.Checked == true)
            {
                Key = 5;
                Item = "Chocolate Chip";
            }
            GetPrice(Key);
            int Qty = Convert.ToInt32(QtyyTb.Text);
            int total = Qty * Price;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BillDGView);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = Item;
            newRow.Cells[2].Value = Price;
            newRow.Cells[3].Value = QtyyTb.Text;
            newRow.Cells[4].Value = total;
            BillDGView.Rows.Add(newRow);
            n++;
            GrdTotal = GrdTotal+ total;
            GrdTotalLbl.Text = "$" + GrdTotal;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            obj.Show();
            this.Hide();
        }
        PrintDocument PrintDocument1 = new PrintDocument();
        PrintPreviewDialog PrintPreviewDialog1 = new PrintPreviewDialog();
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument1_PrintPage);
            PrintPreviewDialog1.Document = PrintDocument1;
            if (PrintPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument1.Print();
            }
        }
        int prodid,prodprice,prodqty,tottal,pos =70;
        string prodname;
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            e.Graphics.DrawString("Pizza Ordering", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80, 20));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 50));
            foreach(DataGridViewRow row in BillDGView.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column"].Value);
                prodname = Convert.ToString(row.Cells["Columnn"].Value);
                prodprice = Convert.ToInt32(row.Cells["Columnnn"].Value);
                prodqty = Convert.ToInt32(row.Cells["Columnnnnn"].Value);
                tottal = Convert.ToInt32(row.Cells["Columnnnnnn"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString(""+ prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45,pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(130, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));

                pos = pos + 20;

            }
            e.Graphics.DrawString("Grand Total: $"+ GrdTotal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(50, pos+50));
            e.Graphics.DrawString("***************ICECREAM*************", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(10, pos+85));

            BillDGView.Rows.Clear();
            BillDGView.Refresh();
            pos= 100;
            GrdTotal = 0;
            n = 0;
            e.HasMorePages = false;
        }
    }
}
