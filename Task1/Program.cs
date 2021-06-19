using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson11
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Создайте программу, в которой создайте структуру с
     * именем – Notebook (Блокнот), структура должна содержать следующие поля: модель, производитель, цена.В структуре реализуйте
     * конструктор для инициализации полей и метод для вывода содержимого полей на экран.*/
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("A4","Print Family",50.5);
            notebook.getFields();

            Console.ReadLine();
        }
    }
    public struct Notebook
    {
        private string sampler;
        private string maker;
        private double price;
        public string Sampler 
        {
            get { return sampler; }
            set { sampler = value; }
        }
        public string Maker 
        {
            get { return maker; }
            set { maker = value; }
        }
        public double Price 
        {
            get { return price; }
            set { price = value; }
        }

        public Notebook(string sampler,string maker,double price)
        {
            this.sampler = sampler;
            this.maker = maker;
            this.price = price;
        }
        public void getFields()
        {
            Console.WriteLine("Maker: "+maker+"\nSampler:"+sampler+"\nPrice: "+price);
        }
    }
}
