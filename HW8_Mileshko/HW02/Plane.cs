using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_02_Mileshko
{
    public class Plane : Transport
    {

        public override void Move()
        {
            Console.WriteLine("Самолет летит.");
            Engine?.Start();
        }
    }
}
