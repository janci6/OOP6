using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Chata : Dom
    {
        private string spolocenskamiestnost;

        public Chata (string nazov,string typ,string poschodie,int obytnemiestnosti,float uzitkovaPlocha,float zastavanaPlocha,string spolocenskamiestnost): base(nazov,typ,poschodie,obytnemiestnosti,uzitkovaPlocha,zastavanaPlocha)
        {
            this.spolocenskamiestnost = spolocenskamiestnost;

        }
        public void popischaty()
        {
            Console.WriteLine("spolocenska miestnost: {0}", spolocenskamiestnost);
        }
    }
}
