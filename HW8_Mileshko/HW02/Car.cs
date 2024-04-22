using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_02_Mileshko
{
    public class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Автомобиль движется.");
            Engine?.Start();
        }
    }
}
