using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintananceTime = "System is in maintenence";
        public static string ProductsListed = "Products are listed";
        public static string CategoriesListed = "Categories are listed";
        public static string ProductCountOfCategoryError = "There can be maximum 100 products in a category";
        public static string ProductNameAlreadyExists = "There is already a product with the given name";
        public static string CategoryLimitExceeded = "Category limit has been exceeded, new product can not be added";
        public static string AuthorizationDenied = "You don't have authority";
        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access token created";
        public static string ClaimsListed = "Claims listed";
        public static string Added = "Successfully added";
    }
}
