using System;
using System.Collections.Generic;
using System.Text;
using log4net;

namespace hw_11
{
    public abstract class Shape
    {
        public double Area { get; set; }
        private ILog _log;
        public virtual void CalculateArea()
        {
            _log.Info("Calculating area");
        }
        public virtual void ShowInformation()
        {
            _log.Info("Showing information");
        }
        public Shape(ILog log)
        {
            _log = log;
            log.Info($"Creating {this.GetType()}");
        }
    }
}
