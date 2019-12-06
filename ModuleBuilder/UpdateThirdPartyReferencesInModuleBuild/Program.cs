using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace UpdateThirdPartyReferencesInModuleBuild
{
    class Program
    {
        // pass in the string location to the folder location. 
        //example C:\DecisionsModuleBuilderTemp\DecisionsGetScheduleModule
        // this is where the modules File is 

        static void Main(string[] args)
        {
            


            string folderpath = Environment.CurrentDirectory;

            string filepath = folderpath + @"\Module.Build.xml";
            bool exists = System.IO.File.Exists(filepath);
            
            if (exists == true)
            {
                Classes.CreateModuleInfo myObject;
                XmlSerializer serializer = new XmlSerializer(typeof(Classes.CreateModuleInfo));
                using (Stream reader = new FileStream(filepath, FileMode.Open))
                {
                    

                   myObject = (Classes.CreateModuleInfo)serializer.Deserialize(reader);


                    // get all libs. 
                    var libs = System.IO.Directory.GetFiles(folderpath + "\\lib");
                    List<string> ListofResources = new List<string>();
                    //remove the textfiles
                    foreach(var l in libs)
                    {
                        if (l.Contains(".dll"))
                        {
                            ListofResources.Add(l.Replace(folderpath, "."));
                        }

                    }

                    myObject.Clients.References = ListofResources.ToArray();

                    
                }

                using (TextWriter writer = new StreamWriter(filepath))
                {
                    serializer.Serialize(writer, myObject);
                    writer.Close();
                }

            }

        }



        
    }
}
