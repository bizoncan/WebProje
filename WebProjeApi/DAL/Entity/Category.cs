using System.ComponentModel.DataAnnotations;

namespace WebProjeApi.DAL.Entity
{
    public class Category
    {
        [Key]
        public int categoryID { get; set; }
        public string categoryName { get; set; }
    }
}
