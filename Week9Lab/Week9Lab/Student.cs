using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Lab
{
    public class Student
    {
        public int Id = -1;
        public string Name;
        public int Grade;


        public override string ToString()
        {
            return Name+" . "+Grade.ToString();  
        }

    }
}
