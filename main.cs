using System;
using System.Linq;

class Program {

  public static int Calculator(int num1, int num2)
  {
    return Enumerable.Range(num1,num2).Sum();
  }
  public static void Main (string[] args) {

    Console.Write("\n\nFunção para somar os (n) primeiros valores a partir de (a)\n");
      Console.Write("--------------------------------------------------\n");
	  Console.Write("Digite um número (a): ");
      int n1= Convert.ToInt32(Console.ReadLine());
      Console.Write("Digite outro número (n): ");
      int n2= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("\nA soma (a,n) é: {0} \n", Calculator(n1,n2) );
  }
}