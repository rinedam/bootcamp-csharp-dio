using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrograma.Common.Models
{
    /// <summary>
    /// Classe que representa uma pessoa.
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Método que apresenta a pessoa.
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}