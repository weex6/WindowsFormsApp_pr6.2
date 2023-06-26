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
    
    public partial class Order : Form
    {
        Facade1 facade1 = new Facade1(new ClassOrder(), new ClassDelivery());
        public Order(string dish, int price)
        {
            InitializeComponent();
            lbOrder.BackColor = System.Drawing.Color.Transparent;//прозрачный фон
            lbPrice.BackColor = System.Drawing.Color.Transparent;
            lbConfirm.BackColor = System.Drawing.Color.Transparent;
            rtbOrder.BorderStyle = BorderStyle.None; //граница
            rtbOrder.Text = dish;
            lbPrice.Text = "Итоговая стоимость: " + price.ToString() + "р";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            facade1.ConfirmOrder();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            facade1.RejectOrder();
            this.Close();
        }
    }
}
