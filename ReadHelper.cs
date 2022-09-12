
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
     class ReadHelper
    {
        private string _fileName = "products.csv";
        public ReadHelper() { }

        public IEnumerable<string[]> ReadCsv()
        {
            var lines = File.ReadAllLines(getPath(this._fileName), Encoding.Default).Select(a => a.Split(';', '"'));
            var csv = from line in lines
                      select (from piece in line
                              select piece).ToArray();
            return csv;
        }

        public string getPath(string filenName)
        {
            return Path.GetFullPath(filenName);
        }

        internal void addProduct(object book)
        {
            string str = book.ToString();
           File.AppendAllText(this._fileName, str);
        }

        internal void removeItem(int id)
        {
            var lines = ReadCsv().ToList();
            lines.Remove(lines.FirstOrDefault(x => x[0] == id.ToString()));
        }
    }
  
}
