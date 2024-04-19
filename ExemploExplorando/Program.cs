using System.ComponentModel;
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Jaime", "Moreira dos Santos Junior");
Pessoa p2 = new Pessoa("Antônio", "Ferreira dos Santos");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();












// Pessoa p1 = new Pessoa();
// p1.Nome = "Jaime";
// p1.Sobrenome = "Moreira";
// p1.Idade = 28;
// p1.Apresentar();