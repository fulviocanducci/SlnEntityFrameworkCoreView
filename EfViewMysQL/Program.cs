using EfViewMysQL.Models;
using Microsoft.EntityFrameworkCore;

namespace EfViewMysQL
{
   internal class Program
   {
      static void Main(string[] args)
      {
         using DatabaseContext db = new();
         Insert(db);
         foreach (var item in db.PeopleSexCount)
         {
            Console.WriteLine($"{item.Id} {item.Sex} {item.Count}");
         }

      }

      static void Insert(DbContext db)
      {
         db.Add(new People
         {
            Name = "Name 6",
            Sex = Sex.Male
         });
         db.Add(new People
         {
            Name = "Name 7",
            Sex = Sex.Female
         });
         db.Add(new People
         {
            Name = "Name 8",
            Sex = Sex.Male
         });
         db.Add(new People
         {
            Name = "Name 9",
            Sex = Sex.Female
         });
         db.Add(new People
         {
            Name = "Name 10",
            Sex = Sex.Female
         });
         db.SaveChanges();
      }
   }
}