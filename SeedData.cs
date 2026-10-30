 using day3_tran_xuan_thanh.Models;
namespace day3_tran_xuan_thanh.Data
{
    public class SeedData
    {
        //gia lap giu lieu 
        public static List<Models.Category> categories = new List<Category>
        {
            new Category(){Id=1,Name="Category 1",Description="Description 1" },
            new Category(){Id=2,Name="Category 2",Description="Description 2" },
            new Category(){Id=3,Name="Category 3",Description="Description 3" },
           
        };
    }
}
