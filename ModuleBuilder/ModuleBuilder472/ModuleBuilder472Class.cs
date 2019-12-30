
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace ModuleBuilder472
{
    public class ModuleBuilder472Class
    {

        public static string Runner(string requiredModuleName)
        {


            var doesntihaveabuildlocalation = BuildItAsync(requiredModuleName, true);
            Console.WriteLine(doesntihaveabuildlocalation);


            var checkifdirforDecisionsModuleBuilderTempExists = System.IO.Directory.Exists(doesntihaveabuildlocalation.Result);
            if (checkifdirforDecisionsModuleBuilderTempExists == false)
            {
                System.IO.Directory.CreateDirectory(@"C:\DecisionsModuleBuilderTemp");
            }


            string ModuleFolder = doesntihaveabuildlocalation.Result;

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
                else if (folder.Contains("obj"))
                {

                }
                else
                {
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




            //copy the UpdateThirdpartyReferenceModule Tool to that folder. 

            var currentpath = Environment.CurrentDirectory;
            System.IO.File.Copy(currentpath + @"/UpdateThirdPartyReferencesInModuleBuild.exe", ModuleFolder + "/UpdateThirdPartyReferencesInModuleBuild.exe", true);



            return doesntihaveabuildlocalation.Result;


        }

        public static string FileContentsReplace(string file, string stringtoreplace, string ModuleName)
        {
            var filecontents = File.ReadAllText(file);
            var changedcontent = filecontents.Replace(stringtoreplace, ModuleName);
            File.WriteAllText(file, changedcontent);

            return "";
        }
        public static string FileNameReplace()
        {

            return "";
        }


        public static string FolderReplace(string Folder, string stringtoreplace, string ModuleName)
        {


            string destination = Folder.Replace(stringtoreplace, ModuleName);

            try
            {
                Directory.Move(Folder, destination);
            }
            catch (Exception)
            {


            }
            return null;
        }

        public static async System.Threading.Tasks.Task<string> BuildItAsync(string modulenameToBuild, bool Overwrite)
        {
            var repoLocation = "";
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                repoLocation = @"c:\DecisionsModuleBuilderTemp\";
            }
            else
            {
                repoLocation = Path.GetTempPath();
            }
            var repofullpath = repoLocation + "" + modulenameToBuild;
            var exists = System.IO.Directory.Exists(repofullpath);
            var user = Environment.UserName;
            System.IO.Directory.CreateDirectory(repofullpath);
            exists = System.IO.Directory.Exists(repofullpath);
            var path = repofullpath;
            try
            {

                var url = "https://github.com/decisions-com/decisions-mod-skeleton/archive/master.zip";
                ;

                using (var client = new System.Net.Http.HttpClient())
                {

                    var contents = client.GetByteArrayAsync(url).Result;

                    System.IO.File.WriteAllBytes(path + "/master.zip", contents);
                    String ZipPath = path + "/master.zip";
                    String extractPath = path;
                    ZipFile.ExtractToDirectory(ZipPath, extractPath);
                    var SourcePath = path + "/decisions-mod-skeleton-master";
                    foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
    SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(SourcePath, path));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
                        SearchOption.AllDirectories))
                        File.Move(newPath, newPath.Replace(SourcePath, path));

                    Directory.Delete(path + "/decisions-mod-skeleton-master", true);
                    File.Delete(path + "/master.zip");

                }

            }
            catch (Exception ex2)
            {

                return ex2.Message;
            }







            return path;
        }



        public static List<string> NamesToReplace()
        {
            var items = new List<string>()
            {
                "MyModuleCode", "Example.Module", "MyModule"
            };
            return items;
        }








        public bool folderRename(string Fullpath, string to)
        {
            try
            {




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
