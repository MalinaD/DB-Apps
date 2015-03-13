
namespace ShowDataFromRelatedTables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.Entity;
    using System.Threading.Tasks;

    public class GetInfoFromAdsDB
    {
        static void Main(string[] args)
        {
            AdsEntities db = new AdsEntities();

            //Print title, status, category, town and user.
            var ads = new List<string>();

            //Without Include

            //foreach (var ad in db.Ads)
            //{
            //    ads.Add(String.Format("Title " +ad.Title + ", Status " + ad.AdStatus.Status +
            //        ", Category " + (ad.Category == null ? ", (no category)" : ad.Category.Name) +
            //        ", Town " + (ad.Town == null ? ", (no town)" : ad.Town.Name) +
            //        ", User " +ad.AspNetUser.UserName));
            //}

            //Console.WriteLine("All Ads without Include option");
            //Console.WriteLine();
            //Console.WriteLine(String.Join("\n", ads.Take(ads.Count)));
            //Console.WriteLine();

            //With Include

            foreach (var ad in 
                db.Ads.Include(a => a.AdStatus)
                .Include(a => a.Town)
                .Include(a => a.Category)
                .Include(a => a.AspNetUser))
            {
                ads.Add(String.Format("Title: " + ad.Title + ", Status " + ad.AdStatus.Status +
                    ", Category: " + (ad.Category == null ? "(no category)" : ad.Category.Name) +
                    ", Town: " + (ad.Town == null ? "(no town)" : ad.Town.Name) +
                    ", User: " + ad.AspNetUser.UserName));
            }

            Console.WriteLine("All Ads without Include option");
            Console.WriteLine();
            Console.WriteLine(String.Join("\n", ads.Take(ads.Count)));
            Console.WriteLine();

        }
    }
}
