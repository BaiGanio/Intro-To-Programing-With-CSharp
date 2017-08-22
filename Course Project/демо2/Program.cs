using System;

namespace демо2
{
    class Program
    {
        static void Main()
        {
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
                        frequentVisitiorDiscount = guestTicket * (70 / 100);
                        bufetIncome = guestTicket * (0.4 / 100);
                        currentIncome = ((currentAuditoryPersons - frequentAuditoryVisitors) * guestTicket) +
                                        (frequentAuditoryVisitors * (guestTicket - frequentVisitiorDiscount)) +
                                        (bufet * bufetIncome);
                        guestsMaxProfit = (guestsCapacity * guestTicket) + (guestsCapacity * bufetIncome);
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
            // йуст то тест 
        }
    }
}
