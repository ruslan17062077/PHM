using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHM.Product
{
    public class ClassDataProduct
    {
        public static List<Product> ListStatic { get; set; }
        public static void GetData()
        {
            ListStatic = new List<Product>();
           StreamReader reader = new StreamReader(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\product.txt");
            var SelectData = reader.ReadToEnd();
            foreach (var Index in SelectData.Split(';'))
            {
                if (Index != "")
                {
                    ListStatic.Add(new Product()
                    {
                        Name = Index
                    });

                }
            }

        }
        public static void SetData(String Name)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\product.txt", true))
            {

                writer.WriteAsync($"{Name};");

            }

        }
    }
}

