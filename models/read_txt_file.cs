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
    }


}