using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
          CPF cpf = new CPF();
          cpf.nome = "Henrique";
          System.Console.WriteLine(cpf.Saudacao());
          cpf.cpf = "472485567-03";
          System.Console.WriteLine(cpf.ValidarCPF());
        }
    }
}
