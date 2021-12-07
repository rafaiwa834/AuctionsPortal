using BlazorApp.Data;
using BlazorApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp
{
    public class AuctionsDbContext: DbContext
    {
        private string _connectionString = @"Server=RafalPC\WINCCPLUSMIG2014;Database=AuctionsPortal;Trusted_Connection=True;";

        public DbSet<Auctions> Auctions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<CurrentLog> CurrentLogs { get; set; }
        public DbSet<ImageName> ImagesNames { get; set; }
        public DbSet<FollowAuction> FollowsAuctions { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Notification> Notifications { get; set; }


        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Auctions>()
                 .Property(a => a.Title)
                 .IsRequired();

        }

         protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
