using System;
using System.Collections.Generic;
using System.Text;
using log4net;

namespace hw_11
{
    class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(ILog log):base(log)
        {
            Random rnd = new Random();
            Radius = rnd.Next(10);
        }
        public override void CalculateArea()
        {
            base.CalculateArea();
            Area = Math.PI * Math.Pow(Radius, 2);
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"This is a Circle. Area is {Area:F2}. CLR Type is {this.GetType()}");
        }
    }
}
