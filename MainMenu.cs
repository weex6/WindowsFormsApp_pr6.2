using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_pr6._2
{
    public partial class MainMenu : Form
    {
        List<int> price = new List<int>() { 330, 430, 470, 550, 450, 430};
        Facade1 facade1 = new Facade1(new ClassOrder(), new ClassDelivery());
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            string dishes = "";
            foreach (string dis in chlMenu.CheckedItems)
            {
                dishes += dis + "\n";
            }
            int allPrice = 0;
            foreach(int i in chlMenu.CheckedIndices)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i == j)
                    {
                        allPrice += price[i];
                    }
                }

            }
            if (chlMenu.CheckedItems.Count == 0) MessageBox.Show("Выберите позиции из меню", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else facade1.MakeOrder(dishes, allPrice); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
