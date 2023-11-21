using System;

namespace Entidades {
  public class Aluno {
    private string nome;
    private float media;
    private const int SIZE = 3;
    private float[] notas = new float[SIZE]; // Order doesn't matter. But it's better to be organized.

    public string Nome {
      get { return nome; }
      private set { nome = value; }
    }

    public float[] Notas {
      get { return notas; }
      private set { notas = value; }
    }

    public float Media {
      get { return mediaNotas(); }
      // No need for setting a value.
    }

    public Aluno() {
      this.Nome = "Nome";
      this.Notas = new float[SIZE] {0.0f, 0.0f, 0.0f};
    }

    public Aluno(string nome) : this() {
      this.Nome = nome;
    }

    public Aluno(string nome, float[] notas) {
      this.Nome = nome;
      this.notas = notas;
    }

    private float mediaNotas() {
      float resultado = 0;

      foreach (float i in Notas) {
        resultado += i;
      }

      return resultado / Notas.Length;
    }

    public override string ToString() {
      return $"{Nome} - {Notas[0]} - {Notas[1]} - {Notas[2]}.\nMédia: {Media}.\n";
    } 
  }
}