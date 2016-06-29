using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Domain.Models
{
    class ExportDataFromDictionary
    {
        public void ExportData(string path = "C:\\Users\\Andrii\\Documents\\Visual Studio 2013\\Projects\\WebSite1\\Domain.Models\\Частотний словник іменників.txt")
        {
            StreamReader file = new StreamReader(path);
            string readedLine;
           string []splitedString;
           byte indexWordInSplitString = 1;
            Word word=new Word();
          using(IsterikaGameDBEntities _db=new IsterikaGameDBEntities())
          {
              int count = 0;
              int limitOfWords = 1000;
              while ((readedLine=file.ReadLine())!=null)
              {
                  count++;
                  // to control if all work right but not to all db
                  if (count > limitOfWords)
                  {
                      splitedString = readedLine.Split('{', ',');
                      word.Word1 = splitedString[indexWordInSplitString];
                      _db.Words.Add(word);
                      _db.SaveChanges();
                  }
              }
              file.Close();
          }
            
        }

        static void Main()
        {
 
        }
    }
}
