using System;

namespace hw_09.Task1.AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcycleInternal moto = new MotorcycleInternal();
            moto.AddSpeedProtectedInternal();
            moto.StartEngineInternal();
            moto.StartEnginePublic();
            Console.WriteLine($"{moto.speedInternal}, {moto.odometrPublic}, {moto.odometrProtectedInternal}");
        }
    }
}
