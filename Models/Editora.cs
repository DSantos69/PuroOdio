using System.Collections.Generic;

namespace LivrariaAPI.Models
{
    public class Editora
    {

        public Editora() { }
        public Editora(int id, string nome, string cidade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cidade = cidade;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
    }
}