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
    public partial class MENU : Form
    {
        System.Media.SoundPlayer mus_menu = new System.Media.SoundPlayer();

        public MENU()
        {

            InitializeComponent();
             mus_menu.SoundLocation = "Sound_19252.wav";
            mus_menu.Play();
        }
      
        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();

        }
        #region KEYBOARDS
        private void keyisdown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {     case Keys.Escape:
                    this.Close();
                    break;
            }
        }
        #region BUTTONS CLICK
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            this.Hide();
            form2.Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            //mus_menu.Stop();
            ABOUT aboutForm = new ABOUT();
            this.Hide();
            aboutForm.Show();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonScore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The best score"+ " " + Properties.Settings.Default.Highscore);

        }
        #endregion

        #endregion


    }

}
