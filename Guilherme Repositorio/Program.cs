using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int cdg, qtdd;

        string[] item = Console.ReadLine().Split(' ');
        cdg = int.Parse(item[0]);
        qtdd = int.Parse(item[1]);
        double cq = 4.00;
        double xs = 4.50;
        double xb = 5.00;
        double ts = 2.00;
        double r = 1.50;

        if (cdg == 1)
        {
            Console.WriteLine("Total: R$ " + (qtdd * cq).ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (cdg == 2)
        {
            Console.WriteLine("Total: R$ " + (qtdd * xs).ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (cdg == 3)
        {
            Console.WriteLine("Total: R$ " + (qtdd * xb).ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (cdg == 4)
        {
            Console.WriteLine("Total: R$ " + (qtdd * ts).ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (cdg == 5)
        {
            Console.WriteLine("Total: R$ " + (qtdd * r).ToString("F2", CultureInfo.InvariantCulture));
        }

    }

}
