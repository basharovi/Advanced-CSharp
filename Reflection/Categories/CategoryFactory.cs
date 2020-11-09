using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection.Categories
{
    public class CategoryFactory
    {
        public ICategory CreteCategory(string categoryName)
        {
            var assembly = Assembly.GetExecutingAssembly().GetName();
            var concatName = assembly.Name + ".Categories." + categoryName;
            var userSelection = Type.GetType(concatName);

            var constructorInfo = userSelection?.GetConstructor(Array.Empty<Type>());
            var category = (ICategory)constructorInfo?.Invoke(Array.Empty<object>());

            return category;
        }

        public object GetMethods(string categoryName)
        {
            var assembly = Assembly.GetExecutingAssembly().GetName();
            var concatName = assembly.Name + ".Categories." + categoryName;
            var userSelection = Type.GetType(concatName);

            var methods = userSelection?.GetMethods();

            return methods;
        }

        public object GetProperty(string categoryName, string propertyName)
        {
            var assembly = Assembly.GetExecutingAssembly().GetName();
            var concatName = assembly.Name + ".Categories." + categoryName;
            var userSelection = Type.GetType(concatName);
            var propertyInfo = userSelection?.GetProperty(propertyName);

            var category = CreteCategory(categoryName);

            return propertyInfo?.GetValue(category, null);
        }
    }
}
