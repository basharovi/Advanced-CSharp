using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection.Categories
{
    public class CategoryFactory
    {
        public ICategory CreteCategory(string categoryName)
        {
            var userSelection = GetCategoryType(categoryName);
            var constructorInfo = userSelection?.GetConstructor(Array.Empty<Type>());
            var category = (ICategory)constructorInfo?.Invoke(Array.Empty<object>());

            return category;
        }

        public object GetMethods(string categoryName)
        {
            var userSelection = GetCategoryType(categoryName);

            var methods = userSelection?.GetMethods();

            return methods;
        }

        public object GetProperty(string categoryName, string propertyName)
        {
            var userSelection = GetCategoryType(categoryName);
            var propertyInfo = userSelection?.GetProperty(propertyName);

            var category = CreteCategory(categoryName);

            return propertyInfo?.GetValue(category, null);
        }

        public object GetField(string categoryName, string fieldName)
        {
            var userSelection = GetCategoryType(categoryName);
            var fieldInfo = userSelection?.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);

            var category = CreteCategory(categoryName);

            return fieldInfo?.GetValue(category);
        }

        private Type GetCategoryType(string categoryName)
        {
            var assembly = Assembly.GetExecutingAssembly().GetName();
            var concatName = assembly.Name + ".Categories." + categoryName;
            var userSelection = Type.GetType(concatName);

            return userSelection;
        }
    }
}
