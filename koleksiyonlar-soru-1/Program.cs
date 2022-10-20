using System;
using System.Collections;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            /*
              -Negatif ve numeric olmayan girişleri engelleyin.
              -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
              -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            */
            
            
            ArrayList prime = new ArrayList();
            ArrayList notPrime = new ArrayList();

            Console.WriteLine("20 Adet Pozitif Sayı Giriniz");
            
            
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine((i+1)+". Sayı");
                string num = Console.ReadLine();
                if (IsItLetter(num))
                {
                    
                    int number = int.Parse(num);
                    int[] numbers = new int[number];
                    
                    if (ItIsPrime(number) == false)
                    {
                        notPrime.Add(number);
                    }
                    else
                    {
                        prime.Add(number);
                    }
                    
                }
                
            }

            Console.WriteLine("******Asal Sayılar******");
            prime.Sort();
            prime.Reverse();
            foreach (var item in prime)
            {
                Console.Write(item+",");
                
            }
            Console.WriteLine("Eleman Sayısı: " + prime.Count);

            //ArrayList diziye çevrilip dizi metotu kullanıldı
            int[] arrPrime = new int[20];
            arrPrime =(int[]) prime.ToArray(typeof(int));

            Console.WriteLine("Toplam: "+Sum(arrPrime));
            Console.WriteLine("Ortalama: "+Average(arrPrime));
            

            Console.WriteLine("******Asal Olmayan Sayılar******");
            notPrime.Sort();
            notPrime.Reverse();
            foreach (var item in notPrime)
            {
                Console.Write(item+",");
            }

            Console.WriteLine("Eleman Sayısı: " + notPrime.Count);

            //ArrayList diziye çevrilip dizi metotu kullanıldı
            int[] arrNotPrime = new int[20];
            arrNotPrime =(int[]) notPrime.ToArray(typeof(int));

            Console.WriteLine("Toplam: "+ Sum(arrNotPrime));
            Console.WriteLine("Ortalama: "+ Average(arrNotPrime));
            
        }
        // Asal mı Değil mi kontrolünü yapan metod
        static bool ItIsPrime(int a)
        {
            
            if (a < 2 || (a % 2 == 0 && a != 2))
            {
                return false;
            }
                
            else
            {
                for (int i = 3; i < a; i += 2)
                {
                    if (a % i == 0)
                    {
                        return false;
                        
                    }
                }
            }
            return true;
        }
        //Toplama Metodu
        static int Sum(int[] num)
        {
            int total =  0;
           
            for (int i = 0; i < num.Length; i++)
            {
                total += num[i] ;
            }
            return total;
        }
        //Ortalama Alma Metodu
        static double Average(int[] num)
        {
            double average = 0;
            int total = 0;

            for (int i = 0; i < num.Length; ++i)
            {
                total += num[i]; 
            }
            average = (double)total / (num.Length);

            return average;
        }
        static bool IsItLetter(string thisNumber)
        {
            bool result = int.TryParse(thisNumber, out int outNumber);

            if(result)
            {
                if( outNumber > 0 )
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Harf Girdiniz!");
                return false;
            }
        }
        

        

    }
    
}
