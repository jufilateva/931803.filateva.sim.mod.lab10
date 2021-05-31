using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int ScoreComp(double a)
        {
            //Random r = new Random();
            //double a = r.NextDouble();
            int i;
            double[] prob = new double[8];
            prob[0] = 0.05;
            prob[1] = prob[0] + 0.04;
            prob[2] = prob[1] + 0.12;
            prob[3] = prob[2] + 0.18;
            prob[4] = prob[3] + 0.25;
            prob[5] = prob[4] + 0.19;
            prob[6] = prob[5] + 0.12;
            prob[7] = prob[6] + 0.05;
            for(i = 0; i < 8; i++)
            {
                if (a < prob[i])
                {
                    break; 
                }
                
            }
            return i + 1;
        }

        public int ScorePlayer(double a)
        {
            //Random r = new Random();
            //double a = r.NextDouble();
            int i;
            double[] prob = new double[8];
            prob[0] = 0.125;
            for (int k = 1; k < 8; k++) prob[k] = prob[k - 1] + 0.125; 
            for (i = 0; i < 8; i++)
            {
                if (a < prob[i])
                {
                    break;
                }

            }
            return i + 1;
        }
        private void b_computer_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double a = r.NextDouble();
            int score1 = ScoreComp(a);
            l_comp1.Text = score1.ToString();
            a = r.NextDouble();
            int score2 = ScoreComp(a);
            l_comp2.Text = score2.ToString();
            int sum = score1 + score2;
            csum.Text = sum.ToString();
        }

        private void b_player_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double a = r.NextDouble();
            int score1 = ScorePlayer(a);
            l_pl1.Text = score1.ToString();
            a = r.NextDouble();
            int score2 = ScorePlayer(a);
            l_pl2.Text = score2.ToString();
            int sum = score1 + score2;
            psum.Text = sum.ToString();
        }

        private void b_winner_Click(object sender, EventArgs e)
        {
            int comp = Convert.ToInt32(csum.Text);
            int pl = Convert.ToInt32(psum.Text);
            if (Math.Abs(10 - comp) < Math.Abs(10 - pl)) winner.Text = "Компьютер";
            else
            {
                if (Math.Abs(10 - comp) > Math.Abs(10 - pl)) winner.Text = "Игрок";
                else winner.Text = "Ничья";
            }
        }
    }
}
