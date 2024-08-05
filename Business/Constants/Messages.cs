using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Service is maintenance.";

        public static string ProductAdded = "Product added.";
        public static string ProductNameIsInvalid = "Product name is invalid.";
        public static string ProductDeleted = "Product deleted.";
        public static string ProductUpdated = "Product updated.";
        public static string ProductsListed = "Products listed.";
        public static string ProductListed = "Product listed.";

        public static string CustomerAdded = "Customer added.";
        public static string CustomerDeleted = "Customer deleted.";
        public static string CustomerUpdated = "Customer updated.";
        public static string CustomersListed = "Customer listed.";
        public static string CustomerListed = "Customer listed.";

        public static string OrderAdded = "Order added.";
        public static string OrderDeleted = "Order deleted.";
        public static string OrderUpdated = "Order updated.";
        public static string OrdersListed = "Order listed.";
        public static string OrderListed = "Order listed.";

        public static string CategoryAdded = "Category added.";
        public static string CategoryDeleted = "Category deleted.";
        public static string CategoryUpdated = "Category updated.";
        public static string CategoriesListed = "Categories listed.";
        public static string CategoryListed = "Category listed.";

        public static string ProductCountOfCategoryError = "There can be a maximum of 10 products in a category.";
        public static string ProductNameAlreadyExists = "There cannot be products with the same name.";
        public static string CategoryLimitExceded = "New products cannot be added because the category limit has been exceeded.";
    }
}
