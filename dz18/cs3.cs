using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace dz18
{
    class Device
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }

        public Device(string name, string manufacturer, decimal price)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Manufacturer} {Name} - {Price}";
        }
    }

    class DeviceComparer : IEqualityComparer<Device>
    {
        public bool Equals(Device x, Device y)
        {
            return x.Manufacturer == y.Manufacturer;
        }

        public int GetHashCode(Device obj)
        {
            return obj.Manufacturer.GetHashCode();
        }
    }
    internal class cs3
    {
        public static void task_3()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Device[] devices1 = 
            {
                new Device("Телефон", "Apple", 1000),
                new Device("Ноутбук", "Lenovo", 1500),
                new Device("Телевізор", "Samsung", 2000)
            };

            Device[] devices2 = 
            {
                new Device("Телефон", "Samsung", 900),
                new Device("Ноутбук", "Apple", 1800),
                new Device("Монітор", "LG", 500)
            };

            Console.WriteLine("---------Task 3---------");

            //Виведення першого масиву з пристроями
            Console.WriteLine("Device array 1:");
            foreach (Device device in devices1)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine();

            //Виведення другого масиву з пристроями
            Console.WriteLine("Device array 2:");
            foreach (Device device in devices2)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine();

            // Різниця масивів за виробником
            var difference = devices1.Except(devices2, new DeviceComparer());
            Console.WriteLine("Різниця масивів:");
            foreach (var device in difference)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine();

            // Перетин масивів за виробником
            var intersection = devices1.Intersect(devices2, new DeviceComparer());
            Console.WriteLine("\nПеретин масивів:");
            foreach (Device device in intersection)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine();

            // Об'єднання масивів за виробником
            var union = devices1.Union(devices2, new DeviceComparer());
            Console.WriteLine("\nОб'єднання масивів:");
            foreach (var device in union)
            {
                Console.WriteLine(device);
            }
        }
    }
}
