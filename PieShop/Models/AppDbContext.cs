using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PieShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        //public DbSet<IdentityUser> Users { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<PieCategory> PiesCategories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PieCategory>().HasData(
                new PieCategory
                {
                    
                    pieCategoryId = 1,
                    pieCategoryName = "Fruit pies",
                    pieCategoryDescription = "Very delicious and good taste with freshest fruits."
                },
                new PieCategory
                {
                    pieCategoryId = 2, 
                    pieCategoryName = "Cheese pies", 
                    pieCategoryDescription = "Cheesy all the way."
                },
                new PieCategory
                {
                    pieCategoryId = 3, 
                    pieCategoryName = "Seasonal pies",
                    pieCategoryDescription = "Get in the mood for seasonal pie."
                });
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    pieId = 1, pieName = "Strawberry pie", piePrice = 15.9M, pieShortDesc = "Tastes Good", pieLongDesc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", pieWeidth = 200, pieCategoryId = 1, pieImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", pieIsFavourite = true, pieImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"
                },
                new Pie
                {
                    pieId = 2, pieName = "Cheesecake pie", piePrice = 16.3M, pieShortDesc = "Tastes Good", pieLongDesc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", pieWeidth = 150, pieCategoryId = 2, pieImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", pieIsFavourite = false, pieImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"
                },
                new Pie
                {
                    pieId = 3, pieName = "Rhurbarb pie", piePrice = 14.6M, pieShortDesc = "Tastes Good", pieLongDesc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", pieWeidth = 170, pieCategoryId = 3, pieImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", pieIsFavourite = true, pieImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"
                },
                new Pie
                {
                    pieId = 4, pieName = "Pumpkin pie", piePrice = 11.0M, pieShortDesc = "Tastes Good", pieLongDesc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", pieWeidth = 120, pieCategoryId = 1, pieImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", pieIsFavourite = true, pieImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"
                }

            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
