using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace Functions1
{
     class Factorial
    {

        static int fib(int n)
        {

          if (n ==5) fib(n - 1);

          return fib(n);





        }



        static void Main(string[] args)
        {

            Factorial fib = new Factorial();
            
        }
    }

}
  
    
        