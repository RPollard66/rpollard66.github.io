using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLabs.DTOs.Level4;


namespace AppLabs.Operations.Level4
{
    public class WordManager
    {

        WordRepo word = new WordRepo();

        public string FormatOutput(NumberPlaces model)
        {
            int t = (int)model.Tens;
            int n = (int)model.Ones;
            int h = (int)model.Huns;

            string HundredsWord = "", TensWord = "", OnesWord = "";

            if (h != 0)
                HundredsWord = (word.BasicWords[h] + "-hundred, ");

            if (t == 0 && n != 0)
            {
                TensWord = "";
                OnesWord = word.BasicWords[n];
            }

            if (t > 1 && t < 10)
            {
                TensWord = word.EndsInYWords[t];
                OnesWord = word.BasicWords[n];
            }

            if (t == 1)
            {
                TensWord = word.TeenWords[n];
                OnesWord = "";
            }

            return HundredsWord + " " + TensWord + " " + OnesWord;
        }

        public NumberPlaces SplitNumber(double req)
        {
            
            var result = new NumberPlaces();

            result.Huns = Math.Floor(req / 100);

            double twoDigits = Math.Floor(req - result.Huns * 100);

            result.Tens = Math.Floor(twoDigits / 10);
            result.Ones = Math.Floor(req - result.Huns * 100 - result.Tens * 10);

            return result;
        }

    }
}
