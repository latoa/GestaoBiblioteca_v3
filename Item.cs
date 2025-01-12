using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestaoBiblioteca
{
    public class Item
    {
        public TipoItem Tipo { get; set; } = TipoItem.Nulo;
        public static int ID { get; set; } = -1;
        public string Titulo { get; set; } = "";
        public string Autor { get; set; } = "";
        public int Ano { get; set; } = 0;
        public int Quantidade { get; set; } = 0;

        public Item(){ }

        public Item(TipoItem tipo,  string titulo, string autor, int ano, int quantidade)
        {
            Tipo = tipo;
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Quantidade = quantidade;
        }


    }
}
