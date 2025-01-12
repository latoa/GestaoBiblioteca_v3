using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca
{
    public abstract class Pessoa
    {
        public bool Ativo { get; set; } = false;
        public int ID { get; set; } = -1;
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Nome { get; set; } = "";
        public string Email { get; set; } = "";
        public string Telefone { get; set; } = "";

        public Pessoa() {}

        public Pessoa(
            bool ativo,
            int id,
            string username,
            string password,
            string nome,
            string email,
            string telefone)
        {
            Ativo = ativo;
            ID = id;
            Username = username;
            Password = password;
            Nome = nome;
            Email = email;
            Telefone = telefone;

        }
    }
}
