using System;


namespace ProgrammingLabs
{
    class Start
    {
        static void Main(string[] args)
        {
            Document Document = new Document("Habr", "Leonid", "Programming", "Education", "www.habr.com");
            MSExcel Excel = new MSExcel("Table", "Tgnat", "Economy", "Table", "C:\\", 10, 10);
            TXT Txt = new TXT("Txt", "Blake", "LabaPoProge", "Education", "C:\\", "UTF-8");
            Console.WriteLine(Document.GetInfo());
            Console.WriteLine(Excel.GetInfo());
            Console.WriteLine(Txt.GetInfo());
        }
    }
}
