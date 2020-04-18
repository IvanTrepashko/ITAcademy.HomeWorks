using System;
using System.Reflection;


namespace hw_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = Logger.CreateLogger();

            logger.Info($"Application started {System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType}");

            Shape[] shapes = { new Circle(logger), new Triangle(logger), new Square(logger) };
            foreach (var shape in shapes)
            {
                shape.CalculateArea();
                shape.ShowInformation();
            }

            logger.Info("Application ended");
        }
    }
}
