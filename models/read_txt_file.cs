using System;
using System.IO;

namespace I___O_PUT_inNet.models
{
    public static class read_txt_file
    {
        // full path here

        public static void ReadTxtFile()
        {
              string current_dir = Environment.CurrentDirectory;

            // ...//...file.txt
              string path = Path.Combine(current_dir, "Files/myfile.txt");

            string[] lines = File.ReadAllLines(path);
            System.Console.WriteLine(string.Join(Environment.NewLine, lines));
        }
    }
}