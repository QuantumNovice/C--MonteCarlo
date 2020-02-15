using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sco

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            
            for (var i=0; i<20; i++)
            {
                var val = random.Next(1, 6);
                Console.WriteLine("> " + val);
            }

            double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            double[] dataY = new double[] { 1, 4, 9, 16, 25 };
            wpfPlot1.plt.PlotScatter(dataX, dataY);
            formsPlot1.Render();

            Console.ReadLine();

        }
    }
}
