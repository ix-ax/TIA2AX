using System.IO;
using System.Linq;
using System.Reflection;
using System;
using tia2axTestHelper.Utils;

namespace tia2axTestHelper
{
    public class TestsCommon
    {
        internal static string TestFolderPath { get; private set; }
        internal static string SourcePath { get; private set; }
        internal static DirectoryInfo expectedDir { get; private set; }
        internal static DirectoryInfo generatedDir { get; private set; }
        internal static DirectoryInfo workDir { get; private set; }

        internal static void OneTimeSetup()
        {
            var executingAssemblyPath = new FileInfo(Assembly.GetExecutingAssembly().Location);
            var executingAssemblyFolder = executingAssemblyPath.Directory.FullName;
            TestFolderPath = Path.GetFullPath(executingAssemblyFolder + @"..\..\..\..\..\test_projects\");

            SourcePath = (TestFolderPath + "\\tabularasa").Replace("\\\\", "\\");
            expectedDir = new DirectoryInfo((TestFolderPath + "\\_expected").Replace("\\\\", "\\"));
            if (Directory.Exists(expectedDir.FullName))
            {
                expectedDir.Delete(true);
            }
            expectedDir.Create();
            generatedDir = new DirectoryInfo((TestFolderPath + "\\_generated").Replace("\\\\", "\\"));
            if (Directory.Exists(generatedDir.FullName))
            {
                generatedDir.Delete(true);
            }
            generatedDir.Create();
            workDir = new DirectoryInfo((TestFolderPath + "\\_work").Replace("\\\\", "\\"));
            if (Directory.Exists(workDir.FullName))
            {
                workDir.Delete(true);
            }
            workDir.Create();
            EventLogger.VerbosityLevel = Serilog.Events.LogEventLevel.Error;
        }

        internal static void Setup()
        {
            if (Directory.Exists(expectedDir.FullName))
            {
                expectedDir.Delete(true);
            }
            expectedDir.Create();
            if (Directory.Exists(generatedDir.FullName))
            {
                generatedDir.Delete(true);
            }
            generatedDir.Create(); 
            if (Directory.Exists(workDir.FullName))
            {
                workDir.Delete(true);
            }
            workDir.Create();
        }

        internal static void OneTimeTearDown()
        {
            if (Directory.Exists(expectedDir.FullName))
            {
                expectedDir.Delete(true);
            }
            if (Directory.Exists(generatedDir.FullName))
            {
                generatedDir.Delete(true);
            }
            if (Directory.Exists(workDir.FullName))
            {
                workDir.Delete(true);
            }
        }

        internal static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        internal static void CopyFiles(string sourcePath, string targetPath)
        {
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.TopDirectoryOnly))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        internal static bool AllFilesAreEqual()
        {
            return AllFilesAreEqual(expectedDir.FullName, generatedDir.FullName);
        }
        internal static bool AllFilesAreEqual(string expectedFolder, string generatedFolder)
        {
            bool areEqual = true;
            SearchOption searchOption = SearchOption.AllDirectories;
            string[] expectedFiles = Directory.GetFiles(expectedFolder, "*", searchOption);

            foreach (string expectedFile in expectedFiles)
            {
                string generatedFile = expectedFile.Replace(expectedFolder, generatedFolder);
                if (File.Exists(generatedFile))
                {
                    areEqual = AreFilesEqual(expectedFile, generatedFile) ? areEqual : false;
                }
                else
                {
                    Console.WriteLine(@"Generated file ""{0}"" not exists.", generatedFile.Replace(generatedFolder, ".."));
                    areEqual = false;
                }
            }
            return areEqual;
        }
        internal static bool AreFilesEqual(string path1, string path2)
        {
            bool areEqual = false;
            if (AreFilesBytwiseEqual(path1, path2))
            {
                areEqual = true;
            }
            return areEqual;
        }

        private static bool AreFilesBytwiseEqual(string path1, string path2) => File.ReadAllBytes(path1).SequenceEqual(File.ReadAllBytes(path2));
       
    }
}