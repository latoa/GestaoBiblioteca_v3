using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca
{
    public class Leitor : Pessoa
    {
        public string NumeroCartao { get; set; } = string.Empty;
        public string CartaoCidadao { get; set; } = string.Empty;
        public string Nif { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string Morada { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public string Localidade { get; set; } = string.Empty;

        public Leitor():base(){}

        public Leitor(
            bool ativo,
            int id,
            string nome,
            string email,
            string telefone,
            string numeroCartao,
            string cartaoCidadao,
            string nif,
            DateTime dataNascimento,
            string morada,
            string codigoPostal,
            string localidade)
            : base(ativo, id, string.Empty, String.Empty, nome, email, telefone)
        {
            NumeroCartao = numeroCartao;
            CartaoCidadao = cartaoCidadao;
            Nif = nif;
            DataNascimento = dataNascimento;
            Morada = morada;
            CodigoPostal = codigoPostal;
            Localidade = localidade;

        }
    }
}
