using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVP_Arena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDow(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W)
            {
                Manager.player1.walk(Direction.FORWART);
            }else if (e.KeyCode == Keys.S)
            {
                Manager.player1.walk(Direction.BACKWART);
            }
            else if (e.KeyCode == Keys.A)
            {
                Manager.player1.walk(Direction.LEFT);
            }
            else if (e.KeyCode == Keys.D)
            {
                Manager.player1.walk(Direction.RIGHT);
            }
        }

    }
}
