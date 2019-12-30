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
            var doesntihaveabuildlocalation = ModuleBuilder472.ModuleBuilder472Class.Runner(requiredModuleName);
            Console.WriteLine(doesntihaveabuildlocalation);



        }
    }
}
