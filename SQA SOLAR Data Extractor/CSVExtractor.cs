using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_SOLAR_Data_Extractor
{
    public class CSVExtractor
    {
        public static string[,] ReadCsvFile(string filePath)
        {
            // Read all lines of the file
            string[] lines = File.ReadAllLines(filePath);

            // Get the number of rows and columns
            int rows = lines.Length;
            int cols = lines[0].Split(',').Length;

            // Initialize the 2D array
            string[,] csvData = new string[rows, cols];

            // Populate the 2D array with CSV data
            for (int i = 0; i < rows; i++)
            {
                string[] lineData = lines[i].Split(',');
                for (int j = 0; j < cols; j++)
                {
                    csvData[i, j] = lineData[j];
                }
            }

            return csvData;
        }
    }
}
