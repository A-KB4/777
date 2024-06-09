using System;
using System.Collections.Generic;
using System.IO;

namespace lab_7
{
    class Program
    {
        static List<Comp> comps;

        static void Main(string[] args)
        {
            comps = new List<Comp>();

            // Читання з файлу і додавання комп'ютерів в список comps
            FileStream fs = new FileStream("Comp.comps", FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);
            try
            {
                Console.WriteLine("Зчитування даних з файлу...\n");
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    Comp comp = new Comp();
                    comp.Name = reader.ReadString();
                    comp.Os = reader.ReadString();
                    comp.Virob = reader.ReadString();
                    comp.Proc = reader.ReadInt32();
                    comp.Bios = reader.ReadDouble();
                    comp.OperMemory = reader.ReadDouble();
                    comp.Inch = reader.ReadBoolean();
                    comp.Overclocking = reader.ReadBoolean();

                    comps.Add(comp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталася помилка: {0}", ex.Message);
            }
            finally
            {
                reader.Close();
            }

            // Виведення списку комп'ютерів на екран
            Console.WriteLine("Кількість комп'ютерів: {0}", comps.Count);
            foreach (var comp in comps)
            {
                Console.WriteLine(comp.Info());
            }

            // Затримка перед завершенням програми
            Console.ReadKey();
        }
    }
}
