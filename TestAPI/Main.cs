using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI
{
    class Mainn
    {
        public static void Main()
        {
            var cl = new Client();
            var cr = new Credit();
            var doc = new Document();
            var inv = new Invoice();
            var pay = new Payment();
            var pro = new Product();
            var tax = new Tax_rate();
        }
    }
}
