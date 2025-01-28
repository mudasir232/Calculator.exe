// See https://aka.ms/new-console-template for more information

   using System;
   
   namespace Calculator
   {
       class Program
       {
           static void Main(string[] args)
           {
               bool continueCalculating = true;
   
               while (continueCalculating)
               {
                   Console.WriteLine("Enter the first number:");
                   double num1 = Convert.ToDouble(Console.ReadLine());
   
                   Console.WriteLine("Enter an operator (+, -, *, /):");
                   string op = Console.ReadLine();
   
                   Console.WriteLine("Enter the second number:");
                   double num2 = Convert.ToDouble(Console.ReadLine());
   
                   double result = 0;
   
                   switch (op)
                   {
                       case "+":
                           result = num1 + num2;
                           break;
                       case "-":
                           result = num1 - num2;
                           break;
                       case "*":
                           result = num1 * num2;
                           break;
                       case "/":
                           if (num2 != 0)
                           {
                               result = num1 / num2;
                           }
                           else
                           {
                               Console.WriteLine("Error: Division by zero is not allowed.");
                               continue;
                           }
                           break;
                       default:
                           Console.WriteLine("Error: Invalid operator.");
                           continue;
                   }
   
                   Console.WriteLine($"Result: {result}");
   
                   Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                   string response = Console.ReadLine().ToLower();
                   if (response != "yes")
                   {
                       continueCalculating = false;
                   }
               }
           }
       }
   }



/*


Console.WriteLine("Hi ");
Console.WriteLine("How are you ");

string me = Console.ReadLine();

Console.WriteLine("I am also good " + me);

Console.WriteLine("whT IS YOUR NAME ");

string name = Console.ReadLine();
if (name == "mudasir")
{ 
    Console.WriteLine("HELLO " + name);
}  
else
{
    Console.WriteLine("Hello " + name);
}

Console.WriteLine("THANKS FOR USING THIS PROGRAM " + name);
Console.WriteLine("Do you like to play a game ? " + name);

string answer = Console.ReadLine();
if (answer == "yes")
{
    Console.WriteLine("THANKS FOR PLAYING " + name);

    Console.WriteLine("Do you want to play a Quiz game ? " + name);
    string answer1 = Console.ReadLine();
    if (!answer1.Equals("yes"))
    {

        Console.WriteLine("There will be Four Questions ");

        Console.WriteLine("Question 1 " + name);
        Console.WriteLine("What is time ?");


     string[,] Choice = new string[,] { { " A. Time is the sum of the amount of time that has elapsed since the beginning of the universe, and the amount of time that has elapsed since the beginning of the present"}, 
                                       { " B.  Time is the continued sequence of existence and events that occurs in an apparently irreversible succession from the past, through the present, and into the future " } };
for (int i = 0; i < Choice.GetLength(0); i++)
{
    Console.WriteLine(Choice[i, 0]);
}

Console.Write("Enter your answer (A/B): ");
string userAnswer = Console.ReadLine();

if (userAnswer.ToUpper() == "A")
{
    Console.WriteLine("Wrong " + name);
}
else if (userAnswer.ToUpper() == "B")
{
    Console.WriteLine("Right " + name);
}



    }
else {
    Console.WriteLine("Okay" + name);
}
}

else
{
    Console.WriteLine("THANKS FOR YOUR TIME " + name);
}




using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hi ");
        Console.WriteLine("How are you ");

        string me = Console.ReadLine();

        Console.WriteLine("I am also good " + me);

        Console.WriteLine("WHAT IS YOUR NAME ");

        string name = Console.ReadLine();
        if (name.Equals("mudasir", StringComparison.OrdinalIgnoreCase))
        { 
            Console.WriteLine("HELLO " + name);
        }  
        else
        {
            Console.WriteLine("Hello " + name);
        }

        Console.WriteLine("THANKS FOR USING THIS PROGRAM " + name);
        Console.WriteLine("Do you like to play a game? " + name);

        string answer = Console.ReadLine();
        if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("THANKS FOR PLAYING " + name);

            Console.WriteLine("Do you want to play a Quiz game? " + name);
            string answer1 = Console.ReadLine();
            if (answer1.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("There will be Four Questions ");

                Console.WriteLine("Question 1 " + name);
                Console.WriteLine("What is time?");

                string[,] Choice = new string[,] 
                { 
                    { " A. Time is the sum of the amount of time that has elapsed since the beginning of the universe, and the amount of time that has elapsed since the beginning of the present"}, 
                    { " B. Time is the continued sequence of existence and events that occurs in an apparently irreversible succession from the past, through the present, and into the future " } 
                };

                for (int i = 0; i < Choice.GetLength(0); i++)
                {
                    Console.WriteLine(Choice[i, 0]);
                }

                Console.Write("Enter your answer (A/B): ");
                string userAnswer = Console.ReadLine();

                if (userAnswer.ToUpper() == "A")
                {
                    Console.WriteLine("Wrong " + name);
                }
                else if (userAnswer.ToUpper() == "B")
                {
                    Console.WriteLine("Right " + name);
                }

            }
            else 
            {
                Console.WriteLine("Okay " + name);
            }
        }
        else
        {
            Console.WriteLine("THANKS FOR YOUR TIME " + name);
        }
    }
}i


 using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hi ");
        Console.WriteLine("How are you ");

        string me = Console.ReadLine();

        Console.WriteLine("I am also good " + me);

        Console.WriteLine("WHAT IS YOUR NAME ");

        string name = Console.ReadLine();
        if (name.Equals("mudasir", StringComparison.OrdinalIgnoreCase))
        { 
            Console.WriteLine("HELLO " + name);
        }  
        else
        {
            Console.WriteLine("Hello " + name);
        }

        Console.WriteLine("THANKS FOR USING THIS PROGRAM " + name);
        
        string answer;
        do
        {
            Console.WriteLine("Do you like to play a game? (yes/no) " + name);
            answer = Console.ReadLine();
            
            if (!answer.Equals("yes", StringComparison.OrdinalIgnoreCase) && !answer.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        } while (!answer.Equals("yes", StringComparison.OrdinalIgnoreCase) && !answer.Equals("no", StringComparison.OrdinalIgnoreCase));

        if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("THANKS FOR PLAYING " + name);
            
            string answer1;
            do
            {
                Console.WriteLine("Do you want to play a Quiz game? (yes/no) " + name);
                answer1 = Console.ReadLine();
                
                if (!answer1.Equals("yes", StringComparison.OrdinalIgnoreCase) && !answer1.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            } while (!answer1.Equals("yes", StringComparison.OrdinalIgnoreCase) && !answer1.Equals("no", StringComparison.OrdinalIgnoreCase));

            if (answer1.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("There will be Four Questions ");

                Console.WriteLine("Question 1 " + name);
                Console.WriteLine("What is time?");

                string[,] Choice = new string[,] 
                { 
                    { " A. Time is the sum of the amount of time that has elapsed since the beginning of the universe, and the amount of time that has elapsed since the beginning of the present"}, 
                    { " B. Time is the continued sequence of existence and events that occurs in an apparently irreversible succession from the past, through the present, and into the future " } 
                };

                for (int i = 0; i < Choice.GetLength(0); i++)
                {
                    Console.WriteLine(Choice[i, 0]);
                }

                Console.Write("Enter your answer (A/B): ");
                string userAnswer = Console.ReadLine();

                if (userAnswer.ToUpper() == "A")
                {
                    Console.WriteLine("Wrong " + name);
                }
                else if (userAnswer.ToUpper() == "B")
                {
                    Console.WriteLine("Right " + name);
                }
            }
            else 
            {
                Console.WriteLine("Okay " + name);
            }
        }
        else
        {
            Console.WriteLine("THANKS FOR YOUR TIME " + name);
        }
    }
}


*/   /* using System;

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Interact();
    }
}

class Person
{
    private string name;

    public void Interact()
    {
        Console.WriteLine("Hi ");
        Console.WriteLine("How are you ? ");
        
        string me = Console.ReadLine();
        Console.WriteLine("" + me);

        Console.WriteLine("WHAT IS YOUR NAME ?");
        name = Console.ReadLine();

        Greet();

        Console.WriteLine("THANKS FOR USING THIS PROGRAM ! " + name);

        if (GetYesOrNoAnswer("Do you like to play a game?"))
        {
            Console.WriteLine("THANKS FOR PLAYING " + name);

            if (GetYesOrNoAnswer("Do you want to play a Quiz game?"))
            {
                Quiz quiz = new Quiz(name);
                quiz.StartQuiz();
            }
            else
            {
                Console.WriteLine("Okay " + name);
            }
        }
        else
        {
            Console.WriteLine("THANKS FOR YOUR TIME " + name);
        }
    }

    private void Greet()
    {
        if (name.Equals("mudasir", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("HELLO " + name);
        }
        else
        {
            Console.WriteLine("Hello " + name);
        }
    }

    private bool GetYesOrNoAnswer(string question)
    {
        string answer;
        do
        {
            Console.WriteLine(question + " (yes/no) " + name);
            answer = Console.ReadLine();

            if (!answer.Equals("yes", StringComparison.OrdinalIgnoreCase) && !answer.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        } while (!answer.Equals("yes", StringComparison.OrdinalIgnoreCase) && !answer.Equals("no", StringComparison.OrdinalIgnoreCase));

        return answer.Equals("yes", StringComparison.OrdinalIgnoreCase);
    }
}

class Quiz
{
    private string name;
    private string[,] questions = new string[,]
    {
        { "Time is the sum of the amount of time that has elapsed since the beginning of the universe, and the amount of time that has elapsed since the beginning of the present", "A" },
        { "Time is the continued sequence of existence and events that occurs in an apparently irreversible succession from the past, through the present, and into the future", "B" }
    };

    public Quiz(string userName)
    {
        name = userName;
    }

    public void StartQuiz()
    {
        Console.WriteLine("There will be Four Questions ");
        Console.WriteLine("Question 1 " + name);
        Console.WriteLine("What is time?");
        
        for (int i = 0; i < questions.GetLength(0); i++)
        {
            Console.WriteLine($" {questions[i, 1]}. {questions[i, 0]}");
        }

        Console.Write("Enter your answer (A/B): ");
        string userAnswer = Console.ReadLine();

        if (userAnswer.ToUpper() == "A")
        {
            Console.WriteLine("Wrong " + name);
        }
        else if (userAnswer.ToUpper() == "B")
        {
            Console.WriteLine("Right " + name);
        }
    }
}   */  /*using System;

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Interact();
    }
}

class Person
{
    private string name;

    public void Interact()
    {
        Console.WriteLine("Hi ");
        Console.WriteLine("How are you ");
        
        string me = Console.ReadLine();
        Console.WriteLine("I am also good " + me);

        Console.WriteLine("WHAT IS YOUR NAME ");
        name = Console.ReadLine();

        Greet();

        Console.WriteLine("THANKS FOR USING THIS PROGRAM " + name);

        if (GetYesOrNoAnswer("Do you like to play a game?"))
        {
            Console.WriteLine("THANKS FOR PLAYING " + name);

            if (GetYesOrNoAnswer("Do you want to play a Quiz game?"))
            {
                Quiz quiz = new Quiz(name);
                quiz.StartQuiz();
            }
            else
            {
                Console.WriteLine("Okay " + name);
            }
        }
        else
        {
            Console.WriteLine("THANKS FOR YOUR TIME " + name);
        }
    }

    private void Greet()
    {
        if (name.Equals("mudasir", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("HELLO " + name);
        }
        else
        {
            Console.WriteLine("Hello " + name);
        }
    }

    private bool GetYesOrNoAnswer(string question)
    {
        string answer;
        do
        {
            Console.WriteLine(question + " (yes/no) " + name);
            answer = Console.ReadLine();

            if (!answer.Equals("yes", StringComparison.OrdinalIgnoreCase) && !answer.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        } while (!answer.Equals("yes", StringComparison.OrdinalIgnoreCase) && !answer.Equals("no", StringComparison.OrdinalIgnoreCase));

        return answer.Equals("yes", StringComparison.OrdinalIgnoreCase);
    }
}

class Quiz
{
    private string name;
    private string[,] questions = new string[,]
    {
        { "Time is the sum of the amount of time that has elapsed since the beginning of the universe, and the amount of time that has elapsed since the beginning of the present", "A" },
        { "Time is the continued sequence of existence and events that occurs in an apparently irreversible succession from the past, through the present, and into the future", "B" },
        { "What is the capital of France?", "A. Paris" },
        { "What is the largest planet in our solar system?", "B. Jupiter" },
        { "Who wrote 'Romeo and Juliet'?", "A. William Shakespeare" }
    };

    public Quiz(string userName)
    {
        name = userName;
    }

    public void StartQuiz()
    {
        Console.WriteLine("There will be Four Questions ");
        
        for (int i = 0; i < questions.GetLength(0); i++)
        {
            Console.WriteLine($"Question {i + 1} " + name);
            Console.WriteLine(questions[i, 0]);
            Console.WriteLine($"Answer: {questions[i, 1]}");

            Console.Write("Enter your answer: ");
            string userAnswer = Console.ReadLine();

            if (userAnswer.ToUpper() == questions[i, 1][0].ToString().ToUpper())
            {
                Console.WriteLine("Correct " + name);
            }
            else
            {
                Console.WriteLine("Wrong " + name);
            }
        }
    }





    


}  



using System;

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Interact();
    }
}

class Person
{
    private string name;

    public void Interact()
    {
        Console.WriteLine("Hi ");
        Console.WriteLine("How are you ?");
        
        string me = Console.ReadLine();
        Console.WriteLine("" + me);

        Console.WriteLine("WHAT IS YOUR NAME ? ");
        name = Console.ReadLine();

        Greet();

        Console.WriteLine("THANKS FOR USING THIS PROGRAM " + name);

        if (GetYesOrNoAnswer("Do you like to play a game?"))
        {
            Console.WriteLine("THANKS FOR PLAYING " + name);

            if (GetYesOrNoAnswer("Do you want to play a Quiz game?"))
            {
                Quiz quiz = new Quiz(name);
                quiz.StartQuiz();
            }
            else
            {
                Console.WriteLine("Okay " + name);
            }
        }
        else
        {
            Console.WriteLine("THANKS FOR YOUR TIME " + name);
        }
    }

    private void Greet()
    {
        if (name.Equals("mudasir", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("HELLO " + name);
        }
        else
        {
            Console.WriteLine("Hello " + name);
        }
    }

    private bool GetYesOrNoAnswer(string question)
    {
        string answer;
        do
        {
            Console.WriteLine(question + " (yes/no) " + name);
            answer = Console.ReadLine();

            if (!answer.Equals("yes", StringComparison.OrdinalIgnoreCase) && !answer.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        } while (!answer.Equals("yes", StringComparison.OrdinalIgnoreCase) && !answer.Equals("no", StringComparison.OrdinalIgnoreCase));

        return answer.Equals("yes", StringComparison.OrdinalIgnoreCase);
    }
}


class Quiz
{
    private string name;
    private string[][] questions = new string[][]
    {
        new string[] { "What is time?", "A. Time is the sum of the amount of time that has elapsed since the beginning of the universe, and the amount of time that has elapsed since the beginning of the present", "B. Time is the continued sequence of existence and events that occurs in an apparently irreversible succession from the past, through the present, and into the future", },
        new string[] { "What is the capital of France?", "A. Paris", "B. New York", "C. London" },
        new string[] { "What is the largest planet in our solar system?", "B. Jupiter" },
        new string[] { "Who wrote 'Romeo and Juliet'?", "A. William Shakespeare", "B. William Wordsworth" },
    };
    private string[] correctAnswers = new string[] { "B", "A", "B", "A" }; // Correct answers for each question

    public Quiz(string userName)
    {
        name = userName;
    }

    public void StartQuiz()
    {
        Console.WriteLine("There will be Four Questions ");
        int score = 0;

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Question {i + 1}: " + questions[i][0]);
            for (int j = 1; j < questions[i].Length; j++)
            {
                Console.WriteLine(questions[i][j]);
            }

            Console.Write("Enter your answer: ");
            string userAnswer = Console.ReadLine().Trim().ToUpper();

            if (userAnswer == correctAnswers[i])
            {
                Console.WriteLine("Correct " + name);
                score++;
            }
            else
            {
                Console.WriteLine("Wrong " + name);
            }
        }

        Console.WriteLine($"Quiz Over! {name}, you scored {score} out of {questions.Length}");
    }
}


using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Query syntax
        var evenNumbersQuerySyntax = from num in numbers
                                     where num % 2 == 0
                                     select num;

        // Method syntax
        var evenNumbersMethodSyntax = numbers.Where(num => num % 2 == 0);

        Console.WriteLine("Even numbers (Query syntax):");
        foreach (var num in evenNumbersQuerySyntax)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Even numbers (Method syntax):");
        foreach (var num in evenNumbersMethodSyntax)
        {
            Console.WriteLine(num);
        }
    }
}




using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        
        int [] age =  { 11,34,56,79,23,1,9,7,56,45,92,91,62,56,34,67,74,99 } ;


        // for normal linq query 
        var a = from i in age where i> 15 select i;

        // for orderby link query 
       // var a = from i in age where i >15 orderby i ascending select i;

        foreach (int item in a){
            Console.WriteLine(item);

        } 

    }
    
    }
*/