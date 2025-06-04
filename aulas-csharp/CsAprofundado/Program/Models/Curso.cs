using System;

namespace CsAprofundado.Program.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            for (int i = 0; i < Alunos.Count; i++)
            {
                string texto = $"N {i + 1} - {Alunos[i].NomeCompleto}";
                System.Console.WriteLine(texto);
            }
        }
    }
}