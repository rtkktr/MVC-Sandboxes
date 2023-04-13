using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Serialize
{
    [Serializable]
    public class Person
    {
        private string fName;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        private string lName;

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
