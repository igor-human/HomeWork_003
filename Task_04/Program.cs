using System;
using System.Text;
using Task_04;





namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;

            Console.WriteLine("Введіть номер ключа доступу (pro або exp):");
            string key = Console.ReadLine();
            DocumentWorker documentWorker;
            // Перевірка ключа доступу
            if (key == "pro")
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                documentWorker = new ExpertDocumentWorker();
            }
            else
            {
                documentWorker = new DocumentWorker();
            }

            // Виклик методів документа
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();


            // Delay.
            Console.ReadKey();
        }
    }
}
