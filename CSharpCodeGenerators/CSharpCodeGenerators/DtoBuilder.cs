using System;
using System.IO;

namespace CSharpCodeGenerators
{
    public static class DtoBuilder<T>
    {
        public static string GetBuilder()
        {
            var result = string.Empty;
            
            using(var reader = new StreamReader("CandyBuilder.cs"))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }
    }
}
