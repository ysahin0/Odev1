using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Satilik satilikEv = new Satilik();
            Kiralik kiralikEv = new Kiralik();
            
            
            void kiralikMenu() 
            {
                Console.WriteLine("1. Kiralik Ev Ozellikleri\n" + "2. Kiralik Fiyat Bilgisi\n" + "3. Kiralik Adres Bilgisi\n");
            }
            void satilikMenu()
            {
                Console.WriteLine("1. Satili Ev Ozellikleri\n" + "2. Satilik Fiyat Bilgisi\n" + "3. Satilik Adres Bilgisi\n");
            }
            

            Console.WriteLine("Hangi islemi yapacaksiniz?\n 1. Satilik\n 2. Kiralik");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    { satilikMenu();
                        int b = Convert.ToInt32(Console.ReadLine());
                    
                        switch (b)
                        {
                            case 1:
                                {
                                    
                                    Console.WriteLine("Satilik evin özelligi");
                                    Console.WriteLine(satilikEv.evOzellik());
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Satilik evin fiyati");
                                    Console.WriteLine(satilikEv.fiyatBilgisi());
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Satilik evin adresi");
                                    Console.WriteLine(satilikEv.adresBilgisi());
                                }
                                break;
                        }
                    }
                    break;
                case 2: 
                    { kiralikMenu();
                        int c = Convert.ToInt32(Console.ReadLine());
                        
                        switch (c)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Kiralik evin ozellikleri");
                                    Console.WriteLine(kiralikEv.evOzellik());
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Kiralik evin kirasi");
                                    Console.WriteLine(kiralikEv.fiyatBilgisi()); 
                                }
                                break;
                            case 3:
                                {
                                    
                                    Console.WriteLine("Kiralik evin adresi" );
                                    Console.WriteLine(kiralikEv.adresBilgisi());

                                }
                                break;

                        }
                    }
                
                    break;

                default: { Console.WriteLine("hatali rakam tusladiniz"); }
                    break;

            }


            Console.ReadLine();

        }
    }
}
