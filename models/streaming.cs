using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace I___O_PUT_inNet.models
{
    public static class streaming
    {
        public static string path = "./Files/streaming";
        public static void write()
        {
            if(File.Exists(path)){

                File.Delete(path);
            }

            FileStream fs = new FileStream(path, FileMode.CreateNew);
            BufferedStream decorated = new BufferedStream(fs);
            StreamWriter adapter = new StreamWriter(decorated);

            string[] text = { "all text", "comes", "line", "by", "line" };

            /* text.ToList().ForEach (x => adapter.WriteLine(x)); */
            /* foreach(string item in text){

            } */
            int f = text.Length;
            for (int i = 0; i < text.Length; i++)  // string array.Tolist is not working here 
            {
                System.Console.WriteLine(text[i].ToString());
            }

            adapter.Flush();



            System.Console.WriteLine("Done and closing now!");
            adapter.Close();
        }
    }
}