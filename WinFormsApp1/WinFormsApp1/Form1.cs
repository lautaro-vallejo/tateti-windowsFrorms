using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool turnoX = true;
        int movimientos = 0;
        public Form1()
        {
            InitializeComponent();
            button1.Click += button_Click;
            button2.Click += button_Click;
            button3.Click += button_Click;
            button4.Click += button_Click;
            button5.Click += button_Click;
            button6.Click += button_Click;
            button7.Click += button_Click;
            button8.Click += button_Click;
            button9.Click += button_Click;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (boton.Text != "")
                return;

            if (turnoX)
            {
                boton.Text = "X";
                boton.ForeColor = Color.Blue;
            }
            else
            {
                boton.Text = "O";
                boton.ForeColor = Color.Red;
            }

            turnoX = !turnoX;
            movimientos++;

            Verificar();
        }


        private void Verificar()
        {
            bool hayGanador = false;

            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                hayGanador = true;
            }
            if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                hayGanador = true;
            }
            if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                hayGanador = true;
            }

            if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                hayGanador = true;
            }
            if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                hayGanador = true;
            }
            if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                hayGanador = true;
            }

            if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                hayGanador = true;
            }
            if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                hayGanador = true;
            }

            if (hayGanador)
            {
                string ganador = turnoX ? "O" : "X";
                MessageBox.Show("gano " + ganador + "!");
                DeshabilitarBtn();
            }
            else if (movimientos == 9)
            {
                MessageBox.Show("empate");
            }
        }

        private void DeshabilitarBtn()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            button1.Text = button2.Text = button3.Text = "";
            button4.Text = button5.Text = button6.Text = "";
            button7.Text = button8.Text = button9.Text = "";

            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button4.Enabled = button5.Enabled = button6.Enabled = true;
            button7.Enabled = button8.Enabled = button9.Enabled = true;

            turnoX = true;
            movimientos = 0;
        }
    }
}
