using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stepper.BL.Model
{
    public class LaserGyro
    {
        List<byte> msg = new List<byte>();

        public int MasterAdress { get; }
        public int SlaveAdress { get; }

        public LaserGyro(int masterAdress, int slaveAdress)
        {
            MasterAdress = masterAdress;
            SlaveAdress = slaveAdress;
        }
    }
}
