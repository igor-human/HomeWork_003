using System;
using System.Text;
using Task_02;



namespace Classes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            
            Pupil pupil1 = new ExcellentPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new GoodPupil();
            Pupil pupil4 = new BadPupil();

            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);

            classRoom.Study();
            classRoom.Read();
            classRoom.Write();
            classRoom.Relax();

            // Delay.
            Console.ReadKey();
        }
    }
}