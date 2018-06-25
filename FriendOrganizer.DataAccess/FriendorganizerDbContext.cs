﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FriendOrganizer.Model;

namespace FriendOrganizer.DataAccess {
    public class FriendOrganizerDbContext : DbContext {
        public DbSet<Friend> Friends { get; set; }

        public FriendOrganizerDbContext() : base("FriendOrganizerDb") {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
