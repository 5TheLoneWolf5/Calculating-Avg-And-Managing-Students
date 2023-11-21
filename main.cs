using System;
using Entidades;
using System.Linq;

class Program {

  private static int idx = 0;
  
  public static void Main (string[] args) {

    Aluno[] alunoArray = new Aluno[50];
    string userInput;
    
    do {
      Console.WriteLine("Digite os dados do aluno ou escreva (FIM) para sair: ");
      
      userInput = Console.ReadLine();

      if (userInput.Equals("FIM")) {
        break;
      }
      
      float notaOne = float.Parse(Console.ReadLine());
      float notaTwo = float.Parse(Console.ReadLine());
      float notaThree = float.Parse(Console.ReadLine());

      alunoArray[idx] = new Aluno(userInput, new float[] {notaOne, notaTwo, notaThree});

      idx++;
      
    } while (idx <= 50);

    if (alunoArray.All(i => i == null)) {
      Console.WriteLine("Não há dados.");
    } else {
      mostrarDados(alunoArray);
    }
    
    Console.ReadLine();
    
  }

  static internal void mostrarDados(Aluno[] array) {
    
    float soma = 0;
    Aluno lowestAvg = new Aluno("Aluno", new float[] {0.0f, 0.0f, 0.0f});
    Aluno highestAvg = new Aluno("Aluno", new float[] {0.0f, 0.0f, 0.0f});;

    Console.WriteLine();
    
    for (int i = 0; i < idx; i++) { // Idx is always incremented for the next.
      Aluno currentAluno = array[i];
      Console.WriteLine(currentAluno);

      if (currentAluno.Media < lowestAvg.Media || lowestAvg.Media == 0.0f) {
        lowestAvg = new Aluno(currentAluno.Nome, currentAluno.Notas);
      }
      if (currentAluno.Media > highestAvg.Media) {
        highestAvg = new Aluno(currentAluno.Nome, currentAluno.Notas);
      }
      
      soma += currentAluno.Media;
    }

    Console.WriteLine(String.Format("Média da Turma: {0}", soma / idx));
    Console.WriteLine($"Aluno com maior média: {highestAvg.Nome} - {highestAvg.Media}.");
    Console.WriteLine($"Aluno com menor média: {lowestAvg.Nome} - {lowestAvg.Media}.");
    
  }
  
}