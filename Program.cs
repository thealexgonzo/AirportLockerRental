/* CHALLENGE:
 * Use a string of lenght 100 to store your locker data
 * Locker numbers should be in the range of 1 to 100. Do not allow out-of-range exceptions to crash the application
 *      Remember that array indexes start from 0, but humans are comfortable counting from 1. So, when prompting
 * An application loop should keep users in the program until they choose to quit
 * Users should nver be able to crash the program with bad input. Use TryParse() and loops to prevent this.
 */

// Declare initial variables
int choice, lockerNumber;
string[] lockers = new string[101];

while (true)
{
    // Clear the console window before display the menu
    Console.Clear();

    // Display application menu

    Console.WriteLine("Airport Locker Rental Menu");
    Console.WriteLine("=============================");
    Console.WriteLine("1. View a locker");
    Console.WriteLine("2. Rent a locker");
    Console.WriteLine("3. End a locker rental");
    Console.WriteLine("4. List all locker contents");
    Console.WriteLine("5. Quit");

    // Initiate the program
    do
    {
        Console.Write("\nEnter your choice (1-5): ");
        if (int.TryParse(Console.ReadLine(), out choice) && (choice >= 1 && choice <= 5))
        {
            break;
        }
        else
        {
            Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 5.");
        }
    } while (true);

    // Viewing a locker
    if (choice == 1)
    {
        do
        {
            // Prompt the user for a locker nubmer 
            Console.Write("Enter locker number (1-100): ");
            if (int.TryParse(Console.ReadLine(), out lockerNumber) && (lockerNumber >= 1 && lockerNumber <= 100))
            {

                // Dispaly the contents of the locker if filled, or EMPTY if it is null
                if (string.IsNullOrEmpty(lockers[lockerNumber]))
                {
                    Console.WriteLine($"Locker {lockerNumber} is EMPTY");
                    break;
                }
                else
                {
                    Console.WriteLine($"Locker {lockerNumber} contents: {lockers[lockerNumber]}");
                    break;
                }
            }
            else
            {
                Console.Write("Enter a valid locker number between 1 and 100");
            }

        } while (true);
    }

    // Rent a locker
    if (choice == 2)
    {
        do
        {
            // Prompt the user for a locker number
            Console.Write("Enter locker number (1-100): ");
            if (int.TryParse(Console.ReadLine(), out lockerNumber) && lockerNumber >= 1 && lockerNumber <= 100)
            {
                // Prompt the user for a string value, representign what is stored in the locker
                if (string.IsNullOrEmpty(lockers[lockerNumber]))
                {
                    Console.Write("Enter the item you want to store in the locker: ");

                    if (Console.ReadLine() == null)
                    {
                        Console.WriteLine("You must provide an item description");
                        break;
                    }
                    else
                    {
                        // Assing the string value to the corresponding array element
                        lockers[lockerNumber] = Console.ReadLine();
                        break;
                    }
                }
                else
                {
                    // Do not allow the rental of a locker that is not empty (null element)
                    Console.WriteLine($"Sorry, but locker {lockerNumber} has already been rented!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Enter a valid locker number between 1 and 100");
            }
        } while (true);
    }

    // End a locker rental
    if (choice == 3)
    {
        do
        {
            // Prompt the user for a locker number
            Console.Write("Enter locker number (1-100): ");
            if (int.TryParse(Console.ReadLine(), out lockerNumber) && lockerNumber >= 1 && lockerNumber <= 100)
            {
                if (string.IsNullOrEmpty(lockers[lockerNumber]))
                {
                    // Provide an error message if the locker has not been rented
                    Console.Write($"Locker {lockerNumber} is not currently rented.");
                    break;
                } 
                else
                {
                    // Assing a null value to the corresponding array element
                    Console.Write($"Locker {lockerNumber} rental has ended, please take your {lockers[lockerNumber]}");
                    lockers[lockerNumber] = "";
                    break;
                }
            }
            else
            {
                Console.WriteLine("Enter a valid locker number between 1 and 100");
            }
        } while (true);
    }

    // List all locker contents
    if (choice == 4)
    {
        // Loop through the locker array and output the locker number and the contents only if the element is not null
        for (int i = 0; i < lockers.Length; i++)
        {
            //if (string.IsNullOrEmpty(lockers[i]))
            //{
            //    continue;
            //}
            //else
            //{
            //    Console.WriteLine($"Locker {i}: {lockers[i]}");
            //}

            if (lockers[i] != null)
            {
                Console.WriteLine($"Locker {i + 1}: {lockers[i]}");
            }
        }
    }

    // Quit
    if (choice == 5)
    {
        // Use a break statement to exit the application loop and close the program
        break;
    }
    
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}





