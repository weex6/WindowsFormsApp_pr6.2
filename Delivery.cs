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
    public partial class Delivery : Form
    {
        
        Facade1 facade1 = new Facade1(new ClassOrder(), new ClassDelivery());
        public Delivery()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnInCity_Click(object sender, EventArgs e)
        {
            facade1.Process(); this.Close();
        }

        private void btnOutCity_Click(object sender, EventArgs e)
        {
            facade1.NoDelivery(); 
        }
    }
}
