using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }

        // Метод для редагування документа
        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа у версії Безкоштовна");
        }

        // Метод для збереження документа
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа у версії Безкоштовна");
        }
    }
}
