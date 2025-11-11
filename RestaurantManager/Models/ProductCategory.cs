using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    internal class ProductCategory
    {
        private string categoryID;
        private string categoryName;
        public ProductCategory(string categoryID, string categoryName)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
        }
        public string CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public override string ToString()
        {
            return $"CategoryID: {categoryID}, CategoryName: {categoryName}";
        }
    }
}
