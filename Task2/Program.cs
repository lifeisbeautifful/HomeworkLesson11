using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте программу, в которой создайте структуру именем Train (Поезд) ), структура должна содержать следующие поля: название пункта 
    назначения, номер поезда, время отправления.
   В программе необходимо реализовать следующую логику: Пользователь должен с клавиатуры вводить данные с клавиатуры в массив, который 
    содержит упорядоченные номера поездов, количество поездов сделать равным 5 шт.После чего пользователь должен иметь возможность 
    вывести информацию о поезде по номеру поезда.*/

    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeDepartment = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            Train[] trains = new Train[5];
            trains[0] = new Train("Lviv",timeDepartment.AddHours(6).AddMinutes(30));
            trains[1] = new Train("Kyiv",timeDepartment.AddHours(8).AddMinutes(15));
            trains[2] = new Train("Kharkiv",timeDepartment.AddHours(12));
            trains[3] = new Train("Odessa",timeDepartment.AddHours(15).AddMinutes(45));
            trains[4] = new Train("Lutsk",timeDepartment.AddHours(18).AddMinutes(20));

            for (int i = 0; i < trains.Length; i++)
                {
                    Console.Write("Enter train number: ");
                    trains[i].TrainNumber = int.Parse(Console.ReadLine());
                    for (int j = i; j > 0; j--)
                    {
                        if (trains[j].TrainNumber < trains[j - 1].TrainNumber)
                        {
                            var hold = trains[j].TrainNumber;
                            trains[j].TrainNumber = trains[j - 1].TrainNumber;
                            trains[j - 1].TrainNumber = hold;
                        }
                    }
                }
            
            Console.Write("Available trains for today: ");
            foreach (var item in trains)
            {
                Console.Write(item.TrainNumber+", ");
            }

            Console.Write("enter train number for complete information: ");
            int trainNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == trainNumber)
                {
                    trains[i].trainInfo(trainNumber);
                    break;
                }
            }
            
            Console.ReadLine();
        }
    }
    public struct Train
    {
        private string destination;
        private int trainNumber;
        private DateTime departureTime;
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public int TrainNumber
        {
            get { return trainNumber; }
            set { trainNumber = value; }
        }
        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }
        public Train(string destination,DateTime departureTime)
        {
            this.trainNumber = 0;
            this.destination = destination;
            this.departureTime = departureTime;
        }
        public void trainInfo(int trainNumber)
        {
            Console.WriteLine("Destination: "+Destination);
            Console.WriteLine("Departure time: "+DepartureTime);
        }
    }
}
