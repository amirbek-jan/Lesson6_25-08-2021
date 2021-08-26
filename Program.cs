using System;

namespace Lesson6ConsoleApp
{
    class Computer 
    {
        public int ram;
        public string model;
        public string cpu;
        public int storage;
        public int screenDiagonal;
        public void GetInfo() {
            Console.WriteLine($"{ram}, {model}, {cpu}, {storage}, {screenDiagonal}");
        }
        public Computer(int ram, string model, string cpu, int storage, int screenDiagonal) {
            this.ram = ram;
            this.model = model;
            this.cpu = cpu;
            this.storage = storage;
            this.screenDiagonal = screenDiagonal;
        }
        public void AddStorage(int newStorage) {
            this.storage += newStorage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Computer myPC = new Computer(8, "Samsung", "i5", 256, 42);
           myPC.GetInfo();
        }
    }
}
