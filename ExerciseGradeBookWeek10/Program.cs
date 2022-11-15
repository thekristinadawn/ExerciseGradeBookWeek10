using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseGradeBookWeek10
{
    class Program
    {
        static void Main(string[] args)
        {
            //functions
            //PrintStudentInfo(IDictionary < string, List<decimal> student) for displaying the following information about a student: name, homework, quizzes, and tests(scores).
            //CalculateAssignmentAverage(string name, string assignment) that calculates the average for a student's assignments (e.g. the average score for Morty's quizzes).
            //CalculateClassAverage(List<IDictionary<string, List<decimal>> students) that takes in the list of students and calculates the average of each assignment per student and then calculates the average student score.
            //GetLetterGrade(decimal score) that takes in a student's score and converts it to a letter grade. 
            //(A): score >= 90; (B): score >= 80; (C): score >= 70; (D): score >= 60; (F): score < 60



            //You should catch and display a user-friendly error message for any exceptions that are thrown when performing operations using Dictionaries and Lists (e.g. adding a key that already exists).
            //You should be displaying a user-friendly message for each operation (e.g. "Morty's average score for quizzes was 80.7 (B)").



            decimal GetRandom()
            {
                Random rand = new Random();
                var item = new decimal(rand.NextDouble());
                return item;
            }
            Random rand1 = new Random();
            
            decimal randomScore = rand1.Next(0, 100);
            //Declare 3 dictionaries using IDictionary: Morty, Charlie, Opie
            //Keys: name,homework,quizzes and tests

            //Morty 
            IDictionary<string, List<decimal>> Morty = new Dictionary<string, List<decimal>>();

            List<decimal> Morty1 = new List<decimal>();
            Morty1.Add(GetRandom());
            

            List<decimal> Morty2 = new List<decimal>();
            Morty2.Add(GetRandom());

            List<decimal> Morty3 = new List<decimal>();
            Morty3.Add(GetRandom());

            List<decimal> Morty4 = new List<decimal>();
            Morty4.Add(GetRandom());

            Morty["name"] = Morty1;
            Morty["homework"] = Morty2;
            Morty["quizzes"] = Morty3;
            Morty["tests"] = Morty4;

            //Test
            foreach (string key in Morty.Keys)
            {
                foreach (decimal value in Morty[key])
                {
                    Console.WriteLine(value);
                }
            };


            //Charlie 
            IDictionary<string, List<decimal>> Charlie = new Dictionary<string, List<decimal>>();

            List<decimal> Charlie1 = new List<decimal>();
            Charlie1.Add(randomScore);

            List<decimal> Charlie2 = new List<decimal>();
            Charlie2.Add(randomScore);

            List<decimal> Charlie3 = new List<decimal>();
            Charlie3.Add(randomScore);

            List<decimal> Charlie4 = new List<decimal>();
            Charlie4.Add(randomScore);

            Charlie["name"] = Charlie1;
            Charlie["homework"] = Charlie2;
            Charlie["quizzes"] = Charlie3;
            Charlie["tests"] = Charlie4;

            //Opie 
            IDictionary<string, List<decimal>> Opie = new Dictionary<string, List<decimal>>();

            List<decimal> Opie1 = new List<decimal>();
            Opie1.Add(randomScore);

            List<decimal> Opie2 = new List<decimal>();
            Opie2.Add(randomScore);

            List<decimal> Opie3 = new List<decimal>();
            Opie3.Add(randomScore);

            List<decimal> Opie4 = new List<decimal>();
            Opie4.Add(randomScore);

            Opie["name"] = Opie1;
            Opie["homework"] = Opie2;
            Opie["quizzes"] = Opie3;
            Opie["tests"] = Opie4;

            //create List of students assigning students in Student class
            var students = new List<Student>() {
                new Student(){ id = 1, name="Morty"},
                new Student(){ id = 2, name="Charlie"},
                new Student(){ id = 3, name="Opie"},
            };
        }
    }
}
