string[] studentNames = new string[3] { "Goku", "Gohan", "Piccolo" };
string[] homeTown = new string[3] {"Planet Vegeta", "Planet Earth", "Planet Namek"};
string[] favoriteFood = new string[3] { "Ramen", "Sushi", "Dumplings" };
bool askQuestion = true;



while (askQuestion)
{
    Console.WriteLine("Which student would you like to learn about? Please enter their assigned number:");
    Console.WriteLine();

    for (int enteredName = 0; enteredName < studentNames.Length; enteredName++)
    {
        Console.WriteLine($"{enteredName + 1}. {studentNames[enteredName]}");
    }

    int student = Convert.ToInt32(Console.ReadLine());
    int studentNo = student - 1;
    string answer;

    bool program = true;
    while (program)
    {
        if (studentNo == 0)
        {
            Console.WriteLine($"You have picked {studentNames[0]}!");
            Console.WriteLine($"What else would you like to know about {studentNames[0]}? Enter \"hometown\" or \"favorite food\":");
            string choice = Console.ReadLine().ToLower();
            if (choice == "hometown")
            {
                Console.WriteLine();
                Console.WriteLine($"{studentNames[0]}'s hometown is {homeTown[0]}");
                program = false;
            }

            else if (choice == "favorite food")
            {
                Console.WriteLine($"{studentNames[0]}'s favorite food is {favoriteFood[0]}");
                program = false;

            }

            else
            {
                Console.WriteLine("Not a valid entry. Please enter either \"hometown\" or \"favorite food\":");
                program = true;
            }
        }

        else if (studentNo == 1)
        {
            Console.WriteLine($"You have picked {studentNames[1]}!");
            Console.WriteLine($"What else would you like to know about {studentNames[1]}? Enter \"hometown\" or \"favorite food\":");
            string choice = Console.ReadLine().ToLower();
            if (choice == "hometown")
            {
                Console.WriteLine();
                Console.WriteLine($"{studentNames[1]}'s hometown is {homeTown[1]}");
                program = false;

            }

            else if (choice == "favorite food")
            {
                Console.WriteLine($"{studentNames[1]}'s favorite food is {favoriteFood[1]}");
                program = false;

            }

            else
            {
                Console.WriteLine("Not a valid entry. Please enter either \"hometown\" or \"favorite food\":");
                program = true;
            }
        }

        else if (studentNo == 2)
        {
            Console.WriteLine($"You have picked {studentNames[2]}!");
            Console.WriteLine($"What else would you like to know about {studentNames[2]}? Enter \"hometown\" or \"favorite food\":");
            string choice = Console.ReadLine().ToLower();
            if (choice == "hometown")
            {
                Console.WriteLine();
                Console.WriteLine($"{studentNames[2]}'s hometown is {homeTown[2]}");
                program = false;

            }

            else if (choice == "favorite food")
            {
                Console.WriteLine($"{studentNames[2]}'s favorite food is {favoriteFood[2]}");
                program = false;

            }

            else
            {
                Console.WriteLine("Not a valid entry. Please enter either \"hometown\" or \"favorite food\":");
                program = true;
            }
        }

        else if (studentNo < 1 || studentNo > studentNames.Count())
        {
            Console.WriteLine("Please enter a valid number");
            program = true;
        }
    }

    {

        Console.WriteLine("Would you like to ask about another student?");
        answer = Console.ReadLine().ToLower();

        if (answer == "yes")
        {
            askQuestion = true;
        }
        else
        {
            Console.WriteLine("Thank you for using the student database!");
            Console.ReadKey();
        }    
      

    }
}
