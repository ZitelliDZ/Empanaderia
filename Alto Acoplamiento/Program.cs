using System;

namespace Alto_Acoplamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef juancito = new Chef();

            Empanada emp = juancito.HacerEmpanada ("Humita");
            
            Console.WriteLine(emp.masa);
            Console.WriteLine(emp.Repulgue);
            Console.WriteLine(emp.Relleno);
        }
    }
}
