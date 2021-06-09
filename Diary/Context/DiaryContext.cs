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
            modelBuilder.Entity<DiaryModel>().HasData(
                new DiaryModel { Id=1, Title ="Wpis 1", 
                Entry = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eu scelerisque turpis. Aliquam consectetur pharetra mollis. " +
                "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur tincidunt et nisi sit amet rutrum. " +
                "Nunc consequat, leo a mattis condimentum, orci mi consequat lacus, eu pulvinar tortor ante eu leo. Proin blandit mi eu nulla scelerisque" +
                " gravida. Donec id sem nec velit congue ullamcorper a quis augue. Nunc posuere facilisis efficitur. Sed id lectus luctus, lobortis lectus " +
                "vitae, eleifend lorem. Aliquam nulla est, vestibulum sit amet risus nec, iaculis molestie mauris. Vivamus congue augue ligula, quis blandit leo"+
                "commodo vitae. Aliquam ornare quam at faucibus pharetra. Etiam condimentum a arcu et pretium. Pellentesque non mauris quis ipsum finibus faucibus.", Day=2 },
                new DiaryModel { Id=2, Title ="Wpis 2", Entry = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eu scelerisque turpis. Aliquam consectetur pharetra mollis. " +
                "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur tincidunt et nisi sit amet rutrum. " +
                "Nunc consequat, leo a mattis condimentum, orci mi consequat lacus, eu pulvinar tortor ante eu leo. Proin blandit mi eu nulla scelerisque" +
                " gravida. Donec id sem nec velit congue ullamcorper a quis augue. Nunc posuere facilisis efficitur. Sed id lectus luctus, lobortis lectus " +
                "vitae, eleifend lorem. Aliquam nulla est, vestibulum sit amet risus nec, iaculis molestie mauris. Vivamus congue augue ligula, quis blandit leo"+
                "commodo vitae. Aliquam ornare quam at faucibus pharetra. Etiam condimentum a arcu et pretium. Pellentesque non mauris quis ipsum finibus faucibus.", Day=2 }
                );
        }

    }
}
