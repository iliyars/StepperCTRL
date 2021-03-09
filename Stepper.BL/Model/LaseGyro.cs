using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stepper.BL.Model
{
    public class LaserGyro
    {
        public Commands currentCommand { get; set; }

        List<byte> msg = new List<byte>();


        public byte MasterAdress { get; }
        public byte SlaveAdress { get; }

        public LaserGyro(byte masterAdress, byte slaveAdress)
        {
            MasterAdress = masterAdress;
            SlaveAdress = slaveAdress;
            currentCommand = Commands.NULL;
        }



        public enum Commands
        {
            PING,
            INIT,
            ID,
            WRITE,
            GET,
            PUT,
            NULL
        }

        
    }
}
