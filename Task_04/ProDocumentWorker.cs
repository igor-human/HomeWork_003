using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class ProDocumentWorker : DocumentWorker
    {
        // Перевизначення методу EditDocument
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредаговано");
        }

        // Перевизначення методу SaveDocument
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
        }
    }
}
