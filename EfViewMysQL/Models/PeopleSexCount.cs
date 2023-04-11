namespace EfViewMysQL.Models
{
   public class PeopleSexCount
   {
      public int Id { get; set; }
      public string Sex { get; set; } = string.Empty;
      public long Count { get; set; } = 0;
   }
}
