using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaLib;

namespace ConsultaDePesssoas
{
    class PessoaBLL
    {
        // Método bypass
        public static void conecta()
        {
            PessoaDAL.conecta();
        }

        public static void desconecta()
        {
            PessoaDAL.desconecta();
        }

        public static void validaCodigo(Pessoa umaPessoa)
        {
            Erro.setErro(false);
            if (umaPessoa.getCodigo().Equals(""))
            {
                Erro.setErro("O código é de preenchimento obrigatório!");
                return;
            }
            PessoaDAL.consultaUmaPessoa(umaPessoa);
        }

        public static void validaDados(Pessoa umaPessoa)
        {
            Erro.setErro(false);
            if (umaPessoa.getCodigo().Equals(""))
            {
                Erro.setErro("O código é de preenchimento obrigatório!");
                return;
            }
            if (umaPessoa.getNome().Equals(""))
            {
                Erro.setErro("O Nome é de preenchimento obrigatório!");
                return;
            }
            if (umaPessoa.getSexo().Equals(""))
            {
                Erro.setErro("O sexo é de preenchimento obrigatório!");
                return;
            }
            if (umaPessoa.getIdade().Equals(""))
            {
                Erro.setErro("A Idade é de preenchimento obrigatório!");
                return;
            }


            try
            {
                int.Parse(umaPessoa.getIdade());
            }
            catch (Exception)
            {
                Erro.setErro("O valor da idade deve ser numérico!");
                return;
            }


            if (int.Parse(umaPessoa.getIdade()) <= 0)
            {
                Erro.setErro("O valor da idade deve ser numérico e positivo!");
                return;
            }
            PessoaDAL.inseriUmaPessoa(umaPessoa);
        }

    }
}
