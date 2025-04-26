using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinemark
{
    public partial class Form1 : Form
    {
        Button[,] lugares = new Button[10, 20];
        char letra = 'A'; // 0100 0001 em decimal 65 e em hexa 41
        float faturamento = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int coluna = 0; coluna < 10; coluna++)
            {
                for (int linha = 0; linha < 20; linha++)
                {
                    lugares[coluna, linha] = new Button();
                    lugares[coluna, linha].Size = new Size(90, 40);
                    lugares[coluna, linha].Location = new Point(100 * coluna + 25, 40 * linha + 25);
                    int cadeiraNumero = linha + 1;
                    lugares[coluna, linha].Text = letra.ToString() + cadeiraNumero.ToString();
                    lugares[coluna, linha].BackColor = Color.Green;
                    Controls.Add(lugares[coluna, linha]);

                    lugares[coluna, linha].Click += Botao_Clickado;
                }

                ++letra;
            }
        }
        private void Botao_Clickado(object sender, EventArgs e)
        {
            Button botaoClicado = sender as Button;
            if (botaoClicado.BackColor == Color.Green)
            {
                DialogResult resultado = MessageBox.Show(
                    "Deseja reservar este lugar?",
                    "Confirmação de Reserva",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    botaoClicado.BackColor = Color.Red;
                    faturamento += 20;
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show(
                    "Deseja cancelar a reserva deste lugar?",
                    "Cancelar Reserva",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    botaoClicado.BackColor = Color.Green;
                    faturamento -= 20;
                }
            }

        }

        private void Faturamento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O faturamento foi de R$" + faturamento.ToString());
        }
    }
}
