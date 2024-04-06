using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Pupil
    {
        //Чотири віртуальні методи
        public virtual void Study()
        {
            Console.WriteLine("Учень вчиться");
        }

        public virtual void Read()
        {
            Console.WriteLine("Учень читає");
        }

        public virtual void Write()
        {
            Console.WriteLine("Учень пише");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Учень выдпочіває");
        }
    }
    internal class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Відмінник старанно вчиться");
        }
        public override void Read()
        {
            Console.WriteLine("Відмінник гарно читає");
        }
        public override void Write()
        {
            Console.WriteLine("Відмінник старанно пише");
        }
        public override void Relax()
        {
            Console.WriteLine("Відмінник відпочиває, але не напивається");
        }
    }
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Хорошист добре вчиться");
        }
        public override void Read()
        {
            Console.WriteLine("Хорошист добре читає");
        }
        public override void Write()
        {
            Console.WriteLine("Хорошист нормально пише");
        }
        public override void Relax()
        {
            Console.WriteLine("Хорошист відпочиває, може, іноді, випити пивка");
        }
    }
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Двоюшник майже не вчиться");
        }
        public override void Read()
        {
            Console.WriteLine("Двоюшник читає бе-ме");
        }
        public override void Write()
        {
            Console.WriteLine("Двоюшник пише гірше лікаря, сам потім не може прочитати");
        }
        public override void Relax()
        {
            Console.WriteLine("Двоюшник багато відпочиває, але на ранок нічого не пам'ятає");
        }
    }

}
