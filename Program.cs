using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Masukkan jumlah mahasiswa:");
        //int n = Convert.ToInt32(Console.ReadLine());
        int[] ages = new int[10];

        Console.WriteLine("Masukkan umur mahasiswa:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Masukkan umur mahasiswa ke {i+1} = ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Data umur mahasiswa sebelum diurutkan:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(ages[i] + " ");
        }
          // Selection sort
        for (int i = 0; i < 10 - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < 10; j++)
            {
                if (ages[j] < ages[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = ages[minIndex];
            ages[minIndex] = ages[i];
            ages[i] = temp;
        }

        Console.WriteLine("\nData umur mahasiswa setelah diurutkan:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(ages[i] + " ");
        }
    }
}
        }
