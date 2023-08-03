using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _3_8_Assignment_22
{
   
    
        public class PropertyMapper
        {
            public static void MapProperties(Source source, Destination destination)
            {
                Type sourceType = typeof(Source);
                Type destinationType = typeof(Destination);

                PropertyInfo[] sourceProperties = sourceType.GetProperties();
                PropertyInfo[] destinationProperties = destinationType.GetProperties();

                foreach (PropertyInfo sourceProperty in sourceProperties)
                {
                    PropertyInfo destinationProperty = Array.Find(destinationProperties, prop => prop.Name == sourceProperty.Name);

                    if (destinationProperty != null && destinationProperty.PropertyType == sourceProperty.PropertyType)
                    {
                        object value = sourceProperty.GetValue(source);
                        destinationProperty.SetValue(destination, value);
                    }
                }
            }
        }
    
}
