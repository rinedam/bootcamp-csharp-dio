using CsAprofundado.Program.Models;

























// Queue<int> fila = new Queue<int>();
// fila.Enqueue(1);
// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);

// System.Console.WriteLine("Fila original:");
// foreach (var item in fila)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o primeiro item: {fila.Dequeue()}");
// System.Console.WriteLine("Fila após remoção:");
// foreach (var item in fila)
// {
//     System.Console.WriteLine(item);
// }

// Stack<int> pilha = new Stack<int>();
// pilha.Push(1);
// pilha.Push(2);
// pilha.Push(3);
// pilha.Push(4);

// System.Console.WriteLine("Pilha original:");
// foreach (var item in pilha)
// {
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine($"Removendo o último item: {pilha.Pop()}");
// System.Console.WriteLine("Pilha após remoção:");
// foreach (var item in pilha)
// {
//     System.Console.WriteLine(item);
// }

// Dictionary<int, string> dicionario = new Dictionary<int, string>();
// dicionario.Add(1, "Um");
// dicionario.Add(2, "Dois");
// dicionario.Add(3, "Três");
// System.Console.WriteLine("Dicionário original:");
// foreach (var item in dicionario)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// dicionario.Remove(2);
// System.Console.WriteLine("Dicionário após remoção da chave 2:");
// foreach (var item in dicionario)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// dicionario[1] = "Um Modificado";
// System.Console.WriteLine("Dicionário após modificação da chave 1:");
// foreach (var item in dicionario)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }









// using CsAprofundado.Program.Models;

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/pasta/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         // Exibe a linha lida
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro: {ex.Message}");
// }
// catch (UnauthorizedAccessException ex)
// {
//     Console.WriteLine($"Ocorreu um erro: {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro: {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
// }
