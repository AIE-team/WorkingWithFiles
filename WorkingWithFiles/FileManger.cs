using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithFiles
{
     static class FileManger
     {
        static string path = @"C:\Users\Admin\Documents\AIE\SoftwareDevelopmentFundamentals\code\WorkingWithFiles\Users.txt";

        static public void WriteToFile(string content)
        {
            StreamWriter wr = new StreamWriter(path,true);
            wr.WriteLine(content);
            wr.Close();

        }


    }
}
