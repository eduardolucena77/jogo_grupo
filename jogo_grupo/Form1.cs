﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_grupo
{
    public partial class Form1 : Form
    {

        int Xplayer = 0, Oplayer = 0, EmpatesPontos = 0, rodadas = 0;
        bool turno = true, jogo_final = false;
        string[] texto = new string[9];

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;

            if (btn.Text == "" && jogo_final == false)


            if (turno)
            {
                btn.Text = "X";
                texto[buttonIndex] = btn.Text;
                rodadas++;
                turno = !turno;
                Checagem(1);
            }
            else
            {
                btn.Text = "O";
                texto[buttonIndex] = btn.Text;
                rodadas++;
                turno = !turno;
                Checagem(2);
                }

        }

        void Checagem(int ChecagemPlayer)
        {
            string suporte = "";

            if (ChecagemPlayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }

            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if (suporte == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        MessageBox.Show("Deu certo!");
                        return;
                    }
                }
            }

            for (int vertical = 0; vertical < 3; vertical ++)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        MessageBox.Show("Deu certo!");
                        return;
                    }





                }

        }   }
    }
}
