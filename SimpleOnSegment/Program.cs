using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleOnSegment
{

    internal class Program
    {
        private static bool isSimple(int N)
        {
            
            for (int i = 2; i <= (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2015\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2015\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            int toppoint = Convert.ToInt32(File.ReadAllText(inputpath));



            int[] arr = new int[toppoint];
            string output = "";
            for (int i = 2; i < toppoint; i++)
            {

                if (isSimple(i))
                {
                    output += ' ' + i.ToString();
                }
            }
            File.WriteAllText(outputpath, output);



        }
    }
}