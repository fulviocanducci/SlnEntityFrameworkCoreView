namespace EfViewMysQL.Models
{
   public class People
   {
      public int Id { get; set; }
      public string Name { get; set; } = string.Empty;
      public Sex Sex { get; set; }
   }

   public enum Sex: uint
   {
      Feminine = 0,
      Female = 1
   }
}
