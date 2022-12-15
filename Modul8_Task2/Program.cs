using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите путь:");
        string path = Console.ReadLine();
        DirectoryInfo di = new DirectoryInfo(path);
       
        if (di.Exists)
        {
            
            Console.WriteLine("Размер: " + DirectoryExtension.CountSize(di) + " байт");
        }
        else
        {
            Console.WriteLine("Папка не существует по указанному пути. Проверьте правильность.");
        }
    }
    internal class DirectoryExtension
    {
        public static long CountSize(DirectoryInfo d)
        {
            long size = 0;
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }

            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += CountSize(di);
            }
            return size;
            Console.ReadKey();
        }
        
    } 
}
