using log4net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace hw_12
{
    class MotorcycleRepository : IRepository<Motorcycle>
    {
        ILog _log = Logger.CreateLog();
        List<Motorcycle> motorcycles = new List<Motorcycle>();
        public static int Count { get; set; } = 0;
        public MotorcycleRepository(Motorcycle[] arr)
        {
            _log.Info("Motorcycle repository was created");
            motorcycles = arr.ToList<Motorcycle>();
            Count = arr.Length;
        }
        
        public void Create(Motorcycle obj)
        {
            _log.Info("Motorcycle was added to repository");
            motorcycles.Add(obj);
            Count++;
        }

        public void Delete(int id)
        {
            try
            {
                motorcycles.RemoveAt(id - 1);
                Count--;
                _log.Info("Motorcycle was deleted from repository");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("There is no such id");
                _log.Error(ex.Message);
            }
        }

        public IEnumerable<Motorcycle> GetAll()
        {
            _log.Info("Motorcycle collection was returned from repository");
            return motorcycles;
        }

        public Motorcycle GetByID(int id)
        {
            try
            {
                _log.Info("Motorcycle was returned by ID from repository");
                return motorcycles[id - 1];
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("There is no such ID");
                _log.Info(ex.Message);
                return null;
            }
        }

        public void Update(int id)
        {
            try 
            {
                motorcycles[id].UpdateInfo();
                _log.Info("Motorcycle was updated");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("There is no such ID");
                _log.Error(ex.Message);
            }
        }
    }
}
