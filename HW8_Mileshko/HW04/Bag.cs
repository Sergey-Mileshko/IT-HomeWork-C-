using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW8_04_Mileshko
{
    internal class Bag
    {
        private string[] item = new string[8];
        private bool isOpen;

        public void SetIsOpen(bool value)
        {
            isOpen = value;
        }

       

        public bool AddValueToArray (string value)
        {
            if (isOpen == false)
            {
                //return false;
                throw new InvalidOperationException("The bag is closed!");
            }

            bool b = true;
            for (int i = 0; i < item.Length; i++)
            {
                if (item[i] == null)
                {
                    b = true;
                }
            }

            if (b == false)
            {
                throw new InvalidOperationException("The bag is full!");
            }

            for (int i = 0; i < item.Length; i++)
            {
                if (string.IsNullOrEmpty(item[i]))
                {
                    item[i] = value;
                    return true;
                }
            }
            return false;
        }
        
        public string TakeOutValueToArray (int index)
        {
            if (isOpen == false)
            {
                //return null;
                throw new InvalidOperationException("The bag is closed!");
            }

            string a = item[index];
            item[index] = "";
            return a;

            

        }
    }
}
