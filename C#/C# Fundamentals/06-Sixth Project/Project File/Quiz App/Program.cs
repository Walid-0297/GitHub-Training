using System;
using System.Collections.Generic;

namespace Quiz_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questions and answers
            List<Question> questions = new List<Question>
            {
                new Question("What is the capital of France?", new string[] { "A) Paris", "B) London", "C) Rome", "D) Berlin" }, 'A'),
                new Question("Which planet is known as the Red Planet?", new string[] { "A) Earth", "B) Mars", "C) Jupiter", "D) Venus" }, 'B'),
                new Question("What is 5 + 3?", new string[] { "A) 6", "B) 7", "C) 8", "D) 9" }, 'C')
            };

            int score = 0;

            Console.WriteLine("Welcome to the Quiz!\n");

            foreach (var question in questions)
            {
                question.Display();
                Console.Write("Your answer: ");
                char userAnswer = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (userAnswer == question.CorrectAnswer)
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was {question.CorrectAnswer}\n");
                }
            }

            Console.WriteLine($"Quiz completed! Your score: {score}/{questions.Count}");
        }
    }

    class Question
    {
        public string Text { get; }
        public string[] Options { get; }
        public char CorrectAnswer { get; }

        public Question(string text, string[] options, char correctAnswer)
        {
            Text = text;
            Options = options;
            CorrectAnswer = correctAnswer;
        }

        public void Display()
        {
            Console.WriteLine(Text);
            foreach (string option in Options)
            {
                Console.WriteLine(option);
            }
        }
    }
}
