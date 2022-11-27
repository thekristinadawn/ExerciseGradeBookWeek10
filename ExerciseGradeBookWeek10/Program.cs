using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseGradeBookWeek10
{
    internal class Program
    {
        private static decimal overallMortyAvg;
        private static decimal overallCharlieAvg;
        private static decimal overallOpieAvg;

        public static void Main()
        {
            //functions-methods

            //You should catch and display a user-friendly error message for any exceptions that are thrown when performing operations using Dictionaries and Lists (e.g. adding a key that already exists).
            //You should be displaying a user-friendly message for each operation (e.g. "Morty's average score for quizzes was 80.7 (B)").

            //Declare 3 dictionaries using IDictionary: Morty, Charlie, Opie
            //Keys: name,homework,quizzes and tests

            IDictionary<string, List<decimal>> Morty = new Dictionary<string, List<decimal>>();
            List<decimal> MortyHomework = new List<decimal>() { 100, 88.3m, 76.3m, 99.1m };
            List<decimal> MortyQuizzes = new List<decimal>() { 66.4m, 54.3m, 82.4m, 76.5m };
            List<decimal> MortyTests = new List<decimal>() { 62.2m, 88.1m, 92.1m, 73.5m };


            Morty["Homework"] = MortyHomework;
            Morty["Quizzes"] = MortyQuizzes;
            Morty["Tests"] = MortyTests;

            //Charlie 
            IDictionary<string, List<decimal>> Charlie = new Dictionary<string, List<decimal>>();
            List<decimal> CharlieHomework = new List<decimal>() { 89.2m, 90.3m, 97.1m, 91.0m };
            List<decimal> CharlieQuizzes = new List<decimal>() { 99.2m, 99.7m, 94.2m, 90.6m };
            List<decimal> CharlieTests = new List<decimal>() { 100.0m, 89.9m, 95.8m, 92.9m };

            Charlie["Homework"] = CharlieHomework;
            Charlie["Quizzes"] = CharlieQuizzes;
            Charlie["Tests"] = CharlieTests;

            //Opie 
            IDictionary<string, List<decimal>> Opie = new Dictionary<string, List<decimal>>();
            List<decimal> OpieHomework = new List<decimal>() { 86.7m, 91.7m, 82.5m, 81.3m };
            List<decimal> OpieQuizzes = new List<decimal>() { 96.2m, 95.1m, 84.3m, 79.8m };
            List<decimal> OpieTests = new List<decimal>() { 67.1m, 78.4m, 89.5m, 82.1m };

            Opie["Homework"] = OpieHomework;
            Opie["Quizzes"] = OpieQuizzes;
            Opie["Tests"] = OpieTests;

            //create List of students assigning students in Student class
            var students = new List<Student>() {
                new Student(){ id = 1, name="Morty"},
                new Student(){ id = 2, name="Charlie"},
                new Student(){ id = 3, name="Opie"},
            };

            PrintStudentInfo();

            void PrintStudentInfo()
            {

                Console.WriteLine("Morty: ");
                foreach (String key in Morty.Keys)
                {
                    Console.Write("{0} :", key);
                    foreach (Decimal item in Morty[key])
                    {  
                        Console.Write(" {0} ", item);
                    }

                }

                Console.WriteLine("Charlie: ");
                foreach (String key in Charlie.Keys)
                {
                    Console.Write("{0} :", key);
                    foreach (Decimal item in Charlie[key])
                    {
                        Console.Write(" {0} ", item);
                    }

                }

                Console.WriteLine("Opie: ");
                foreach (String key in Opie.Keys)
                {
                    Console.Write("{0} :", key);
                    foreach (Decimal item in Opie[key])
                    {
                        Console.Write(" {0} ", item);
                    }

                }
            }
            int countH = 4;
            CalculateAssignmentAverage();

            
            void CalculateAssignmentAverage()
            {
                var mortyHomeworkAvg = MortyHomework.Sum()/countH;
                var mortyQuizzesAvg = MortyQuizzes.Sum()/countH;
                var mortyTestsAvg = MortyTests.Sum()/countH;

                Console.WriteLine("Morty Avg Homework Score: {0}", mortyHomeworkAvg);
                Console.WriteLine("Morty Avg Quiz Score: {0}", mortyQuizzesAvg);
                Console.WriteLine("Morty Avg Tests Score: {0}", mortyTestsAvg);

                var charlieHomeworkAvg = CharlieHomework.Sum() / countH;
                var charlieQuizzesAvg = CharlieQuizzes.Sum() / countH;
                var charlieTestsAvg = CharlieTests.Sum() / countH;

                Console.WriteLine("Charlie Avg Homework Score: {0}", charlieHomeworkAvg);
                Console.WriteLine("Charlie Avg Quiz Score: {0}", charlieQuizzesAvg);
                Console.WriteLine("Charlie Avg Tests Score: {0}", charlieTestsAvg);

                var opieHomeworkAvg = OpieHomework.Sum() / countH;
                var opieQuizzesAvg = OpieQuizzes.Sum() / countH;
                var opieTestsAvg = OpieTests.Sum() / countH;

                Console.WriteLine("Opie Avg Homework Score: {0}", opieHomeworkAvg);
                Console.WriteLine("Opie Avg Quiz Score: {0}", opieQuizzesAvg);
                Console.WriteLine("Opie Avg Tests Score: {0}", opieTestsAvg);

            }

            CalculateClassAverage();

            void CalculateClassAverage()
            {
                overallMortyAvg = (MortyHomework.Sum() + MortyQuizzes.Sum() + MortyTests.Sum())/12;
                Console.WriteLine("Morty Avg Score: {0}", overallMortyAvg);

                overallCharlieAvg = (CharlieHomework.Sum() + CharlieQuizzes.Sum() + CharlieTests.Sum())/12;
                Console.WriteLine("Charlie Avg Score: {0}", overallCharlieAvg);

                overallOpieAvg = (OpieHomework.Sum() + OpieQuizzes.Sum() + OpieTests.Sum())/12;
                Console.WriteLine("Opie Avg Score: {0}", overallOpieAvg);
            }

            //void GetLetterGrade(decimal score)
        }
    }
}
