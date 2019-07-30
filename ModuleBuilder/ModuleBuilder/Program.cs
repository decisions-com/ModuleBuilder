using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModuleBuilder
{
    class Program
    {
     

        static void Main(string[] args)
        {

            Console.WriteLine("----------------Decisions.com-------------------");
            Console.WriteLine("");
            Console.WriteLine("Enter the Name of your Module you wish to create");
            var requiredModuleName = Console.ReadLine();
            var doesntihaveabuildlocalation = BuildIt(requiredModuleName, true);
            Console.WriteLine(doesntihaveabuildlocalation);

            string ModuleFolder = @"C:\DecisionsModuleBuilderTemp\" +requiredModuleName;

            //string[] allfiles = Directory.GetFiles(@"C:\DecisionsModuleBuilderTemp\A", "*.*", SearchOption.AllDirectories);
            var namestocheck = NamesToReplace();
            var modulename = requiredModuleName;

            //replaces all folders

            string[] AllFolders = Directory.GetDirectories(ModuleFolder, "*.*", SearchOption.AllDirectories);


            foreach (string folder in AllFolders)
            {
                if (folder.Contains("git"))
                {
                }

                else if (folder.Contains("bin"))
                {

                }
                else if ( folder.Contains("obj"))
                {

                }
                else {
                    foreach (var name in namestocheck)
                    {
                        string FolderEndDIR = folder.Split('\\').Last();
                        if (FolderEndDIR.Contains(name))
                        {
                            var foundmatch = true;
                            FolderReplace(folder, name, modulename);
                        }

                    }
                }
                   
                
            }

            //replaces files
            string[] allfiles = Directory.GetFiles(ModuleFolder, "*.*", SearchOption.AllDirectories);

            foreach (var file in allfiles)
            {

                var filestring = file.Split('\\').Last(); ;
                
                FileInfo info = new FileInfo(file);

                foreach (var namesto in namestocheck)
                {
                    if (filestring.Contains(namesto))
                    {
                        try
                        {
                            var newfilename = file.Replace(namesto, modulename);
                            var contents = File.ReadAllText(file);
                            System.IO.File.WriteAllText(newfilename, contents);
                            File.Delete(file);
                        }
                        catch (Exception)
                        {

                            
                        }
                      
                    }
                }



            }


            //replace contents
            allfiles = Directory.GetFiles(ModuleFolder, "*.*", SearchOption.AllDirectories);

            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);

                foreach (var namesto in namestocheck)
                {
                    var readallines = System.IO.File.ReadAllText(info.FullName);
                    if (readallines.Contains(namesto))
                    {
                        var found = true;
                        FileContentsReplace(file, namesto, modulename);
                    }
                }



            }







            

            Console.Read();

           
        }

        public static string FileContentsReplace (string file, string stringtoreplace, string ModuleName)
        {
            var filecontents = File.ReadAllText(file);
            var changedcontent = filecontents.Replace(stringtoreplace, ModuleName);
            File.WriteAllText(file, changedcontent);

            return "";
        }
        public static string FileNameReplace ()
        {

            return "";
        }


        public static string FolderReplace (string Folder, string stringtoreplace, string ModuleName)
        {


            string destination = Folder.Replace(stringtoreplace, ModuleName) ;

            try
            {
                Directory.Move(Folder, destination);
            }
            catch (Exception)
            {

                
            }
            return null;
        }

        public static string BuildIt(string modulenameToBuild, bool Overwrite )
        {
            
            var repoLocation = @"c:\DecisionsModuleBuilderTemp";
            var repofullpath = repoLocation + "\\" + modulenameToBuild;
            var exists = System.IO.Directory.Exists(repofullpath);
            
            System.IO.Directory.CreateDirectory(repofullpath);
            try
            {
                Repository.Clone("https://github.com/decisions-com/decisions-mod-skeleton.git", repofullpath);
            }
            catch (Exception ex2)
            {

                return ex2.Message;
            }

   





            return "Build Done, its in "+ repofullpath;
        }



        public static  List<string> NamesToReplace ()
        {
            var items = new List<string>()
            {
                "MyModuleCode", "Example.Module", "MyModule"
            };
            return items;
        }




        



        public bool folderRename(string Fullpath, string to)
        {
            try { 
           
           
            
                
            }
            catch (Exception)
            {
                return false;
                throw;
            }

            return true;
        }
    }
}
