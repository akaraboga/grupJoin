using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace grupJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Ogrenci> ogrenciler = new List<Ogrenci>//Ogrenci sınıfına list aracılığıyla propertylerine veri ekleme
            {
                new Ogrenci{ogrenci_id=1,ogrenci_ad="Ahmet",Sınıf_id=1},
                new Ogrenci{ogrenci_id=2,ogrenci_ad="Mehmet",Sınıf_id=2},
                new Ogrenci{ogrenci_id=3,ogrenci_ad="Fatma",Sınıf_id=2},
                new Ogrenci{ogrenci_id=4,ogrenci_ad="Gizem",Sınıf_id=3},

            };

            List<Sınıf> sınıflar = new List<Sınıf>// Sınıf clasına   list aracılığıyla propertylerine veri ekleme
            {
                new Sınıf{Sınıf_ad="Matematik",Sınıf_id=1},
                new Sınıf{Sınıf_ad="Turkce",Sınıf_id=2},
                new Sınıf{Sınıf_ad="Fen bilgileri",Sınıf_id=3}

            };


            var grupJoinSorgu = from Ogrenci in ogrenciler//Grup join ile Sınıf clasında ki sınıf_id ile Ogrenci clasında ki Sınıf_id yi birlestiriyoruz
                                join @Snf in sınıflar on Ogrenci.Sınıf_id equals @Snf.Sınıf_id
                                select new
                                {
                                    ogrAd = Ogrenci.ogrenci_ad,
                                    sınıfAd = Snf.Sınıf_ad
                                };



            foreach(var bilgi in grupJoinSorgu)//Ekrana bastırma
            {
                Console.WriteLine("Ogrenci Ad : {0} Sınıfı : {1}",bilgi.ogrAd,bilgi.sınıfAd);
                Console.WriteLine();
            }

                
                             
             

            Console.ReadLine();
        }
    }
}
