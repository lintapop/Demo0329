using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo0329
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //string

            #region 輸入姓名，輸出 Hi~輸入的姓名

            /*

            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi~{name}");

            // */

            #endregion 輸入姓名，輸出 Hi~輸入的姓名

            #region 請輸入任何一個字，是否出現在”Lost time is never found again.”這個字串裡

            /*

            string sentence = "Lost time is never found again.";
            Console.WriteLine("enter a word");
            string word = Console.ReadLine();
            Console.WriteLine(sentence.Contains(word));

            // */

            #endregion 請輸入任何一個字，是否出現在”Lost time is never found again.”這個字串裡

            #region 輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e

            /*

            Console.WriteLine("enter a word");
            string word = Console.ReadLine();
            string result = "";
            //string result = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                result += word[i] + "-";
            }
            Console.WriteLine(result.Trim('-'));

            // */

            #endregion 輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e

            #region 輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg

            /*

            Console.WriteLine("enter a filename and its type, for example: apple.jpg");
            string filename = Console.ReadLine();
            var extension = filename.Split('.');
            //string[] extension = filename.Split('.');
            Console.WriteLine(extension[1]);
            Console.WriteLine(extension[extension.Length - 1]);

            //使用字串陣列

            // */

            #endregion 輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg

            #region 輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字

            /*

            Console.WriteLine("enter a word");
            string word = Console.ReadLine();
            if (word.Length < 5)
            {
                Console.WriteLine("insufficient length");
            }
            else
            {
                Console.WriteLine(word.Substring(0, 3));
            }
            // */

            #endregion 輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字

            #region 輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌

            /*

            string sentence = "I am singing";
            Console.WriteLine(sentence.Replace("I am ", "Ann is "));
            // */

            #endregion 輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌

            #region 輸入一串字，顯示輸入幾個字

            /*

            Console.WriteLine("enter a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence.Length);
            // */

            #endregion 輸入一串字，顯示輸入幾個字

            //File

            #region Read&Write

            /*

            /*寫一篇中文歌的歌詞到到自己指定的文字檔
             * Using System.IO;
             * (使用UTF - 8編碼)
             * 讀取1.txt 顯示在畫面上。

            string sample = @"C:\Users\Linting\Desktop\sample.txt";
            string lyrics = "They say oh my god I see the way you shine\n" +
"Take your hand, my dear, and place them both in mine\n" +
"You know you stopped me dead while I was passing by\n" +
"And now I beg to see you dance just one more time";

            File.WriteAllText(sample, lyrics, Encoding.UTF8);
            //File.AppendAllText(sample, lyrics);

            Console.WriteLine(File.ReadAllText(sample));

            // */

            #endregion Read&Write

            #region 請隨機由0~99產生一個數字輸出

            /*

            Random num = new Random();
            Console.WriteLine(num.Next(0, 99));

            // */

            #endregion 請隨機由0~99產生一個數字輸出

            #region 請隨機由0~99產生10個數字輸出

            /*

            Random num = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num.Next(0, 99));
            }
            // */

            #endregion 請隨機由0~99產生10個數字輸出

            #region 隨機幫每位學員產生成績，並寫入文字檔

            /*

            //欄位之間用，分開，換行寫入下一筆)
            string sample = @"C:\Users\Linting\Desktop\sample.txt";
            string[] students = new string[4] { "Ann", "Yiwen", "Tissue", "Ulysses" };
            Random score = new Random();
            string result = "";
            for (int i = 0; i < students.Length; i++)
            {
                result += students[i] + ", " + score.Next(80, 100) + "\n";
                File.WriteAllText(sample, result);
            }
            Console.WriteLine(result);

            // */

            #endregion 隨機幫每位學員產生成績，並寫入文字檔

            //DateTime

            #region 顯示現在日期與時間

            /*

            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            // */

            #endregion 顯示現在日期與時間

            #region 顯示再過30天為哪一天

            /*

            DateTime after30Days = DateTime.Now.AddDays(30);
            Console.WriteLine(after30Days);
            // */

            #endregion 顯示再過30天為哪一天

            #region 顯示24小時前的年月日時分秒

            /*

            DateTime before24Hours = DateTime.Now.AddHours(-24);
            Console.WriteLine(before24Hours);
            //ToString()

            // */

            #endregion 顯示24小時前的年月日時分秒

            #region 取得目前是幾月

            /*

            DateTime month = DateTime.Now;
            Console.WriteLine(month.ToString("MM"));
                        // */

            #endregion 取得目前是幾月

            #region 取得明年是否為閏年。/*

            //西元年份除以4可整除，且除以100不可整除，為閏年。
            //西元年份除以400可整除，為閏年。
            //DateTime轉型成string再轉成int
            //DateTime.IsLeapYear();
            //GetType()

            //DateTime year = DateTime.Now.AddYears(1);
            //int nextY = Convert.ToInt32(year.ToString("yyyy"));
            //bool isLeapYear;
            //if (nextY % 400 == 0 || nextY % 4 == 0 && nextY % 100 != 0)
            //{
            //    isLeapYear = true;
            //}
            //else
            //{
            //    isLeapYear = false;
            //}
            //Console.WriteLine(isLeapYear);

            //check the year2000
            //DateTime year = DateTime.Now.AddYears(-21);
            ////int nextY = Convert.ToInt32(year.ToString("yyyy"));
            //int nextY = 2000;
            //bool isLeapYear;
            //if (nextY % 400 == 0 || nextY % 4 == 0 && nextY % 100 != 0)
            //{
            //    isLeapYear = true;
            //}
            //else
            //{
            //    isLeapYear = false;
            //}
            //Console.WriteLine(isLeapYear);
            //Console.WriteLine(DateTime.IsLeapYear(2000));
            // */

            #endregion 取得明年是否為閏年。/*

            #region 取得離2022年1月1日還有幾天。

            /*

            //自定義一個目標時間
            //宣告現在時間
            //TimeSpan
            DateTime nextY = new DateTime(2022, 01, 01);
            DateTime currentY = DateTime.Now;
            TimeSpan days = nextY - currentY;
            Console.WriteLine(days.ToString("dd"));

            // */

            #endregion 取得離2022年1月1日還有幾天。
        }
    }
}