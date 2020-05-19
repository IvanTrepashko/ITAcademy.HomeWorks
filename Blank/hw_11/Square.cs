using System;
using System.Collections.Generic;
using System.Text;
using log4net;
namespace hw_11
{
    class Square : Shape
    {
        public int Side { get; set; }

        public Square(ILog log):base(log)
        {
            Random rnd = new Random();
            Side = rnd.Next(10);
        }

        public override void CalculateArea()
        {
            base.CalculateArea();
            Area = Math.Pow(Side, 2);
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"This is a Square. Area is {Area}. CLR Type is {this.GetType()}");
        }
    }
}
