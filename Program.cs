using Converter.classes;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(descBalance));
            //Console.Write("Введите путь к Excel файлу: ");
            //string path = Console.ReadLine();
            ExcelToObject obj = new ExcelToObject(@"D:\test.xlsx");
            descBalance descBalance = obj.get_list();
            using (FileStream fs = new FileStream("descBalance.xml", FileMode.OpenOrCreate))
            { 
                xmlSerializer.Serialize(fs, descBalance);
            }
            Console.WriteLine("XML файл создан!");
            Console.ReadKey();
        }
    }
}
