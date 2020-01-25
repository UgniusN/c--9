using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        public struct Mokinys
        {
            public List<int> trimestras1;
            public List<int> trimestras2;
            public List<int> trimestras3;
            public Mokinys(List<int> iterpiamas1, List<int> iterpiamas2, List<int> iterpiamas3)
            {
                this.trimestras1 = iterpiamas1;
                this.trimestras2 = iterpiamas2;
                this.trimestras3 = iterpiamas3;
            }
            public int PirmoTrimestroVidurkis()
            {
                int vidurkis = 0;
                foreach(int skaicius in trimestras1)
                {
                    vidurkis += skaicius;
                }
                return vidurkis / trimestras1.Count;
            }
            public int AntroTrimestroVidurkis()
            {
                int vidurkis = 0;
                foreach (int skaicius in trimestras2)
                {
                    vidurkis += skaicius;
                }
                return vidurkis / trimestras2.Count;
            }
            public int TrecioTrimestroVidurkis()
            {
                int vidurkis = 0;
                foreach (int skaicius in trimestras3)
                {
                    vidurkis += skaicius;
                }
                return vidurkis / trimestras3.Count;
            }
            public int metinisPazimys()
            {
                return (PirmoTrimestroVidurkis() + AntroTrimestroVidurkis() + TrecioTrimestroVidurkis()) / 3;
            }
        }
        public static List<int> pirmoTrimestroPazymiai = new List<int>();
        public static List<int> antroTrimestroPazymiai = new List<int>();
        public static List<int> trecioTrimestroPazymiai = new List<int>();
        public static Mokinys Jonas = new Mokinys(pirmoTrimestroPazymiai, antroTrimestroPazymiai, trecioTrimestroPazymiai);
        static void Main(string[] args)
        {
            Jonas.trimestras1.Add(5); Jonas.trimestras1.Add(2); Jonas.trimestras1.Add(4); Jonas.trimestras1.Add(9); Jonas.trimestras1.Add(4); Jonas.trimestras1.Add(6); Jonas.trimestras1.Add(7);
            Jonas.trimestras2.Add(2); Jonas.trimestras2.Add(9); Jonas.trimestras2.Add(8); Jonas.trimestras2.Add(7); Jonas.trimestras2.Add(5); Jonas.trimestras2.Add(10); Jonas.trimestras2.Add(2);
            Jonas.trimestras3.Add(7); Jonas.trimestras3.Add(5); Jonas.trimestras3.Add(2); Jonas.trimestras3.Add(8); Jonas.trimestras3.Add(6); Jonas.trimestras3.Add(10); Jonas.trimestras3.Add(9);
            isvestiVidurkius();
            Console.Read();
            
        }


        //public static void generuotiVidurki1(List<int> idetasList)
        //{
        //    Random rand = new Random();
        //    for(int i=0; i<10; i++)
        //    {
        //        idetasList.Add(rand.Next(1, 10));
        //        Console.WriteLine();
        //    }
        //    ideta
        //}

        public static void isvestiVidurkius()
        {
            Console.WriteLine("Pirmo pusmecio vidurkis: {0}", Jonas.PirmoTrimestroVidurkis());
            Console.WriteLine("Antro pusmecio vidurkis: {0}", Jonas.AntroTrimestroVidurkis());
            Console.WriteLine("Trecio pusmecio vidurkis: {0}", Jonas.TrecioTrimestroVidurkis());
            Console.WriteLine("Metinis pusmecio pazimys: {0}", Jonas.metinisPazimys());
        }
    }
}
