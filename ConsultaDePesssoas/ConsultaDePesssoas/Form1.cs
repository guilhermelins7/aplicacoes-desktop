using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MinhaLib;

namespace ConsultaDePesssoas
{
    public partial class Form1 : Form
    {

         Pessoa umaPessoa = new Pessoa();
        public Form1()
        {
            InitializeComponent();
        }

        private void deletarBtn_Click(object sender, EventArgs e)
        {
            codigoInput.Text = "";
            nomeInput.Text = "";
            idadeInput.Text = "";
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            umaPessoa.setCodigo(codigoInput.Text);
            umaPessoa.setNome(nomeInput.Text);
            umaPessoa.setSexo(sexoInput.Text);
            umaPessoa.setIdade(idadeInput.Text);

            PessoaBLL.validaDados(umaPessoa);

            if (Erro.getErro())
                MessageBox.Show(Erro.getMens());
            else
                MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void lerBtn_Click(object sender, EventArgs e)
        {
            umaPessoa.setCodigo(codigoInput.Text);
            PessoaBLL.validaCodigo(umaPessoa);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMens());
            else
            {
                codigoInput.Text = umaPessoa.getCodigo();
                nomeInput.Text = umaPessoa.getNome();
                sexoInput.Text = umaPessoa.getSexo();
                idadeInput.Text = umaPessoa.getIdade();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PessoaBLL.conecta();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMens());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PessoaBLL.desconecta();
        }
    }
}
