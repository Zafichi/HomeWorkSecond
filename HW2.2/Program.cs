using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{

    class Program
    {
        static void Main(string[] args)
        {
            Motorcicle Motocikle1 = new Motorcicle();
            Motorcicle Motocikle2 = new Motorcicle(12345, "Honda", false, 210, 340);
            Console.WriteLine();
            Motocikle1.Mark = "Suzuki";
            Motocikle1.MaxSpeed = 250;
            Motocikle1.Milage = 2354;
            Motocikle1.Trike = true;
            Motocikle1.EnginePower = 310;
            Motocikle1.Print(ref Motocikle1);
            Console.WriteLine();
            Motocikle1.Print();
            Console.WriteLine();
            Console.WriteLine(Motorcicle.SportBike);
            Console.WriteLine(Motorcicle.YearOfIssueNotLower);
        }
    }
}
