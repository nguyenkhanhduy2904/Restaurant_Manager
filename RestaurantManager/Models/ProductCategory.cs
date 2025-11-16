using RestaurantManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    public class ProductCategory
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


    public static class ProductCategoryList
    {
        public static List<ProductCategory> Categories { get; set; } = new List<ProductCategory>();


      

        public static ProductCategory CreateDefaultCategory()
        {
            return new ProductCategory(Constant.DEFAULT_CATEGORY_ID, Constant.DEFAULT_CATEGORY_NAME);
        }

        public static List<ProductCategory> InitCategory()//empty list
        {
            var defaultList = new List<ProductCategory> { CreateDefaultCategory() };
            FileUtils.SaveToJson(Constant.PRODUCT_CATEGORY_DATA_FILE, defaultList);
            return defaultList;
        }


        public static bool InitCategoryListData()
        {
            try
            {
                if (!File.Exists(Constant.PRODUCT_CATEGORY_DATA_FILE))
                {
                    Categories = InitCategory();
                    return true;
                }

                Categories = FileUtils.LoadFromJson<List<ProductCategory>>(Constant.PRODUCT_CATEGORY_DATA_FILE);

                if (Categories == null || Categories.Count == 0)
                {
                    Categories = InitCategory();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load category data: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Categories = InitCategory();
                return true;
            }
        }


        public static ProductCategory GetCategoryByID(string categoryID)
        {
            foreach (var category in Categories)
            {
                if (category.CategoryID == categoryID)
                {
                    return category;
                }
            }
            return null;
        }

        public static bool AddCategory(ProductCategory category)
        {
            try
            {
                var existedCategory = GetCategoryByID(category.CategoryID);
                if(existedCategory != null)
                {
                    MessageBox.Show("Category ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                Categories.Add(category);
                FileUtils.SaveToJson(Constant.PRODUCT_CATEGORY_DATA_FILE, Categories);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DeleteCategory(ProductCategory category)
        {
            try 
            {
                foreach (var product in ProductList.Products)//tim va set cac product ve default category
                {
                    if (product.Category.CategoryID == category.CategoryID && product.Category!=null)
                    {
                        product.Category = CreateDefaultCategory();
                    }
                }
                FileUtils.SaveToJson(Constant.PRODUCT_DATA_FILE, ProductList.Products);//luu vao file
                Categories.Remove(category);
                FileUtils.SaveToJson(Constant.PRODUCT_CATEGORY_DATA_FILE, Categories);
               
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateCategory(ProductCategory category)
        {
            try
            {
                var existedCategory = GetCategoryByID(category.CategoryID);
                if (existedCategory == null)
                {
                    MessageBox.Show("Category ID does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                existedCategory.CategoryName = category.CategoryName;
                existedCategory.CategoryID = category.CategoryID;
                FileUtils.SaveToJson(Constant.PRODUCT_CATEGORY_DATA_FILE, Categories);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error updating category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }




}
