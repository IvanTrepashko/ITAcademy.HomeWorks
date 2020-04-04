using System;
using System.Collections.Generic;
using System.Text;

namespace hw_09.Task1.AssemblyOne
{
    public class MotorcyclePublic
    {
        private const ushort MaxSpeedPrivate = 300;
        public const ushort MaxSpeedPublic = 300;
        protected const ushort MaxSpeedProtected = 300;
        internal const ushort MaxSpeedInternal = 300;
        protected internal const ushort MaxSpeedProtectedInternal = 300;
        private protected const ushort MaxSpeedPrivateProtected = 300;

        protected string modelProtected = "Honda";
        internal int speedInternal = 0;
        private int _odometrPrivate = 1000;
        public int odometrPublic = 1000;
        protected internal int odometrProtectedInternal = 1000;
        private protected int odometrPrivateProtected = 1000;


        internal void StartEngineInternal()
        {
            Console.WriteLine("Starting Engine");
        }

        public void StartEnginePublic()
        {
            Console.WriteLine("Starting engine");
        }

        protected internal void AddSpeedProtectedInternal()
        {
            Console.WriteLine("Adding speed");
        }

        protected void AddSpeedProtected()
        {
            Console.WriteLine("Adding speed");
        }

        private protected void EndEnginePrivateProtected()
        {
            Console.WriteLine("Ending engine");
        }

        private void EndEnginePrivate()
        {
            Console.WriteLine("Ending engine");
        }
    }
}
