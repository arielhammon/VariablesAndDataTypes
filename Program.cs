using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        public struct StudentProgressReport
        {
            public string CourseName;
            public int PageNum;
            public bool NeedsHelp;
            public string PositiveExperiences;
            public string Feedback;
            public double HoursOfStudy;
        }
        static void Main(string[] args)
        {
            //this basic program asks a Tech Academy student for input on their study course

            //header lines
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine();

            //course question
            Console.Write("What course are you on?:  ");
            String strCourse = Console.ReadLine();

            //page question
            Console.Write("What page are you on?:  ");
            String strPage = "";
            int intPage = 0;
            int n = 0; //the number of times the user has entered unrecognized values
            bool validEntry = false; //used to repeat opportunities to enter valid data
            while (!validEntry & n < 3)
            {
                strPage = Console.ReadLine();
                if (int.TryParse(strPage, out intPage))
                {
                    validEntry = true;
                }
                else
                {
                    n++;
                    if (n < 3)
                    {
                        Console.Write("Sorry, unrecognized entry. Please enter a whole number:  ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we'll record that as page number 1.");
                        intPage = 1;
                    }
                }
            }

            //help question
            Console.Write("Do you need help with anything? (yes/no):  ");
            String strHelp = "";
            bool boolHelp = true;
            n = 0;
            validEntry = false;
            while (!validEntry & n < 3)
            {
                strHelp = Console.ReadLine();
                strHelp = strHelp.ToLower();
                switch (strHelp)
                {
                    case "no":
                        boolHelp = false;
                        validEntry = true;
                        break;
                    case "yes":
                        boolHelp = true;
                        validEntry = true;
                        break;
                    default:
                        n++;
                        if (n < 3)
                        {
                            Console.Write("Sorry, unrecognized entry. Please enter either \"yes\" or \"no\":  ");
                        } else
                        {
                            Console.WriteLine("Sorry, we'll record that as a \"yes\".");
                        }
                        break;
                }
            }

            //positive experiences question
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            String strPosExperience = Console.ReadLine();

            //feedback question
            Console.WriteLine("Is there any other feedback you'd like to provide?: Please be specific.");
            String strFeedback = Console.ReadLine();

            //hours study question
            Console.Write("How many hours did you study today?:  ");
            String strHours = "";
            double dblHours = 0;
            n = 0; //the number of times the user has entered unrecognized values
            validEntry = false; //used to repeat opportunities to enter valid data
            while (!validEntry & n < 3)
            {
                strHours = Console.ReadLine();
                if (double.TryParse(strHours, out dblHours))
                {
                    validEntry = true;
                }
                else
                {
                    n++;
                    if (n < 3)
                    {
                        Console.Write("Sorry, unrecognized entry. Please enter a numeric value:  ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we'll record that as 0 hours for today.");
                        dblHours = 0;
                    }
                }
            }

            
            //fill struct for easy passing of results
            StudentProgressReport report = new StudentProgressReport
            {
                CourseName = strCourse,
                PageNum = intPage,
                NeedsHelp = boolHelp,
                PositiveExperiences = strPosExperience,
                Feedback = strFeedback,
                HoursOfStudy = dblHours
            };

            //print results and closing comment
            Console.WriteLine();
            Console.WriteLine("Here are the results of your survey:");
            Console.WriteLine("Course: " + report.CourseName);
            Console.WriteLine("Page Number: " + report.PageNum);
            Console.WriteLine("Needs Help: " + report.NeedsHelp);
            Console.WriteLine("Positive Experiences: " + report.PositiveExperiences);
            Console.WriteLine("Feedback: " + report.Feedback);
            Console.WriteLine("Hours of Study: " + report.HoursOfStudy);
            Console.WriteLine();
            Console.WriteLine("Thank-you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
