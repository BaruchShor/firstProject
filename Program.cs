using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    internal class Program
    {
        static void printToUser(object parameter)
        {
            Console.WriteLine(parameter);
        }

        static void Menu()
        {
            string[] menuList = {
            "Select your option by option ID.",
            "1 :Replace the current series",
            "2 :Show the series as is",
            "3 :Show the list in reverse order",
            "4 :Show the series in ascending order",
            "5 :Show the highest value in the series",
            "6 :Show the lowest value in the series",
            "7 :Show the series average",
            "8 :Show the number of values ​​in the series",
            "9 :Show the sum of the entire series",
            "10 :Exit the menu"
            };
            foreach (string option in menuList)
            {
                printToUser(option);
            }

        }

        static int userInput()
        {
            int choose;
            do
            {
                printToUser($"please enter a number of the menu.");
                choose = Convert.ToInt32(Console.ReadLine());
            } while (choose < 0 || choose > 10);
            return choose;
        }

        static void ElectionManager(int choice, int[] numSeries)
        {
            Dictionary<int, Func<int[], int[]>> menuDict = new Dictionary<int, Func<int[], int[]>>()
            {
                {3, showSeriesInRevers},
                {4, showSortSeries},
                {5, showMaxValue},
                {6, showMinValue},
                {7, showSeriesInRevers},
                {8, showNumValues},
                {9, showSumSeries},
            };
            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    showSeries(numSeries);
                    break;
                case 7:
                    Console.WriteLine(showAverageSeries(numSeries));
                    break;
                default:
                    showSeries(menuDict[choice](numSeries));
                    break;
            }
        }

        static void DisplayingTheMenu(string[] series)
        {
            int choose;
            do
            {
                choose = SeriesAnalyzer(series);
            }
            while (choose != 10);
        }

        static string[] changeSeries()
        {
            //function for user to enter his series.
            printToUser("please enter a corecct series.");
            string[] newSeries = Console.ReadLine().Split(' ');
            while (newSeries.Length < 3)
            {
                printToUser("The series is to short, please enter a corecct series.");
                newSeries = Console.ReadLine().Split(' ');
            };
            return newSeries;
        }

        static int[] arrayValidation(string[] usersArray)
        {
            //Validate the type of the series.
            int[] newIntList = new int[usersArray.Length];
            for (int i = 0; i < usersArray.Length; i++)
            {
                foreach (char num in usersArray[i])
                {
                    if (!char.IsDigit(num))
                    {
                        printToUser($"The value of value number {i} is incorrect pleas enter it again.");
                        usersArray[i] = Console.ReadLine();
                        i--;
                        break;
                    }
                }
                newIntList[i] = Convert.ToInt32(usersArray[i]);
            }
            return newIntList;
        }

        static int[] showSeries(int[] numSeries)
        {
            foreach (int value in numSeries)
            {
                Console.Write($" {value}");
            }
            printToUser("");
            return numSeries;
        }

        static int[] showSeriesInRevers(int[] series)
        {
            //Print the series in revers.
            int j = 0;
            int[] reversSeries = new int[series.Length];
            for (int i = series.Length - 1; i >= 0; i--)
            {
                reversSeries[j] = series[i];
                j++;
            }
            return reversSeries;
        }

        static int[] showSortSeries(int[] series)
        {
            Array.Sort(series);
            return series;
        }

        static int[] showMaxValue(int[] series)
        {
            int[] max = new int[1];
            max[0] = series[0];
            foreach (int num in series)
            {
                if (max[0] < num)
                {
                    max[0] = num;
                }
            }
            return max;
        }

        static int[] showMinValue(int[] series)
        {
            int[] min = new int[1];
            min[0] = series[0];
            foreach (int num in series)
            {
                if (min[0] > num)
                {
                    min[0] = num;
                }
            }
            return min;
        }

        static double showAverageSeries(int[] series)
        {
            int sum = showSumSeries(series)[0];
            return sum / series.Length;
        }

        static int[] showNumValues(int[] series)
        {
            int[] numVal = { series.Length };
            return numVal;
        }

        static int[] showSumSeries(int[] series)
        {
            //Sum the values of the series.
            int[] sum = new int[1];
            foreach (int num in series)
            {
                sum[0] += num;
            }
            return sum;
        }

        static int[] finalSeries(string[] argsSerier, int choose)
        {
            if (choose == 1)
            {
                int[] newSeries = arrayValidation(changeSeries());
                return newSeries;
            }
            return arrayValidation(argsSerier);
        }

        static int SeriesAnalyzer(string[] series)
        {
            int choose;
            Menu();
            choose = userInput();
            if (choose == 10)
            {
                return choose;
            }
            int[] seriesForAnilaiz = finalSeries(series, choose);
            ElectionManager(choose, seriesForAnilaiz);
            return choose;
        }

        static void Main(string[] args)
        {
            DisplayingTheMenu(args);
        }
    }
}