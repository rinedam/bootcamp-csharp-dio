using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsAprofundado.Program.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio.");
                }
                else
                {
                    _nome = value;
                }
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        private int _idade;
        public int Idade
        {
            get => _idade;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa ou igual a zero.");
                }
                _idade = value; 
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}