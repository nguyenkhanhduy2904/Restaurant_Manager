using RestaurantManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    
    public class Product
    {
        private string productID;
        private string productName;
        private decimal price;
        private bool isAvailable;

        private ProductCategory category;


        public Product(string productID, string productName, decimal price, ProductCategory? category, bool isAvailable)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.category = category;
            this.isAvailable = isAvailable;
        }

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal Price { get => price; set => price = value; }
        public ProductCategory Category { get => category; set => category = value ; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

        public override string ToString()
        {
            return $"ProductID: {productID}, ProductName: {productName}, Price: {price}, Category: [{category}]";
        }

    }


    public static class ProductList
    {
        public static List<Product> Products { get; set; } = new List<Product>();


        public static List<Product> InitDefaultList()
        {
            var defaultList = new List<Product>();
            FileUtils.SaveToJson(Constant.PRODUCT_DATA_FILE, defaultList);
            return defaultList;
        }


        public static bool InitProductListData()
        {
            try 
            {
                if (!File.Exists(Constant.PRODUCT_DATA_FILE))
                {
                    Products = InitDefaultList();
                    return true;

                }
                Products = FileUtils.LoadFromJson<List<Product>>(Constant.PRODUCT_DATA_FILE);

                if (Products == null || Products.Count== 0)
                {
                    Products = InitDefaultList() ;
                    return true;
                }
                return false;

            }
            catch(Exception e)
            {
                MessageBox.Show($"There an error loading Product list. \nA default list will be create.\n {e.Message}", "Error", MessageBoxButtons.OK);
                Products = InitDefaultList();
                return false;
            }
        }

        public static Product GetProductByID(string ID)
        {
            foreach (var product in ProductList.Products)
            {
                if(product.ProductID== ID)
                {
                    return product;
                }
            }
            return null;
        }

        public static bool AddProduct(Product product)
        {
            try 
            {
                var existedProduct = GetProductByID(product.ProductID);
                if (existedProduct != null)
                {
                    MessageBox.Show("Product ID already exist!", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (product.Category == null)
                {
                    product.Category = ProductCategoryList.CreateDefaultCategory();
                }
                Products.Add(product);

                FileUtils.SaveToJson(Constant.PRODUCT_DATA_FILE, Products);
                return true;
            
            }
            catch(Exception e)
            {
                MessageBox.Show($"There an error adding this product.\n{e.Message}","Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool DeleteProduct(Product product)
        {
            try
            {
                var existedProduct = GetProductByID(product.ProductID);
                if (existedProduct == null)
                {
                    MessageBox.Show("Product not exist!", "Error", MessageBoxButtons.OK);
                    return false;

                }
                Products.Remove(existedProduct);
                FileUtils.SaveToJson(Constant.PRODUCT_DATA_FILE, Products);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show($"There an error deleting this product.\n {e.Message}", "Error", MessageBoxButtons.OK);
                return false;
            }

        }

        public static bool UpdateProduct(Product product)
        {
            try 
            {
                var existedProduct = GetProductByID(product.ProductID);
                if (existedProduct == null)
                {
                    MessageBox.Show("Product not exist!", "Error", MessageBoxButtons.OK);
                    return false;

                }
                existedProduct.ProductID = product.ProductID;
                existedProduct.ProductName = product.ProductName;
                existedProduct.Price = product.Price;
                existedProduct.IsAvailable = product.IsAvailable;
                existedProduct.Category = product.Category;
                FileUtils.SaveToJson(Constant.PRODUCT_DATA_FILE, Products);
                return true;
                
            
            }
            catch(Exception e)
            {
                MessageBox.Show($"There an error updating this product!\n{e.Message} ", "Error", MessageBoxButtons.OK);
                return false;
            }

        }



    }


}
