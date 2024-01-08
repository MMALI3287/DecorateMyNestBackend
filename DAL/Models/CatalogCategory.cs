using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class CatalogCategory
    {
        [Key]
        public int CatalogCategoryId { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Catalog> Catalogs { get; set; }

        public CatalogCategory()
        {
            Catalogs = new List<Catalog>();
        }
    }
}
