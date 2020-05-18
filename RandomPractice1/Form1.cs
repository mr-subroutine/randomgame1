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

            //MessageBox.Show("Decide who is Player 1 and Player 2 and press OK to begin.");

            int p1random;
            int p1total = 0;
            int p2random;
            int p2total = 0;

            int p1total_test = 0;
            int p1random_test = 0;
            int p2total_test = 0;
            int p2random_test = 0;
            int test_counter = 0;

            for (int i = 0; i < 100; i++)
            {
                p1random = rdm.Next(1, 101);
                p1total += p1random;
                p2random = rdm.Next(1, 101);
                p2total += p2random;
            }

            if (p1total > p2total)
            {
                textBox1.Text += "Player 1 wins!" + Environment.NewLine;
                textBox1.Text += "Score: " + p1total.ToString() + " over " + "Player 2's lesser score of " + p2total.ToString() + Environment.NewLine;
            }

            else if (p2total > p1total)
            {
                textBox1.Text += "Player 2 wins!" + Environment.NewLine;
                textBox1.Text += "Score: " + p2total.ToString() + " over " + "Player 1's lesser score of " + p1total.ToString() + Environment.NewLine;
            }

            else if (p1total == p2total)
            {
                textBox1.Text += "A rare event has occured.  A tie." + Environment.NewLine;
            }

            // see if a tie can occur

            do
            {
                
                p1random_test = rdm.Next(1, 101);
                p1total_test += p1random_test;
                p2random_test = rdm.Next(1, 101);
                p2total_test += p2random_test;
                test_counter++;
                
            } while (p1total_test != p2total_test);

            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Test: " + Environment.NewLine;
            textBox1.Text += "A tie has been reached: " + p2total_test.ToString() + " ...and... " + p2total_test.ToString() + Environment.NewLine;
            textBox1.Text += "It took " + test_counter.ToString() + " times";
        }

        private void btn_rdm_occur_Click(object sender, EventArgs e)
        {
            Random rdm2 = new Random();

            textBox1.Clear();
            int rdmOccur = 0;
            int[] values = new int[101];
            int rdmCounter = 0;

            while (rdmCounter < 100)
            {
                rdmOccur = rdm2.Next(0, 100);
                values[rdmOccur] = values[rdmOccur] + 1;
                rdmCounter++;
            }

            textBox1.Text += "47 was hit " + values[47].ToString() + Environment.NewLine;
            textBox1.Text += Environment.NewLine;
            for (int i = 0; i < 100; i++)
            {
                textBox1.Text += "INDEX " + i.ToString() + " Occurance: " +  values[i].ToString();
                textBox1.Text += Environment.NewLine;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Random rdm3 = new Random();
            int grandTotal = 0;
            int costToPlay = 8;
            int di1 = 0;
            int di2 = 0;

            for (int i = 0; i < 999; i++)
            {
                di1 = rdm3.Next(1, 7);
                di2 = rdm3.Next(1, 7);
                grandTotal += di1 + costToPlay;
                grandTotal += di2;
            }
            textBox1.Text = "Total Winnings: " + grandTotal.ToString("c");
        }

        private void btn_15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Random rdm4 = new Random();
            int grandTotal2 = 0;
            int costToPlay = 15;
            int di1 = 0;
            int di2 = 0;

            for (int i = 0; i < 999; i++)
            {
                di1 = rdm4.Next(1, 7);
                di2 = rdm4.Next(1, 7);
                grandTotal2 += di1 + costToPlay;
                grandTotal2 += di2;
            }
            textBox1.Text = "Total Winnings: " + grandTotal2.ToString("c");
        }
    }
}
