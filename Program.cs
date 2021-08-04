using System;

namespace ClasseObjetos
{
  class Program
  {
    static void Main()
    {
      ContaBancaria c1 = new ContaBancaria();
      ContaBancaria c2 = new ContaBancaria();

      c1.numConta = 4567;
      c1.titular = "Joyce";

      c2.numConta = 1234;
      c2.titular = "Maria";

      c1.Depositar(200);
      c1.Depositar(50);
      c2.Depositar(1000);

      c1.Sacar(150);
      c2.Sacar(100);

      c2.Transferir(200, c1);


      Console.WriteLine
      ("Titular: " + c1.titular +
      " |" +
      " Conta: " + c1.numConta +
      " |" +
      " Saldo de: " + c1.saldo +
      " reais");

      Console.WriteLine
      ("Titular: " + c2.titular +
      " |" +
      " Conta: " + c2.numConta +
      " |" +
      " Saldo de: " + c2.saldo +
      " reais");
    }
  }
}