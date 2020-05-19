using System;
using hw_09.Task1.AssemblyOne;


namespace hw_09.Task1.AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            SportBike bike = new SportBike();
            bike.InheritedItems();

            // Internal classes are not available
            // MotorcycleInternal moto = new MotorcycleInternal(); 
        }
    }
}
