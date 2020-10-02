using System;
using System.Reflection;

namespace Reflection.Categories
{
    public class CategoryFactory
    {
        public ICategory CreteCategory(string categoryName)
        {
            var assembly = Assembly.GetExecutingAssembly().GetName();
            var userSelection = Type.GetType(assembly.Name + ".Categories." + categoryName);

            var constructorInfo = userSelection?.GetConstructor(new Type[] { });
            var category = (ICategory)constructorInfo?.Invoke(new object[] { });

            return category;
        }

        public void GetMethods(string categoryName)
        {
            var assembly = Assembly.GetExecutingAssembly().GetName();
            var userSelection = Type.GetType(assembly.Name + ".Categories." + categoryName);

            var methods = userSelection?.GetMethods();
        }

        public object GetProperty(string categoryName, string propertyName)
        {
            var assembly = Assembly.GetExecutingAssembly().GetName();
            var userSelection = Type.GetType(assembly.Name + ".Categories." + categoryName);
            var propertyInfo = userSelection?.GetProperty(propertyName);

            var category = CreteCategory(categoryName);

            return propertyInfo?.GetValue(category, null);
        }
    }
}
