using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortearFrutas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
        int num3;
        int ponto = 25;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random gera1 = new Random();
            num1 = gera1.Next(1,5);

            if (num1 == 1)
            {
                pictureBox1.Image = Properties.Resources.cogumelo;
            }
            else if (num1 == 2)
            {
                pictureBox1.Image = Properties.Resources.venenoso;
            }
            else if (num1 == 3)
            {
                pictureBox1.Image = Properties.Resources.sino;
            }
            else if (num1 == 4)
            {
                pictureBox1.Image = Properties.Resources.estrela;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.flor;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random gera2 = new Random();
            num2 = gera2.Next(1, 5);

            if (num2 == 1)
            {
                pictureBox2.Image = Properties.Resources.cogumelo;
            }
            else if (num2 == 2)
            {
                pictureBox2.Image = Properties.Resources.venenoso;
            }
            else if (num2 == 3)
            {
                pictureBox2.Image = Properties.Resources.sino;
            }
            else if (num2 == 4)
            {
                pictureBox2.Image = Properties.Resources.estrela;
            }
            else 
            {
                pictureBox2.Image = Properties.Resources.flor;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        { 
            Random gera3 = new Random();
            num3 = gera3.Next(1, 5);

            if (num3 == 1)
            {
                pictureBox3.Image = Properties.Resources.cogumelo;
            }
            else if (num3 == 2)
            {
                pictureBox3.Image = Properties.Resources.venenoso;
            }
            else if (num3 == 3)
            {
                pictureBox3.Image = Properties.Resources.sino;
            }
            else if (num3 == 4)
            {
                pictureBox3.Image = Properties.Resources.estrela;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.flor;
            }
        }
        private void buttonGirar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;

            ponto -= 5;
            label2.Text = "Pontos: " + ponto.ToString();

            buttonGirar.Enabled = false;
            buttonParar.Enabled = true;

        }

        private void buttonParar_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;

            buttonGirar.Enabled = true;
            buttonParar.Enabled = false;

            if (num1 == num2 && num3 == num2 && num3 == 1)
            {
                ponto += 25;
                label2.Text = "Pontos: " + ponto.ToString();
            }
            if (num1 == num2 && num3 == num2 && num3 == 2)
            {
                ponto = 0;
                label2.Text = "Pontos: " + ponto.ToString();
            }
            if (num1 == num2 && num3 == num2 && num3 == 3)
            {
                ponto += 50;
                label2.Text = "Pontos: " + ponto.ToString();
            }
            if (num1 == num2 && num3 == num2 && num3 == 4)
            {
                ponto += 100;
                label2.Text = "Pontos: " + ponto.ToString();
            }
            if (num1 == num2 && num3 == num2 && num3 == 5)
            {
                ponto += 50;
                label2.Text = "Pontos: " + ponto.ToString();
            }

            if (ponto == 0)
            {
                MessageBox.Show("Você perdeu, Tente novamente", "Perdeu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ponto += 25;
                label2.Text = "Pontos: " + ponto.ToString();
            }
        }
    }
}
