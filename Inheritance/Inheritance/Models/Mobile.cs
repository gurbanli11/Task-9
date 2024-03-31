using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Mobile : Device
    {
        public int PortCount;

        public Mobile(decimal width,decimal height,decimal weight,int portCount)
        {
            PortCount = portCount;

            //AddNumber, RemoveNumber, GetNumbers 
        }

        public void AddNumber()
        {
            Array.Resize(ref SimCards, Sim.Cards.Length - 1);
        }
        
        public void RemoveNumber()
        {

        }

        public void GetNumbers()
        {

        }

    }
}
