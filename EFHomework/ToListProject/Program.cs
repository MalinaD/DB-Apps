

namespace ToListProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            //invoke ToList(), then filter the categories by status "Published", then select ad title, 
            //category and town, then invoke ToList() and finally order the ads by publish date. 

            var db = new AdsEntities();

            //Initial version

            var adsFilter =
            db.Ads.ToList()
            .Where(a => a.AdStatus.Status == "Published")
            .OrderBy(a => a.Date)
            .Select(sa =>
            new
            {
                Title = sa.Title,
                Category = sa.Category,
                Town = sa.Town
            }
            ).ToList();

            Console.WriteLine("First version on ToList()");
            Console.WriteLine();

            foreach (var ad in adsFilter)
            {
                Console.WriteLine("Title " + ad.Title + 
                    ", Category " + (ad.Category == null ? ", (no category)" : ad.Category.Name) +
                    ", Town " + (ad.Town == null ? ", (no town)" : ad.Town.Name));
            }

            //Optimized version

            //var adsOptimizedFilter =
            //    db.Ads
            //    .Where(a => a.AdStatus.Status == "Published")
            //    .OrderBy(a => a.Date)
            //    .Select(sa =>
            //    new
            //    {
            //        Title = sa.Title,
            //        Category = sa.Category,
            //        Town = sa.Town
            //    }
            //    );

            //Console.WriteLine("Optimized version on toList()");
            //Console.WriteLine();

            //foreach (var ad in adsOptimizedFilter)
            //{
            //    Console.WriteLine("Title " + ad.Title +
            //        ", Category " + (ad.Category == null ? ", (no category)" : ad.Category.Name) +
            //        ", Town " + (ad.Town == null ? ", (no town)" : ad.Town.Name));
            //}

            //Console.WriteLine();
        }
    }
}
