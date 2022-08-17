using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkWithFiles
{
    class Program
    {
        static void WriteFile(string arg)
        {
            FileStream fileStream = new FileStream(arg,FileMode.Open, FileAccess.Write);

            if(fileStream.CanWrite)
            {
                byte[] buf = Encoding.ASCII.GetBytes("Hello World");

                fileStream.Write(buf, 0, buf.Length);
            }
            //fileStream.Flush();
            fileStream.Close();
        }
        static void ReadFile(string arg)
        {
            FileStream fileStream = new FileStream(arg, FileMode.Open,FileAccess.Read);

            if (fileStream.CanRead)
            {
                byte[] buf = new byte[fileStream.Length];

                //int read = fileStream.Read(buf, 0, buf.Length);

                Console.WriteLine(Encoding.ASCII.GetString(buf,0,buf.Length));
            }

            fileStream.Close();
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\Babken\Desktop";

            WriteFile(path);
            ReadFile(path);

            Console.ReadKey();

        }
    }
}
