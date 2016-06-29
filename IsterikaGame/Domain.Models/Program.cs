using System;
using System.Text;

namespace Domain.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            ExportDataFromDictionary exportData = new ExportDataFromDictionary();
            exportData.ExportData();
        }
    }
}
