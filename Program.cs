using System;
using System.Collections.Generic;
using System.Globalization;

namespace Milyoner
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string userAnswer, name, surname;
            int false_ = 0, true_ = 0, empty = 0, money = 0;
            #endregion   
            #region FirstScreen
            Console.Title = "Millionaire";
            Console.SetWindowSize(75, 14);
            Console.WriteLine("\n\n\tWelcome to Who Wants To Be A Millionaire");
            Console.Write("\n\tYour Name: ");
            name = Console.ReadLine();
            Console.Write("\n\tYour Surname: ");
            surname = Console.ReadLine();
            Console.Write("\n\tLet's Start...");
            Console.ReadLine();
            #endregion
            #region QuestionBank
            var questions = new List<QuestionBank>()
            {
                new QuestionBank("Which is different?","CS","CSS","JS","CPP","B"),
                new QuestionBank("Which is the largest continent?","Antarctica","Europe","Africa","Asia","D"),
                new QuestionBank("What or who is Electronic Arts?","Animation Studio","Phone Brand","Game Company","Society","C"),
                new QuestionBank("At what age did Einstein die?","76","65","81","79","A"),
                new QuestionBank("In what year did World War II start?","1938","1939","1940","1941","B"),
                new QuestionBank("What is the world men's long jump record?","5,16","6,12","7,52","8,95","D"),
                new QuestionBank("Who is the famous author of the book 'A Clockwork Orange'?","Anthony Burgess","Fyodor Dostoyevski","George Orwell","Gabriel Marquez","A"),
                new QuestionBank("What is the name of the bond that connects opposite nucleotides in DNA?","Ester","Weak Hydrogen","Glycoside","Phosphoester","B"),
                new QuestionBank("What are the building blocks of proteins?","Glycerine","Glucose","Glycerol","Amino Acid","D"),
                new QuestionBank("What is the process of water sticking to its own molecules called?","Adhesion","Surface Tension","Cohesion","Fluid Pressure","C")
            };
            #endregion
            #region QuestionScreen
            for (int z = 10, i = 0; i < 5; i++)
            {
                Console.Clear();
                Random j = new Random();
                int r = j.Next(z);
                Console.WriteLine(questions[r]);
                Console.Write("\n   Answer: ");
                userAnswer = Console.ReadLine();
                Console.WriteLine();
                if (userAnswer.ToUpper() == questions[r].Answer)
                {
                    true_++; money = money + 1000; Console.WriteLine("\n   + Congrats Right Answer :D");
                }
                else if (userAnswer=="")
                {
                    empty++; Console.WriteLine("\n   | Hmmmm :");
                }
                else
                {
                    false_++; Console.WriteLine("\n   - Unfortunately Wrong Answer :|");
                }
                Console.Write("\n   Continue...");
                questions.Remove(questions[r]);
                z--;
                Console.ReadKey();
            }
            #endregion
            #region LastScreen
            Console.Clear();
            Console.Write($"\n  Congratulations   " +
                $"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name)} " +
                $"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(surname)}  " +
                $"You Earned " +
                $"{money}£ " +
                $"\n\n  Statistics: {true_} True  {false_} False  {empty} Empty\n\n  Exit...");
            Console.ReadLine();
            #endregion 
        }
    }
    class QuestionBank
    {
        #region Props
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }
        #endregion

        public QuestionBank(string question, string optionA, string optionB, string optionC, string optionD, string answer)
        {
            Question = question;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            OptionD = optionD;
            Answer = answer;
        }

        public override string ToString()
        {
            return $"\n  {Question}\n\n   A-{OptionA}\tB-{OptionB}\n   C-{OptionC}\tD-{OptionD}";
        }
    }
}
