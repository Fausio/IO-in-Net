using System;
using System.IO;

namespace I___O_PUT_inNet.models
{
    public static class read_txt_file
    {


        public static void ReadTxtFile()
        {
            string current_dir = Environment.CurrentDirectory; // get full path

            string path = Path.Combine(current_dir, "Files/myfile.txt"); //Get the ..file.txt

            string[] lines = File.ReadAllLines(path);         // read all lines
            System.Console.WriteLine(string.Join(Environment.NewLine, lines));
        }
        public static string path_ = "./Files/created";
        private static int added = 0;
        public static void MaketxtFile()
        {
            string path = "./Files/created";

            try
            {
                if (File.Exists(path))
                {
                    added++;
                    // open and write some lines
                    File.AppendAllLines(path, new[] { "addenum" + added });
                }
                else
                {
                    File.WriteAllLines(path, new[] { "1 First line", "2 Secund line", "3 others line", "" });
                }
            }
            catch (System.Exception x)
            {
                System.Console.WriteLine($"not went !: " + x);
            }

        }

        public static void DeleteFile()
        {

            string path = "./created";
            File.Delete(path);

            try
            {
                System.Console.WriteLine(string.Join(", ", File.ReadAllLines(path)));
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("File not found :", ex);
            }

        }


        public static void copy()
        {
            /*  bool overwrite = true;
             File.Copy(path, Environment.CurrentDirectory, overwrite);

             System.Console.WriteLine($"File Exists: {File.Exists(path)}");
             System.Console.WriteLine($"File Exists: {File.Exists("./Files/created")}"); */
        }

        public static void Rename()
        {
            //renamed to create ---> renamed
            string rename = "./Files/renamed";
            File.Move(path_, rename);
            System.Console.WriteLine($"renamed exists in files dir {File.Exists(rename)}");
        }

        public static void Relocate()
        {
            string rename = "./Files/renamed";
            string RelocateTo = Environment.CurrentDirectory + "/renamed";
            File.Move(rename, RelocateTo);
        }


        public static void Read()
        {
            string pathRead = "./renamed";
            System.Console.WriteLine(Path.GetDirectoryName(pathRead));
            System.Console.WriteLine(Path.HasExtension(pathRead));
            System.Console.WriteLine(Path.GetFileName(pathRead));
            System.Console.WriteLine(Path.IsPathFullyQualified(pathRead));
        }

        public static void CreateAndUpdatepaths()
        {
            string pathRead = "./renamed";
            string modified = Path.ChangeExtension(pathRead, ".csv");

            System.Console.WriteLine(Path.GetExtension(modified));
            System.Console.WriteLine(Path.GetFileName(modified));
            System.Console.WriteLine(Path.GetFileNameWithoutExtension(modified));
        }

        public static void CreatDirectory()
        {
            string pathRead = "./Files/created_1";

            if (Directory.Exists(pathRead))
            {

                Directory.Delete(pathRead);
                System.Console.WriteLine("Directorey deleted !");
            }

            Directory.CreateDirectory(pathRead);
        }



        public static void EnumerateDirectoryInfo()
        {
            string pathRead = "./Files/created_1";
            DirectoryInfo info = new DirectoryInfo(pathRead);

            System.Console.WriteLine($"Does is exist? {info.Exists}");
             
             foreach(FileInfo file in info.EnumerateFiles()){
                 System.Console.WriteLine($"file Name: {file.Name}");
                 System.Console.WriteLine(string.Join(Environment.NewLine, File.ReadAllLines(file.FullName)));
             }
        }
    }


}