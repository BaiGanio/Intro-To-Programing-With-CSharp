using System;
using System.Data;
using System.IO;
using System.Text;

namespace ProjectHelpers
{
    class ReadFromOneFileWriteInAnother
    {
        private const string path =
            @"C:\Users\Republic Of Gamers\OneDrive\Plovdiv University\Intro to programming course\Увод в програмирането C# 2016-2017\Fake files\Towns-with-data.txt";
        private const string outputPath =
            @"C:\Users\Republic Of Gamers\OneDrive\Plovdiv University\Intro to programming course\Увод в програмирането C# 2016-2017\Fake files\Town-names.txt";
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //CallWriter();
            //CallEGNDemo();
            //CallTask1();
            CallFor3ka();
        }

        #region MyRegion

        private static void CallFor3ka()
        {
            string a = "Чоко и Боко";
            int[] numbers = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                char j = a[i];
                numbers[i] = (int)j;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            //int[] numbers = { 72, 101, 108, 108, 111 };
           // Console.WriteLine((int)'!');
            //int[] numbers = {1052, 1072, 1088, 1072, 32, 1074, 1072, 44, 32, 1073, 1088, 1072, 1090, 1095, 1077, 1090, 1066, 33 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write((char)numbers[i]);
            }
            Console.WriteLine();

        }
        
        private static void CallTask1()
        {
            //Input
            int guestsCapacity = 28;
            int guestTicket = 210;
            int teachersCapacity = 22;
            int teacherTicket = 120;
            int studentsCapacity = 50;
            int studentTicket = 40;
            double currentPerformanceIncome = 0; // Събитие
            double frequentVisitiorDiscount = 0;
            double guestsMaxProfit = 0;
            double teachersMaxProfit = 0;
            double studentsMaxProfit = 0;
            
            for (int i = 0; i < 3; i++)
            {
                int currentAuditoryPersons = 0;
                int frequentAuditoryVisitors = 0;
                int bufet = 0;
                string[] currentAuditoryValues = Console.ReadLine().Split(' ');
                currentAuditoryPersons = int.Parse(currentAuditoryValues[0]);
                frequentAuditoryVisitors = int.Parse(currentAuditoryValues[1]);
                bufet = int.Parse(currentAuditoryValues[2]);

                Console.WriteLine("Current auditory visitors : {0}", currentAuditoryPersons);
                Console.WriteLine("Current visitors from category \"Picture of the wall!\" : {0}", frequentAuditoryVisitors);
                Console.WriteLine("Current visitors with hangover pay for \"Bufet\" : {0}", bufet);
              

                double bufetIncome = 0;
                double currentIncome = 0;

                switch (i)
                {
                    case 0:
                        frequentVisitiorDiscount = guestTicket*(70/100);
                        bufetIncome = guestTicket*(0.4/100);
                        currentIncome = ((currentAuditoryPersons - frequentAuditoryVisitors)*guestTicket) +
                                        (frequentAuditoryVisitors*(guestTicket - frequentVisitiorDiscount)) +
                                        (bufet*bufetIncome);
                        guestsMaxProfit = (guestsCapacity*guestTicket) + (guestsCapacity*bufetIncome);
                        break;
                    case 1:
                        frequentVisitiorDiscount = teacherTicket * (70 / 100);
                        bufetIncome = teacherTicket * (0.4 / 100);
                        currentIncome = ((currentAuditoryPersons - frequentAuditoryVisitors) * teacherTicket) +
                                        (frequentAuditoryVisitors * (teacherTicket - frequentVisitiorDiscount)) +
                                        (bufet * bufetIncome);
                        teachersMaxProfit = (teachersCapacity * teacherTicket) + (teachersCapacity * bufetIncome);
                        break;
                    case 2:
                        frequentVisitiorDiscount = studentTicket * (70 / 100);
                        bufetIncome = studentTicket * (0.4 / 100);
                        currentIncome = ((currentAuditoryPersons - frequentAuditoryVisitors) * studentTicket) +
                                        (frequentAuditoryVisitors * (studentTicket - frequentVisitiorDiscount)) +
                                        (bufet * bufetIncome);
                        studentsMaxProfit = (studentsCapacity * studentTicket) + (studentsCapacity * bufetIncome);
                        break;
                    default:
                        Console.WriteLine("WRONG DATA!!!");
                        break;
                }

                Console.WriteLine("Current auditory visitors income: ${0:F2}", currentIncome);
                currentPerformanceIncome += currentIncome;
                Console.WriteLine("------------------------------------------");
            }

            //Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\"Guests of the city\" max profit : ${0:F2}", guestsMaxProfit);
            Console.WriteLine("\"Teachers\" max profit : ${0:F2}", teachersMaxProfit);
            Console.WriteLine("\"Students\" max profit : ${0:F2}", studentsMaxProfit);
            Console.WriteLine("Current event income : ${0:F2}", currentPerformanceIncome);
            //Console.WriteLine("-------------------------------------------");

            double maxProfit = guestsMaxProfit + teachersMaxProfit + studentsMaxProfit; 
            Console.WriteLine("Maximum profit for event : ${0:F2}", maxProfit);
            Console.WriteLine("Difference : ${0:F2}", maxProfit - currentPerformanceIncome);

        }
        private static void CallEGNDemo()
        {
            long[] myEGNs = { 8406194582, 7524169268, 7501010010, 7552010005, 8032056031, 8001010008, 7552011038 };
            //long myEGNs = 8406194582;
            //Console.Write("Enter 10 digits for EGN: ");
            try
            {
                //long myEGN = long.Parse(Console.ReadLine());
                foreach (long myEGN in myEGNs)
                {
                    string egn = myEGN.ToString();
                    int[] digits = new int[egn.Length];

                    #region DoSomeShits
                    Console.Write("EGN: ");
                    for (int i = 0; i < egn.Length; i++)
                    {
                        char digit = Convert.ToChar(egn[i]);
                        char zero = '0';
                        digits[i] = (int)digit - (int)zero;
                        Console.Write(digits[i]);
                    }
                    Console.WriteLine();
                    #endregion

                    /* Extract Years, Months & Days */
                    int year = digits[0] * 10 + digits[1];
                    int month = digits[2] * 10 + digits[3];
                    int day = digits[4] * 10 + digits[5];
                    bool male = digits[8]%2 == 0;
                    int controlNumber = (digits[0]*2) + (digits[1]*4) + (digits[2]*8) + (digits[3]*5) + (digits[4]*10) + (digits[5]*9) + (digits[6]*7) + (digits[7]*3) + (digits[8]*6);
                    controlNumber = controlNumber%11;
                    if (controlNumber == 10)
                    {
                        controlNumber = 0;
                    }
                    if (male)
                    {
                        
                    }

                    Console.WriteLine("| Year {0} | Month {1} | Day {2} |", year, month, day);
                    string[] newData = DealMonthData(month, year, day);
                    year = int.Parse(newData[0]);
                    month = int.Parse(newData[1]);
                    day = int.Parse(newData[2]);
                    //Console.WriteLine(year);
                    //Console.WriteLine(month);
                    //Console.WriteLine(day);
                    int daysInMonth = CalculateDaysInMonth(year, month);

                    if (day < 1 && day > daysInMonth)
                    {
                        Console.WriteLine("Incorrect day. Некоректно въведен ден.");
                    }
                    Console.WriteLine("Control number = {0}", controlNumber%11);
                    if (controlNumber != digits[9])
                    {
                        Console.WriteLine("Incorrect control number. Некоректно контролно число.");
                    }

                    if (male)
                    {
                        Console.WriteLine("Man is born on {0}.{1}.{2}", day, month, year);
                    }
                    else
                    {
                        Console.WriteLine("Woman is born on {0}.{1}.{2}", day, month, year);
                    }


                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("INVALID DATA!!! НЕКОРЕКТНИ ДАННИ!!!");
                Console.WriteLine("Input string was not in a correct format. Входните данни не са в подходящия формат.");
            }
        }
        private static int CalculateDaysInMonth(int year, int month)
        {
            int days = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
            }
            return days;
        }
        private static string[] DealMonthData(int month, int year, int day)
        {
            string[] toBack = new string[3];
            /* Check if number is between January & December */
            if (month > 0 && month < 13)
            {
                year = 1900 + year;
            }
            else if (month > 20 && month < 33)
            {
                year = 1800 + year;
                month = month - 20;
            }
            else if (month > 40 && month < 53)
            {
                year = 2000 + year;
                month = month - 40;
            }
            else
            {
                Console.WriteLine("Invalid month data. Некоректно въведен месец.");
            }

            Console.WriteLine("| Year {0} | Month {1} | Day {2} |", year, month, day);

            Console.WriteLine("------------------------------");
            toBack[0] = year.ToString();
            toBack[1] = month.ToString();
            toBack[2] = day.ToString();
            return toBack;
        }
        #endregion
        private static void CallWriter()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                //Write2NewFile(path, outputPath);
                using (StreamReader reader = new StreamReader(outputPath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }

                Console.WriteLine("D@ne! New data sucessfully added to file.");
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("File no found!");
            }
            catch (IOException exception)
            {
                Console.WriteLine("Error: {0}.", exception);
            }
        }
        private static void Write2NewFile(string path, string outputFile)
        {
            //Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            StreamReader text = new StreamReader(path, Encoding.UTF8);
            StreamWriter newPath = new StreamWriter(outputFile, true, Encoding.UTF8);

            using (text)
            {
                using (newPath)
                {
                    string line = text.ReadLine();
                    while (line != null)
                    {
                        string[] townData = line.Split(' ');
                        string townName = string.Empty;
                        if (townData.Length > 5)
                        {
                            townName = townData[0] + " " + townData[1];
                        }
                        else
                        {
                            townName = townData[0];
                        }
                        newPath.WriteLine(townName);
                        line = text.ReadLine();
                    }
                }
            }
        }

    }
}
