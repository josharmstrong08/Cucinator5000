using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cucinator5000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int step = 10;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    cuceSilver.Top += step;
                    break;
                case Keys.Up:
                    cuceSilver.Top -= step;
                    break;
                case Keys.Left:
                    cuceSilver.Left -= step;
                    break;
                case Keys.Right:
                    cuceSilver.Left += step;
                    break;
            }
        }
    }
}
