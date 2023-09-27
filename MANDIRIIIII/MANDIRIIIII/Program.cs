// Nama : Dea Novela Ramadani
// NIM : 222410101016

using System;

namespace ModulMandiri
{
    public class Vga
    {
        public string Merk { get; set; }
    }

    public class Nvidia : Vga
    {
        public Nvidia()
        {
            Merk = "Nvidia";
        }
    }

    public class AMD_Vga : Vga
    {
        public AMD_Vga()
        {
            Merk = "AMD";
        }
    }

    public class Processor
    {
        public string Merk { get; set; }
        public string Tipe { get; set; }
    }

    public class Intel : Processor
    {
        public Intel()
        {
            Merk = "Intel";
        }
    }

    public class CoreI3 : Intel
    {
        public CoreI3()
        {
            Tipe = "CoreI3";
        }
    }

    public class CoreI5 : Intel
    {
        public CoreI5()
        {
            Tipe = "CoreI5";
        }
    }

    public class CoreI7 : Intel
    {
        public CoreI7()
        {
            Tipe = "CoreI7";
        }
    }

    public class AMD_Processor : Processor
    {
        public AMD_Processor()
        {
            Merk = "AMD";
        }
    }

    public class Ryzen : AMD_Processor
    {
        public Ryzen()
        {
            Tipe = "Ryzen";
        }
    }

    public class Athlon : AMD_Processor
    {
        public Athlon()
        {
            Tipe = "Athlon";
        }
    }

    public class Laptop
    {
        public string Merk { get; set; }
        public string Tipe { get; set; }
        public Vga vga { get; set; }
        public Processor processor { get; set; }

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} sedang menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} sedang mematikan");
        }
    }

    public class Asus : Laptop
    {
        public Asus()
        {
            Merk = "Asus";
        }
    }

    public class ROG : Asus
    {
        public ROG()
        {
            Merk = "ROG";
        }
    }

    public class Vivobook : Asus
    {
        public Vivobook()
        {
            Merk = "Vivobook";
        }

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!");
        }
    }

    public class Acer : Laptop
    {
        public Acer()
        {
            Merk = "Acer";
        }
    }

    public class Swift : Acer
    {
        public Swift()
        {
            Merk = "Swift";
        }
    }

    public class Predator : Acer
    {
        public Predator()
        {
            Tipe = "Predator";
        }

        public void BermainGame()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} sedang bermain game");
        }
    }

    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            Merk = "Lenovo";
        }
    }

    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            Merk = "IdeaPad";
        }
    }

    public class Legion : Lenovo
    {
        public Legion()
        {
            Tipe = "Legion";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();

            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new AMD_Vga();
            laptop2.processor = new CoreI7();

            Predator predator = new Predator();
            predator.vga = new AMD_Vga();
            predator.processor = new CoreI7();

            Console.WriteLine("============= SOAL 1 =============");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            Console.WriteLine("============= SOAL 2 =============");
            //laptop1.Ngoding(); // Ngoding method tidak ada di kelas Laptop

            Console.WriteLine("============= SOAL 3 =============");
            Console.WriteLine($"Merk Vga : {laptop1.vga.Merk}");
            Console.WriteLine($"Merk Processor : {laptop1.processor.Merk}");
            Console.WriteLine($"Tipe Processor : {laptop1.processor.Tipe}");

            Console.WriteLine("============= SOAL 4 =============");
            Acer acer = new Predator();
            //acer.BermainGame(); // Metode BermainGame hanya ada di kelas Predator

            Console.WriteLine("============= SOAL 5 =============");
            predator.BermainGame();
           
        }
    }
}