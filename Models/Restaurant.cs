using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4FoodApp.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            RestRanking = rank;
        }

        public int RestRanking { get; }
        public string RestName { get; set; }
        public string Address { get; set; }
        #nullable enable
        public string? FavDish { get; set; } = "It's all tasty!";
        public string? RestPhone { get; set; }
        public string? WebLink { get; set; } = "Coming Soon";
        #nullable disable

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestName = "Backdoor Burger",
                FavDish = "Frank and Charlie",
                Address = "261 N University Ave, Provo, UT 84601",
                RestPhone = "(385) 236-9567",
                WebLink = "backdoorbrgr.net"
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestName = "Chick-fil-A",
                FavDish = "Classic Sandwich",
                Address = "Ernest L. Wilkinson Student Center, Cougareat Food Court Suite 2240, Provo, UT 84602",
                RestPhone = "(801) 422-1607",
                WebLink = "chick-fil-a.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestName = "Jimmy Johns",
                FavDish = "The Gargantuan",
                Address = "2308 N University Pkwy, Provo, UT 84604",
                RestPhone = "(801) 375-7777"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestName = "Rancheritos",
                Address = "46 E 1230 N St, Provo, UT 84604",
                RestPhone = "(801) 374-0822",
                WebLink = "rancheritosprovoonline.com"
            };
            Restaurant r5 = new Restaurant(5)
            {
                RestName = "McDonalds",
                FavDish = "Hot n' Spicy McChicken",
                Address = "211 W 1230 N, Provo, UT 84604",
                RestPhone = "(801) 374-6909",
                WebLink = "mcdonalds.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
