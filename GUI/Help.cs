using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            bodyText.Text = "Mastermind is a code-breaking game.\n" +
                "The player has 10 attempts to guess the secret combination of colors.\n" +
                "If a color is guessed, but the position is wrong, a white point will be rewarded.\n" +
                "If a color and it's position is guessed, a black point will be rewarded.";

            base.Text = "How To Play";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Menu().Show();
            this.Dispose();
        }
    }
}
