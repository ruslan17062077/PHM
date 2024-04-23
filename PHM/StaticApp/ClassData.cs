using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PHM.StaticApp
{
    public class ClassData
    {
        public static List<ClassStatic> ListStatic { get; set; }
        public static void GetData()
        {
            ListStatic = new List<ClassStatic>();
            if (!File.Exists(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\user.txt"))
            {
                using (File.Create(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\user.txt")) { }
                    return;
            }
            using (StreamReader reader = new StreamReader(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\user.txt"))
            {
                var SelectData = reader.ReadToEnd();
                foreach (var Index in SelectData.Split(';'))
                {
                    if (Index != "")
                    {
                        try
                        {

                            ListStatic.Add(new ClassStatic()
                            {
                                Name = Index.Split(':')[0],
                                Login = Index.Split(':')[1],
                                Password = Index.Split(':')[2],
                            });
                        }
                        catch
                        {
                            break;
                        }

                    }
                }
            }
        }

        public static void SetData(String name, String login, String password)
        {
            if (!File.Exists(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\user.txt"))
            {
                using (File.Create(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\user.txt")) { }
            }
            using (StreamWriter writer = new StreamWriter(@"C:\Users\222108\Desktop\GaGav-Presentation\PHM\data\user.txt", true))
            {
                writer.WriteAsync($"{name}:{login}:{password};");
            }
        }
    }
}
