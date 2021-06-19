using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
   В классе Program создайте два метода: 
- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass значение «изменено». 
- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено». 
Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса.Измените, значения
    полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker.Выведите на экран значения полей экземпляров.
    Проанализируйте полученные результаты.*/

    class Program
    {
        static void ClassTaker(MyClass myClass) { Console.WriteLine(myClass.change="Changed"); }

        static void StructTaker(MyStruct myStruct) { Console.WriteLine(myStruct.change="Changed"); }
        
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "Not changed";
            myStruct.change = "Not changed";

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            Console.ReadLine();
        }
    }
    public class MyClass { public string change; }

    public struct MyStruct { public string change; }
}
