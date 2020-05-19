using System;

namespace hw_12
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometr { get; set; }

        public Motorcycle(int id, string name, string model, int year, int odometr)
        {
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            Odometr = odometr;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID is {Id}\nName is {Name}\nModel is {Model}\nYear is {Year}\nOdometr is {Odometr}");
            Console.WriteLine();
        }

        public void UpdateInfo()
        {
            Console.WriteLine("What do you want to update?\n1. Name\n2. Model\n3. Year\n4. Odometr\nYour choice: ");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter new name");
                    Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter new model");
                    Model = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter new year");
                    int.TryParse(Console.ReadLine(), out int new_year);
                    Year = new_year;
                    break;
                case 4:
                    Console.WriteLine("Enter new odometr value");
                    int.TryParse(Console.ReadLine(), out int new_odometr);
                    Odometr = new_odometr;
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
        public static Motorcycle CreateNewMotorcycle()
        {
            Console.WriteLine("Enter a name of motorcycle");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a model of motorcycle");
            string model = Console.ReadLine();
            Console.WriteLine("Enter a year of motorcylce");
            int.TryParse(Console.ReadLine(), out int year);
            Console.WriteLine("Enter an odometr value of motorcycle");
            int.TryParse(Console.ReadLine(), out int odometr);
            var moto = new Motorcycle(MotorcycleRepository.Count + 1, name, model, year, odometr);
            return moto;
        }
    }
}
