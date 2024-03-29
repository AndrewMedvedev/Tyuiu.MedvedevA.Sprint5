﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvedevA.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            

            string outputFilePath = @"C:\DataSprint5\OutPutDataFileTask7V9.txt";
            string fileContent = File.ReadAllText(path);
            string result = new string(fileContent.Where(c => !(c >= 'A' && c <= 'Z')).ToArray());
            return result;
        }
    }
}
