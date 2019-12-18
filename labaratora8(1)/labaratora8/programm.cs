using System;
using System.Collections.Generic;

namespace labaratora8
{
    internal class Program
   {
        private static void AddNewCar(out string name, out string color, out int speed, out int Year)
        {
            Console.Write("Введите название машины : ");
            name = Console.ReadLine();
            Console.Write("Введите цвет машины :");
            color = Console.ReadLine();
            Console.Write("Введите скорость машины : ");
            RightInput(out speed);
            Console.Write("Введите год создания машины машины : ");
            RightInput(out Year);
        }

        private static void InputError()
        {
            Console.WriteLine("Такого пункта нету.Введите еще раз.");

        }

        private static void RightInput(out int number)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильный ввод.Повторите еще раз");
                }
            }
        }

        private static void ShowAllCars()
        {
            int i = 1;
            foreach (Car car in Garage.Carss)
            {
                Console.WriteLine($"{i}. Название: {car.Name} | Цвет: {car.Color} | Скорость: {car.Speed} | Год выпуска: {car.Year}");
                i++;
            }
        }

        private static void backMenu(string back)
        {
            while (true)
            {
                if (back == "Exit")
                {
                    Environment.Exit(0);
                }
                if (back == "1")
                {
                    Console.Clear();
                    Menu();
                }
            }
        }
        private static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.WriteLine("1 = купить машину");
            Console.WriteLine("2 = Уничтожить машину");
            Console.WriteLine("3 = Выбрать машину по критериям");
            Console.WriteLine("Exit = Выйти с программы");
            Console.WriteLine("Введите действие: ");
            switch (Console.ReadLine())
            {
                case "Exit":
                    Environment.Exit(0);
                    break;
                    
                case "1":
                    Console.Clear();
                    string name = "";
                    string color = "";
                    int speed = 0;
                    int Year = 0;
                    AddNewCar(out name, out color, out speed, out Year);
                    Garage.AddCar(name, color, speed, Year);
                    Console.WriteLine("Машина успешно куплена");
                    Console.WriteLine("1 = Вернуться в меню");
                    Console.WriteLine("Exit = Выйти с программы");
                    string back1 = Console.ReadLine();
                    backMenu(back1);
                    break;

                case "2":
                    Console.Clear();
                    ShowAllCars();
                    Console.Write("Выберите машину, которую хотите убрать c гаража : ");
                    int index = 0;
                    RightInput(out index);
                    Garage.RemoveCar(index - 1);
                    Console.WriteLine("Машина уничтожена.");
                    Console.WriteLine("1 = Вернуться в меню");
                    Console.WriteLine("Exit = Выйти с программы");
                    string back2 = Console.ReadLine();
                    backMenu(back2);
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Выбрать машины по характеристикам :");
                    List<Car> chooseCar = ChooseCar();
                    if (chooseCar.Count != 0)
                    {
                        Console.WriteLine("По вашем характеристикам найдены такие машины : ");
                        int i = 1;
                        foreach (Car car in chooseCar)
                        {
                            Console.WriteLine($"{i}. Название: {car.Name} | Цвет: {car.Color} | Скорость: {car.Speed} | Год выпуска: {car.Year}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("По вашем характеристикам не найдено машин!");
                    }
                    Console.WriteLine("1 = Вернуться в меню");
                    Console.WriteLine("Exit = Выйти с программы");
                    string back3 = Console.ReadLine();
                    backMenu(back3);
                    break;

                default:
                    InputError();
                    Menu();
                    Console.Clear();
                    break;
            }
        }



        private static List<Car> ChooseCar()
        {
            Console.WriteLine("1 = Название");
            Console.WriteLine("2 = Название-Цвет");
            Console.WriteLine("3 = Название-Цвет-Скорость");
            string numbersStr = "123";
            string tek = "";
            while (true)
            {
                tek = Console.ReadLine();
                if (numbersStr.Contains(tek))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильный ввод.Повторите еще раз");
                }
            }
            switch (tek)
            {
                case "1":
                    Console.Write("Введите название машины : ");
                    string name1 = Console.ReadLine();
                    return Garage.ChoseCars(name1);

                case "2":
                    Console.Write("Введите название машины : ");
                    string name2 = Console.ReadLine();
                    Console.Write("Введите цвет машины : ");
                    string color1 = Console.ReadLine();
                    return Garage.ChoseCars(name2, color1);

                case "3":
                    Console.Write("Введите название машины : ");
                    string name3 = Console.ReadLine();
                    Console.Write("Введите цвет машины : ");
                    string color2 = Console.ReadLine();
                    Console.Write("Введите цвет машины : ");
                    int speed = 0;
                    RightInput(out speed);
                    return Garage.ChoseCars(name3, color2, speed);
            }
            return new List<Car>();
        }
    }
}