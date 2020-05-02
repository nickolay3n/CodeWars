using System;
using System.IO;

namespace CopyFileStream
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] argss=new string[2];
            if (argss[0] == null)  argss[0] = new string(@"C:\Users\user\Desktop\60 min.cmd");
            if (argss[1] == null) argss[1] = new string ( @"C:\Users\user\Desktop\60 min2.cmd" );

            int i;
            FileStream fin = null;
            FileStream fout = null;

            if (args.Length != 2) { Console.WriteLine("no params!"); }
            try
            {
                fin = new FileStream(argss[0], FileMode.Open);
                fout = new FileStream(argss[1], FileMode.Create);
                do
                {
                    i = fin.ReadByte();
                    if (i != -1) fout.WriteByte((byte)i);

                } while (i != -1);

            }
            catch (IOException exc) { Console.WriteLine("IO Error!"); }
            finally { 
                if (fin != null) fin.Close();
                if (fout != null) fout.Close();
            }
            
            Console.WriteLine("Hello World!");
            
        }
    }
}
