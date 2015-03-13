
namespace SelectAllSelectSpecial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;

    class Program
    {
        static void Main(string[] args)
        {
            var db = new AdsEntities();


            //Select all

            Console.WriteLine("All Ads without Include option");
            Console.WriteLine();

            foreach (var ad in db.Ads)
            {
                Console.WriteLine("Title " + ad.Title);
            }

            Console.WriteLine();


            //Select only Certain Columns
            //var adsCertainColumns = db.Ads.Select(a => a.Title);

            //Console.WriteLine("Certain Columns from Ads");
            //Console.WriteLine();


            //foreach (var ad in adsCertainColumns)
            //{
            //    Console.WriteLine("Title: " + ad);

            //}

            //Console.WriteLine();
           
        }
    }
}
