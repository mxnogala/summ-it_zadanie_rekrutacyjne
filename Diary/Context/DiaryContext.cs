using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diary.Models;

namespace Diary.Context
{
    public class DiaryContext : DbContext
    {
            public DbSet<DiaryModel> DiaryEntry { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite(@"Data Source=diary.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaryModel>().HasData(new DiaryModel { Id=1, Title ="Test 1", Entry = "Wpisik jakiś", Day=2 });
            modelBuilder.Entity<DiaryModel>().ToTable("DiaryTable");
        }

    }
}
