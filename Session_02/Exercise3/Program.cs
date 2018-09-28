using System;
using System.IO;
using System.Threading.Tasks;

namespace Exercise3
{
    class Reader
{
    string fileName;
    public string Data { get; set; }

    public Reader(string fn) { fileName = fn; }

    public void Read()
    {
        FileStream s = new FileStream(fileName, FileMode.Open);
        StreamReader r = new StreamReader(s);
        Data = r.ReadToEnd();
        r.Close();
        s.Close();
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Reader readTest1 = new Reader("test1.txt");
            Reader readTest2 = new Reader("test2.txt");
            Reader readTest3 = new Reader("test3.txt");
            readTest1.Read();
            readTest2.Read();
            readTest3.Read();
            Parallel.Invoke(() => Test(readTest1, readTest2), () => Test(readTest3, readTest2),() => Test(readTest3, readTest1) );
        }
        
        public static void Test(Reader reader1, Reader reader2)
        {        
            if(reader1.Data.Equals(reader2.Data))
            System.Console.WriteLine("They are equal");
            else
            System.Console.WriteLine("They are not equal");
        }
    }
}
