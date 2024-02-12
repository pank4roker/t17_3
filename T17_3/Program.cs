using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the increasing coefficient: ");
            double k = Convert.ToDouble(ReadLine());
            Write("Enter base rate in tons: ");
            double h = Convert.ToDouble(ReadLine());
            List<Staff> staff = new List<Staff>();
            bool flag = true;
            while (flag)
            {
                Write("Enter first letter of status E/M or S to stop and output info: ");
                string status = ReadLine();
                WriteLine();
                switch(status.ToLower())
                {
                    case "e":
                        Engineer engineer = new Engineer();
                        staff.Add(Engineer.Input());
                        engineer.Income(k, h);
                        break;
                    case "m":
                        Manager manager = new Manager();
                        staff.Add(Manager.Input());
                        manager.Income(k, h);
                        break;
                    case "s":
                        foreach(var elem  in staff) { Clear(); elem.ShowInfo(k, h); WriteLine(); }
                        break;
                    default:
                        WriteLine("You entered wrong letter!");
                        flag = false;
                        break;
                        
                }
            }
            ReadKey();


        }
    }
}
