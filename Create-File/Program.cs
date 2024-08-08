using System;
using System.IO;
using System.Text;

class CreateFile
{
    public static void Main()
    {
        string fileName = @"testfile.txt";

        try
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.Write("\n\n Create a file in the disk if it exists:\n");
            Console.Write("-----------------------------------------------\n");

            using (FileStream fileStr = File.Create(fileName))
            {
                Console.WriteLine(" A file created with name testfile.txt\n\n");
            }
        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
}