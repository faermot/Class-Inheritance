using ClassInheritance.Utils;
using ConsoleApp6.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {

                            Console.Clear();
                            Console.WriteLine("Задание №1");

                            Cat cat = new Cat("Мурзик", 4, "Бетонный");
                            cat.Info();

                            Dog dog = new Dog("Шарик", 145, "Красный");
                            dog.Info();

                            Console.ReadKey();
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №2");

                            Cat cat = new Cat("Мурзик", 4, "Бетонный");
                            cat.Info();
                            cat.MakeSound();


                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №3");

                            Car car = new Car("Audi A6", 2008, 5);
                            car.Info();

                            Motorcycle motorcycle = new Motorcycle("Kawasaki z800", 2014, "Красно-черный");
                            motorcycle.Info();


                            Console.ReadKey();
                        }

                        break;

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №4");
                            Console.WriteLine("Решение используется в задании №3");

                            Console.ReadKey();
                        }
                        break;

                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №5");
                            Console.WriteLine("Решение используется в задании №3");

                            Console.ReadKey();
                        }
                        break;

                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №6");
                            Console.WriteLine("Это мы не проходили это нам не задавали");

                            Console.ReadKey();
                        }
                        break;

                    case "7":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №7");
                            Console.WriteLine("пупупу... Демонстрация sealed класса (См. Код)");

                            Console.ReadKey();
                        }
                        break;

                    case "8":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №8");

                            Console.WriteLine("пупупу... (См. Код)");

                            ElectronicDevices electronicDevices = new ElectronicDevices();

                            Calculator calculator = new Calculator();

                            Computer computer = new Computer();

                            Console.ReadKey();
                        }
                        break;

                    case "9":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №9");

                            Manager manager = new Manager("Афанасий", 163000, "р.", "89322342323");
                            manager.Info();

                            Developer developer = new Developer("Андрей", 1866, "$", "88005553535", "Web-сайтов");
                            developer.Info();


                            Console.ReadKey();
                        }
                        break;

                    // пупупу...

                    case "10":
                        {
                            // мегамувы, радвоение аккаунтов
                            Console.Clear();
                            Console.WriteLine("Задание №10");

                            SavingsAccount account = new SavingsAccount();

                            account.Deposit(100);
                            account.Withdraw(50);

                            CheckingAccount checkingAccount = new CheckingAccount();

                            checkingAccount.Deposit(100);
                            checkingAccount.Withdraw(50);
                            

                            Console.ReadKey();
                        }
                        break;

                    case "11":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №11");

                            BaseClass baseObj = new BaseClass();
                            DerivedClass derivedObj = new DerivedClass();

                            baseObj.ShowMessage();
                            derivedObj.ShowMessage();
                            derivedObj.NewShowMessage();

                            Console.ReadKey();
                        }
                        break;

                    case "12":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №12");

                            Shape triangle = new Triangle(3, 4, 5);
                            Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
                            Console.WriteLine($"Периметр треугольника: {triangle.CalculatePerimeter()}");

                            Shape square = new Square(4);
                            Console.WriteLine($"Площадь квадрата: {square.CalculateArea()}");
                            Console.WriteLine($"Периметр квадрата: {square.CalculatePerimeter()}");

                            Shape circle = new Circle(5);
                            Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");
                            Console.WriteLine($"Периметр круга: {circle.CalculatePerimeter()}");

                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.WriteLine("Произошла ошибка! ");
                        Thread.Sleep(3000);
                        break;
                } 
            }
        }
    }
}
