using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class HouseBuilder
    {
        House house;
        public HouseBuilder()
        {
            house = new House();
        }
        public HouseBuilder InstallAc()
        {
           house.HasAc = true;
            return this;
        }

        public HouseBuilder InstallJacuzzi()
        {
            house.HasJacuzzi = true;
            return this;
        }

        public HouseBuilder AddSmartDoor()
        { 
            house.HasSmartDoor = true;
            return this;
        }

        public House Build()
        {
            return house;
        }
    }
}
