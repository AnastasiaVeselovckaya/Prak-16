using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string line1 = File.ReadLines("C:\\Users\\user\\Desktop\\Первый.txt").Skip(0).First();
        string line2 = File.ReadLines("C:\\Users\\user\\Desktop\\Первый.txt").Skip(1).First();
        string line3 = File.ReadLines("C:\\Users\\user\\Desktop\\Первый.txt").Skip(2).First();
        string line4 = File.ReadLines("C:\\Users\\user\\Desktop\\Первый.txt").Skip(3).First();
        string line5 = File.ReadLines("C:\\Users\\user\\Desktop\\Первый.txt").Skip(4).First();
        string line6 = File.ReadLines("C:\\Users\\user\\Desktop\\Первый.txt").Skip(5).First();
        StreamWriter sw1 = new StreamWriter("C:\\Users\\user\\Desktop\\Второй.txt");
        sw1.WriteLine(line6);
        sw1.WriteLine(line5);
        sw1.WriteLine(line4);
        sw1.WriteLine(line3);
        sw1.WriteLine(line2);
        sw1.WriteLine(line1);
        sw1.Close();
    }
}