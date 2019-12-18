using System.Collections.Generic;

namespace labaratora8
{
    internal static class Garage
    {
        private static List<Car> Сars = new List<Car>()
        {
           new Car(){ Name = "Хюндай",Color = "Серый",Speed = 320,Year=2009},
           new Car(){ Name = "Ауди",Color = "Белый",Speed = 230,Year=2003},
           new Car(){ Name = "Мазда",Color = "Синий",Speed = 240,Year=2004},
           new Car(){ Name = "Жигуль",Color = "Красный",Speed = 250,Year=2017},
           new Car(){ Name = "Ауди",Color = "Белый",Speed = 270,Year=2017},
           new Car(){ Name = "Хюндай",Color = "Серый",Speed = 280,Year=2089},
        };

        public static IEnumerable<Car> Carss
        {
            get
            {
                return Сars;
            }
        }

        public static void AddCar(string name, string color, int speed, int Year)
        {
            Сars.Add(new Car()
            {
                Name = name,
                Color = color,
                Speed = speed,
                Year = Year
            });
        }

        public static void RemoveCar(int point)
        {
            Сars.Remove(Сars[point]);
        }

        public static List<Car> ChoseCars(string name)
        {
            List<Car> ChosenCars = new List<Car>();
            foreach (Car car in Carss)
            {
                if (name.ToLower() == car.Name.ToLower())
                {
                    ChosenCars.Add(car);
                }
            }
            return ChosenCars;
        }

        public static List<Car> ChoseCars(string name, string color)
        {
            List<Car> ChosenCars = new List<Car>();
            foreach (Car car in Carss)
            {
                if (name.ToLower() == car.Name.ToLower() && color.ToLower() == car.Color.ToLower())
                {
                    ChosenCars.Add(car);
                }
            }
            return ChosenCars;
        }

        public static List<Car> ChoseCars(string name, string color, int speed)
        {
            List<Car> ChosenCars = new List<Car>();
            foreach (Car car in Carss)
            {
                if (name.ToLower() == car.Name.ToLower() && color.ToLower() == car.Color.ToLower() && speed == car.Speed)
                {
                    ChosenCars.Add(car);
                }
            }
            return ChosenCars;
        }
    }
}