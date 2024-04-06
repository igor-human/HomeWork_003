using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class ClassRoom
    {
        private Pupil[] pupils; // Масив учнів

        public ClassRoom(params Pupil[] pupils)
        {
            // Ініціалізація масиву учнів
            this.pupils = new Pupil[pupils.Length];
            for (int i = 0; i < pupils.Length; i++)
            {
                this.pupils[i] = pupils[i];
            }
        }

        // Методи для проведення діяльності у класі для кожного учня
        public void Study()
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
            }
        }
        public void Read()
        {
            foreach (var pupil in pupils)
            {
                pupil.Read();
            }
        }

        public void Write()
        {
            foreach (var pupil in pupils)
            {
                pupil.Write();
            }
        }

        public void Relax()
        {
            foreach (var pupil in pupils)
            {
                pupil.Relax();
            }
        }

    }


}
