using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfiVersaoUm
{
    public class Fornecedor
    {
        public int NumeroDeCadastro { get; private set; }
        public string Nome { get; private set; }
        public string Categoria { get; private set; }
        public string ID { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        public Fornecedor(int numeroDeCadastro, string nome, string categoria, string id, string estado, string cep, string telefone, string email)
        {
            NumeroDeCadastro = numeroDeCadastro;
            Nome = nome;
            Categoria = categoria;
            ID = id;
            Estado = estado;
            CEP = cep;
            Telefone = telefone;
            Email = email;
        }

        public string EscreverArquivo()
        {
            return NumeroDeCadastro + ";" + Nome + ";"+ Categoria + ";" + ID + ";" + Estado + ";" + CEP + ";" + Telefone + ";" + Email;
        }
    }
}
