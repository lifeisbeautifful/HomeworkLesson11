using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.Присвойте каждой константе значение, 
    задающее количество часов, которые должен отработать сотрудник за месяц. Создайте класс Accauntant с методом bool AskForBonus
    (Post worker, int hours), отражающее давать или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, 
    то ему положена премия. */

    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();

            if(accauntant.AskForBonus(Position.TestAutomationEngeneer, 200))
            {
                Console.WriteLine("Add a bonus to the main salary");
            }
            else
            {
                Console.WriteLine("There is no reason for a bonus");
            }

            Console.ReadLine();
        }
    }
    public class Accauntant
    {
        public bool AskForBonus(Position worker,int hours)
        {
            switch (worker)
            {
                case Position.DevOps:
                    worker= Position.DevOps;
                    break;
                case Position.TestEngeneer:
                    worker = Position.TestEngeneer;
                    break;
                case Position.TestAutomationEngeneer:
                    worker = Position.TestAutomationEngeneer;
                    break;
                case Position.SoftwareEngeneer:
                    worker = Position.SoftwareEngeneer;
                    break;
                case Position.HR:
                    worker = Position.HR;
                    break;
            }

            bool result = (hours > (int)worker) ? true : false;
            return result;
        }
    }
    public enum Position
    {
         DevOps = 165,
         TestEngeneer = 160,
         TestAutomationEngeneer=155,
         SoftwareEngeneer=169,
         HR=162
    }
}
