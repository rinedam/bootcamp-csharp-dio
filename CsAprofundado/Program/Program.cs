using CsAprofundado.Program.Models;

Pessoa p1 = new Pessoa("Gustavo", "Rinedam");
Pessoa p2 = new Pessoa("Eduardo", "Queiroz");

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Curso de Inglês";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();

