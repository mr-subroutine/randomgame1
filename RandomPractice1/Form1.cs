using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPractice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rdm = new Random();

        private void btn_p1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            int p1random = 0;
            int p1total = 0;
            int p2random = 0;
            int p2total = 0;

            for (int i = 0; i < 10; i++)
            {
                p1random = rdm.Next(1, 11);
                p1total += p1random;
                p2random = rdm.Next(1, 11);
                p2total += p2random;
            }

            if (p1total > p2total)
            {

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
