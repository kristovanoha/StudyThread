using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyThread
{
    class Program
    {
        static void Main(string[] args)
        {
            //jedu
            object dosts = new object();

            Dost dost = new Dost();


            Console.WriteLine("konec");
            Console.ReadKey();
        }

        public class Dost
        {
            public int neco { get; set; }
        }

        private void cc()
        {
            string s = "sdf";
        }
    }
}
