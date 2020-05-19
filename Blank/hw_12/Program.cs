using System;
using log4net;

namespace hw_12
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log = Logger.CreateLog();
            log.Info("Application started");

            Motorcycle[] motos =
            {
                new Motorcycle(1,"Suzuki","FD35",2005,1000),
                new Motorcycle(2,"BMW","FCC",2020,0),
                new Motorcycle(3,"Yamaha","3054",2019,10000)
            };

            MotorcycleRepository motorcycleRepository = new MotorcycleRepository(motos);

            while (true)
            {
                int choice;
                Console.Read();
                Console.Clear();
                Console.WriteLine("What do you want to do?\n1. Show all motorcycles\n2. Delete a motorcycle\n3. Update a motorcycle\n4. Get a motorcycle\n5. Add a motorcycle\n6. Exit");
                while(!int.TryParse(Console.ReadLine(),out choice))
                {
                    Console.WriteLine("Wrong input");
                }
                switch (choice)
                {
                    case 1:
                        {
                            foreach (var moto in motorcycleRepository.GetAll())
                            {
                                moto.ShowInfo();
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter an ID of motorcycle you want to delete");
                            int.TryParse(Console.ReadLine(), out int delete);
                            motorcycleRepository.Delete(delete);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter an ID of motorcycle you want to update");
                            int.TryParse(Console.ReadLine(), out int update);
                            motorcycleRepository.Update(update);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter an ID of motorcycle you want to get");
                            int.TryParse(Console.ReadLine(), out int get);
                            var moto = motorcycleRepository.GetByID(get);
                            break;
                        }
                    case 5:
                        {
                            motorcycleRepository.Create(Motorcycle.CreateNewMotorcycle());
                            break;
                        }
                    case 6:
                        log.Info("Application ended");
                        return;
                    default:
                        break;
                }
            }
            
        }
    }
}
