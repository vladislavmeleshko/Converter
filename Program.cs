﻿using Converter.classes;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Converter
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(descBalance));
            string path = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            else
            { 
                path = openFileDialog.FileName;
                ExcelToObject obj = new ExcelToObject(path);
                descBalance descBalance = obj.get_list();
                using (FileStream fs = new FileStream("descBalance.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, descBalance);
                }
                Console.WriteLine("Файл XML создан успешно!");
                Console.ReadKey();
            }
        }
    }
}
