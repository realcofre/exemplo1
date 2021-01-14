using System.Collections.Generic;

namespace exemplo1.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set;}
    }
}