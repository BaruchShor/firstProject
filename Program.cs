using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
        internal class Program
        {

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
                    Console.WriteLine(option);
                }

            }

            static int userInput()
            {
                int choose = Convert.ToInt32(Console.ReadLine());
                return choose;
            }

            static void ElectionManager(int choice, string[] numSeries)
            {
                switch (choice)
                {
                    case 1:
                        changeSeries();
                        break;
                    case 2:
                    showSeries(numSeries);
                    break;
                    case 3:
                        showSeriesInRevers();
                        break;
                    case 4:
                        showSortSeries();
                        break;
                    case 5:
                        showMaxValue();
                        break;
                    case 7:
                        showMinValue();
                        break;
                    case 8:
                        showAverageSeries();
                        break;
                    case 9:
                        showNumValues();
                        break;
                    case 10:
                        showSumSeries();
                        break;
                }
            }

            static void DisplayingTheMenu()
            {
                string fff;
                do
                {
                    Menu();
                    fff = Console.ReadLine();
                }
                while (fff != "exit");
            }

            static string[] changeSeries()
            {
                string[] newSeries = new string[10];
                return newSeries;
            }

            static void showSeries(string[] numSeries)
            {
                foreach (string value in numSeries)
                {
                    Console.Write($" {value}");
                }
                Console.WriteLine();
            }

            static void showSeriesInRevers()
            {

            }

            static void showSortSeries()
            {

            }

            static void showMaxValue()
            {

            }

            static void showMinValue()
            {

            }

            static void showAverageSeries()
            {

            }

            static void showNumValues()
            {

            }

            static void showSumSeries()
            {

            }

            static bool Exit()
            {
                return true;
            }

            static void Main(string[] args)
            {
                DisplayingTheMenu();
            }
        }
}
