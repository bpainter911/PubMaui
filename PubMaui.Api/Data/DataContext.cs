using Microsoft.EntityFrameworkCore;
using PubMaui.Api.Data.Entities;

namespace PubMaui.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<MenuOptions> MenuOptions {  get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }

        public DbSet<MenuCategory> MenuCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuOptions>()
                .HasKey(mo => new { mo.MenuId, mo.ItemOption, mo.ItemOptionPrice });

            AddSeedData(modelBuilder);
        }

        private static void AddSeedData(ModelBuilder modelBuilder)
        {
            MenuCategory[] menuCategories = [
            
                new MenuCategory { CategoryId = 1, Category = "Starters", CategoryDiscription = "" },
                new MenuCategory { CategoryId = 2, Category = "Salads", CategoryDiscription = "" },
                new MenuCategory { CategoryId = 3, Category = "Wings", CategoryDiscription = "" },
                new MenuCategory { CategoryId = 4, Category = "Pub Favourites", CategoryDiscription = "" },
                new MenuCategory { CategoryId = 5, Category = "Sandwiches and Burgers", CategoryDiscription = "" },
                new MenuCategory { CategoryId = 6, Category = "Famous Flatbreads", CategoryDiscription = "" },
                new MenuCategory { CategoryId = 7, Category = "Cookstown Pub Desserts", CategoryDiscription = "" },
            ];

            Menu[] menu = [
            
                new Menu {Id =1, CategoryId=1,Category="Starter", MName="Mozzarella Sticks",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/mozarella.png",Description="",RetailPrice=13.00},
                new Menu {Id =2, CategoryId=1,Category="Starter", MName="Basket of Fries",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/frenchfriesontable.png",Description="",RetailPrice=9.00},
                new Menu {Id =3, CategoryId=1,Category="Starter", MName="Dill Pickle Spears",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/picklespears.png",Description="",RetailPrice=10.00},
                new Menu {Id =4, CategoryId=1,Category="Starter", MName="Loaded Lattice Fries",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/latticefries.png",Description="",RetailPrice=15.00},
                new Menu {Id =5, CategoryId=1,Category="Starter", MName="Buttermilk Onion Rings",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/onionrings.png",Description="",RetailPrice=10.00},
                new Menu {Id =6, CategoryId=1,Category="Starter", MName="Montreal Style Poutine",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/montrealpoutine.png",Description="", RetailPrice = 12.00},
                new Menu {Id =7, CategoryId=1,Category="Starter", MName="Sweet Potato Fries",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/sweetpotato.png",Description="", RetailPrice = 10.00},
                new Menu {Id =8, CategoryId=1,Category="Starter", MName="Soup of the Day",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/souponsky.png",Description="",RetailPrice=8.00},
                new Menu {Id =9, CategoryId=1,Category="Starter", MName="French Onion Soup",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/onionsoupontableecu.png",Description="", RetailPrice = 9.00},
                new Menu {Id =10, CategoryId=2,Category="Salads", MName="Mandarin Salad",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/saladmandarin.png",Description="",RetailPrice=15.00},
                new Menu {Id =11, CategoryId=2,Category="Salads", MName="Cobb Salad",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/cobbsaladontable.png",Description="",RetailPrice=17.00},
                new Menu {Id =12, CategoryId=2,Category="Salads", MName="Greek Salad",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/greeklarge.png",Description="",RetailPrice=9.00},
                new Menu {Id =13, CategoryId=2,Category="Salads", MName="Classic Caesar Salad",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/caesarsalad.png",Description="",RetailPrice=9.00},
                new Menu {Id =14, CategoryId=2,Category="Salads", MName="Cookstown House Salad",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/saladhouse.png",Description="", RetailPrice = 13.00},
                new Menu {Id =15, CategoryId=3,Category="Wings", MName="Wings - Single Order One Pound",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/wingsmedium.png",Description="",RetailPrice=19.00},
                new Menu {Id =16, CategoryId=3,Category="Wings", MName="Wings - Double Order Two Pounds",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/wingsmedium.png",Description="",RetailPrice=37.00},
                new Menu {Id =17, CategoryId=3,Category="Wings", MName="Wings - Party Order Three Pounds",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/wingsmedium.png",Description="",RetailPrice=50.00},
                new Menu {Id =18, CategoryId=4,Category="Pub Favourites", MName="Chicken Fingers and Fries",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/chickenfingersbooth.png",Description="",RetailPrice=16.00},
                new Menu {Id =19, CategoryId=4,Category="Pub Favourites", MName="Ava's Perogies",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/perogi.png",Description="",RetailPrice=16.00},
                new Menu {Id =20, CategoryId=4,Category="Pub Favourites", MName="Beer Battered Fish & Chips",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/fishontablecu.png",Description="",RetailPrice=21.00},
                new Menu {Id =21, CategoryId=4,Category="Pub Favourites", MName="Chicken Fingers and Fries Buffalo Style",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/chickenfingersbooth.png",Description="",RetailPrice=17.00},
                new Menu {Id =22, CategoryId=4,Category="Pub Favourites", MName="Quesadilla",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/quesadilla.png",Description="",RetailPrice=10.00},
                new Menu {Id =23, CategoryId=4,Category="Pub Favourites", MName="Nachos",Image="",Description="",RetailPrice=20.00},
                new Menu {Id =24, CategoryId=4,Category="Pub Favourites", MName="Chicken Tetrazzini",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/chickentet.png",Description="",RetailPrice=19.00},
                new Menu {Id =25, CategoryId=4,Category="Pub Favourites", MName="Bangers and Mash",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/bangersmash.png",Description="",RetailPrice=15.00},
                new Menu {Id =26, CategoryId=4,Category="Pub Favourites", MName="Shepherds Pie",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/shepherdspie.png",Description="",RetailPrice=16.00},
                new Menu {Id =27, CategoryId=4,Category="Pub Favourites", MName="Liver and Onions",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/liveronion.png",Description="",RetailPrice=18.00},
                new Menu {Id =28, CategoryId=4,Category="Pub Favourites", MName="Texas Chili",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/chili.png",Description="",RetailPrice=15.00},
                new Menu {Id =29, CategoryId=4,Category="Pub Favourites", MName="Mushroom Garlic Meatloaf",Image="",Description="",RetailPrice=18.00},
                new Menu {Id =30, CategoryId=5,Category="Sandwiches and Burgers", MName="Chicken Wrap",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/buffalochickenwrap.png",Description="",RetailPrice=18.00},
                new Menu {Id =31, CategoryId=5,Category="Sandwiches and Burgers", MName="Yukon Gold Burger",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/burgerg.png",Description="",RetailPrice=18.00},
                new Menu {Id =32, CategoryId=5,Category="Sandwiches and Burgers", MName="Cookstown Classic Burger",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/burgerclassic.png",Description="",RetailPrice=17.00},
                new Menu {Id =33, CategoryId=5,Category="Sandwiches and Burgers", MName="Classic Clubhouse",Image="",Description="",RetailPrice=18.00},
                new Menu {Id =34, CategoryId=5,Category="Sandwiches and Burgers", MName="The Cookstown 'BIG' Burger",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/burgerg.png",Description="",RetailPrice=22.00},
                new Menu {Id =35, CategoryId=5,Category="Sandwiches and Burgers", MName="Loaded Beef Dip",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/beefdip.png",Description="",RetailPrice=20.00},
                new Menu {Id =36, CategoryId=5,Category="Sandwiches and Burgers", MName="Mushroom Swiss Burger",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/burgerms.png",Description="",RetailPrice=19.50},
                new Menu {Id =37, CategoryId=5,Category="Sandwiches and Burgers", MName="The Big Blue Burger",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/burgerblue.png",Description="",RetailPrice=19.50},
                new Menu {Id =38, CategoryId=5,Category="Sandwiches and Burgers", MName="Pulled Pork on a Bun",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/pulledpork.png",Description="",RetailPrice=17.00},
                new Menu {Id =39, CategoryId=6,Category="Famous Flatbreads", MName="Loaded Flatbread",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/mediterrflat.png",Description="",RetailPrice=15.00},
                new Menu {Id =40, CategoryId=6,Category="Famous Flatbreads", MName="Chicken & Goat Cheese Flatbread",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/flatbreadchick.png",Description="",RetailPrice=18.00},
                new Menu {Id =41, CategoryId=6,Category="Famous Flatbreads", MName="Bruschetta",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/bruschetta.png",Description="",RetailPrice=12.00},
                new Menu {Id =42, CategoryId=6,Category="Famous Flatbreads", MName="Cheesy Garlic Flatbread",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/cheesygarlicontable.png",Description="",RetailPrice=10.00},
                new Menu {Id =43, CategoryId=6,Category="Famous Flatbreads", MName="Cheesy Garlic Flatbread With Bacon",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/cheesygarlicwbacon.png",Description="",RetailPrice=12.00},
                new Menu {Id =44, CategoryId=7,Category="Cookstown Pub Desserts", MName="Sticky Toffee Pudding Cake",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/toffee.png",Description="",RetailPrice=7.00},
                new Menu {Id =45, CategoryId=7,Category="Cookstown Pub Desserts", MName="Deep Fried Oreos",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/oreos.png",Description="",RetailPrice=8.00},
                new Menu {Id =46, CategoryId=7,Category="Cookstown Pub Desserts", MName="Brownie Bliss",Image="https://github.com/bpainter911/publib/blob/main/ForMaui/brownie.png",Description="",RetailPrice=8.00},
            ];

            MenuOptions[] menuOptions = [

                new MenuOptions { MenuId = 2,  ItemOption = "Add Gravy", ItemOptionPrice=2.00 },
                new MenuOptions { MenuId = 12, ItemOption = "Make it a Large", ItemOptionPrice = 6.00 },
                new MenuOptions { MenuId = 13, ItemOption = "Make it a Large", ItemOptionPrice = 6.00 },
                new MenuOptions { MenuId = 15, ItemOption = "Samll Baskit of Fries", ItemOptionPrice = 6.00 },
                new MenuOptions { MenuId = 15, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 16, ItemOption = "Samll Baskit of Fries", ItemOptionPrice = 6.00 },
                new MenuOptions { MenuId = 16, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 17, ItemOption = "Samll Baskit of Fries", ItemOptionPrice = 6.00 },
                new MenuOptions { MenuId = 17, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 18, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 20, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 21, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 30, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 31, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 32, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 33, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 34, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 35, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 36, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 37, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },
                new MenuOptions { MenuId = 38, ItemOption = "Add Gravy", ItemOptionPrice = 2.00 },




            ];

            modelBuilder.Entity<Menu>()
                .HasData(menu);

            modelBuilder.Entity<MenuCategory>()
                .HasData(menuCategories);
            
            modelBuilder.Entity<MenuOptions>()
                .HasData(menuOptions);

        }
    }
}
