using System;
using System.Collections.Generic;
using System.Text;
using log4net;


namespace hw_11
{
    class Triangle : Shape
    {
        public int Side { get; set; }
        public int Height { get; set; }
        public Triangle(ILog log):base(log)
        {
            Random rnd = new Random();
            Side = rnd.Next(10);
            Height = rnd.Next(10);
        }
        public override void CalculateArea()
        {
            base.CalculateArea();
            Area = Side * Height * 0.5;
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"This is a Triangle. Area is {Area:F2}. CLR Type is {this.GetType()}");
        }
    }
}
