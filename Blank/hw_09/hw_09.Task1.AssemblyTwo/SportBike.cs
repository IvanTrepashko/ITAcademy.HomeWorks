using System;
using System.Collections.Generic;
using System.Text;
using hw_09.Task1.AssemblyOne;
namespace hw_09.Task1.AssemblyTwo
{
    class SportBike: MotorcyclePublic
    {
        public void InheritedItems()
        {
            Console.WriteLine($"{modelProtected}, {odometrProtectedInternal}, {odometrPublic}, {MaxSpeedProtected}, {MaxSpeedProtectedInternal}, {MaxSpeedPublic}");
            StartEnginePublic();
            AddSpeedProtected();
            AddSpeedProtectedInternal();
        }
    }
}
