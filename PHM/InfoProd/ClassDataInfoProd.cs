using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHM.InfoProd
{
    public class ClassDataInfoProd
    {
        public static List<InfoProd> ListStatic { get; set; }
        public static void GetData()
        {
            ListStatic = new List<InfoProd>();
            if (!File.Exists(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\infoproduct.txt"))
            {
                using (File.Create(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\infoproduct.txt")) { }
                    return;
            }
            using (StreamReader reader = new StreamReader(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\infoproduct.txt")) 
            {
                var SelectData = reader.ReadToEnd();
                foreach (var Index in SelectData.Split(';'))
                {
                    if (Index != "")
                    {
                        ListStatic.Add(new InfoProd()
                        {
                            Name = Index.Split(':')[0],
                            Description = Index.Split(':')[1]
                        });

                    }
                }
            }
        }
        public static void SetData(String Name, String Description)
        {
            if (!File.Exists(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\infoproduct.txt"))
            {
                using (File.Create(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\infoproduct.txt")) { }
            }
            using (StreamWriter writer = new StreamWriter(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\infoproduct.txt", true))
            {
                writer.WriteAsync($"{Name}:{Description};");
            }
        }
    }
}

