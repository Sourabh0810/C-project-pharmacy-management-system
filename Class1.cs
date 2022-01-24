using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    class Class1
    {
        static string nm;
        public static string name
        {
            get 
            {
                return nm;
            }
            set
            {
                nm = value;
            }
        }

        static string id;
        public static string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
