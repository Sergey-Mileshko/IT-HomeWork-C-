using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_01_Mileshko
{
    public class Item
    {
        private string Name = "unknown";
        public void SetName(string newName)
        {
            Name = newName;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
