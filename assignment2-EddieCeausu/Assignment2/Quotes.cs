using System;
using System.IO;
using System.Text;

namespace Assignment2
{
    public class Quotes
    {
      String[] quotes;
      int lineCount;
        public Quotes()
        {
            StreamReader sr = File.OpenText("quotes.txt");
            lineCount = File.ReadAllLines("quotes.txt").Length;
            quotes = new string[lineCount];

            for (int i = 0; i < lineCount; i++)
                quotes[i] = sr.ReadLine();
          
            sr.Close();
        }
        public String getQuote() {
          return quotes[new Random().Next(0, lineCount)];
        }
    }
}
