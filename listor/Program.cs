using System;
using System.Collections.Generic;

namespace lista
{
    class Program
    {
        static int Minsta(List<int> listan) {
            int minimum = listan[0];

            foreach(int i in listan){
                if(i < minimum){
                    minimum = i;
                }
            }

            return minimum;
        }

        static int Största(List<int> listan) {
            int maximum = listan[0];

            foreach(int i in listan){
                if(i > maximum){
                    maximum = i;
                }
            }

            return maximum;
        }

        static void SkrivUt(List<int> listan) {
            foreach(int i in listan){
                Console.WriteLine(i);
            }
        }

        public static void Main (string[] args) {
            List<int> minLista = new List<int>();
            minLista.Add(11);
            minLista.Add(5);
            minLista.Add(12);
            minLista.Add(3);
            minLista.Add(6);
            minLista.Add(3);

            SkrivUt(minLista);

            Console.WriteLine("Största tal: "+Största(minLista));
            Console.WriteLine("Minsta tal: "+Minsta(minLista));

        }
    }
}