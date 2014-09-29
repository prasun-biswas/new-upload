using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("abc", "ASP.Net MVC");
            aHashtable.Add("ABC", "Java Basics");
            aHashtable.Add("101", "Laravel");
            aHashtable.Add("302", "Zend");
            aHashtable.Add("987", "SEO");
            string courseName = (string)aHashtable["101"];
            Console.WriteLine(courseName);
            Console.ReadKey();

        }
    }
}
