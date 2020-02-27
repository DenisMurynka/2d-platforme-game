using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombsAway
{
    public partial class ABOUT : Form
    {
        public ABOUT()
        {
            InitializeComponent();
        }
        MENU menu = new MENU();

        private void ABOUT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                menu.Show();
            }
        }
    }
}
