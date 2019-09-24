using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    partial class Motorcicle
    {
        private int milage;
        private string mark;
        private bool trike;
        private int enginePower;
        private int maxSpeed;
        public static string SportBike;
        public static int YearOfIssueNotLower;
        public Motorcicle()
        {
            milage = 0;
            mark = "default";
            trike = false;
            enginePower = 0;
            maxSpeed = 0;
        }
        public Motorcicle(int _milage, string _mark, bool _trike, int _enginePower, int _maxSpeed)
        {
            milage = _milage;
            mark = _mark;
            trike = _trike;
            enginePower = _enginePower;
            maxSpeed = _maxSpeed;
            Print();
        }
        public Motorcicle(string mark)
        {
            this.mark = mark;
            Print();
        }
        public void Print()
        {
            Console.WriteLine("Milage = " + milage);
            Console.WriteLine("Mark = " + mark);
            Console.WriteLine("Trike = " + trike);
            Console.WriteLine("EnginePower = " + enginePower);
            Console.WriteLine("MaxSpeed = " + maxSpeed);
        }
        public void Print(ref Motorcicle obj)
        {
            Console.WriteLine("Milage = " + obj.milage);
            Console.WriteLine("Mark = " + obj.mark);
            Console.WriteLine("Trike = " + obj.trike);
            Console.WriteLine("EnginePower = " + obj.enginePower);
            Console.WriteLine("MaxSpeed = " + obj.maxSpeed);
        }
        static Motorcicle()
        {
            SportBike = "SportBike";
            YearOfIssueNotLower = 2009;
        }

    }
}
