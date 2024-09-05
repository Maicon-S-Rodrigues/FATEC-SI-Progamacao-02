using System;

namespace ObjectOrientationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.ToString());

            string name;
            int age;
            char sex;

            Console.Write("Informe o nome da pessoa: ");
            name = Console.ReadLine();

            Console.Write("Informe a idade da pessoa: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Informe o sexo da pessoa (F/M): ");
            string aux = Console.ReadLine();
            sex = aux.ToUpper()[0];

            person = new Person(name, sex, age);

            Console.WriteLine(person.ToString());

            Console.ReadKey();
        }
    }
}