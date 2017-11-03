using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class Program
    {
        static void Main(string[] args)
        {

            Dom mojDom = new Dom("activ 1 ", "aktivni", "nie", 3, 74.8f, 30.8f);
            mojDom.poskytniInformacie();
            Console.WriteLine("percenta zastavenej plochy {0}", mojDom.ZistiVyuzitieZastavanejplochy());

            Dom susedovdom = new Dom("activ 1 ", "aktivni", "nie", 3, 74.8f, 30.8f);
            susedovdom.poskytniInformacie();
            Console.WriteLine("percenta zastavenej plochy {0}", mojDom.ZistiVyuzitieZastavanejplochy());

            Chata chata = new Chata("chata 1","pasivne","10",50,200.5f,100,"ano a velka");
            chata.poskytniInformacie();
            chata.popischaty();
            

            Console.ReadLine();
        }
    }
}
