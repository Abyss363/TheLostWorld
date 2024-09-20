namespace TheLostWorld;

public class MainMenu
{
    public bool validEntry = false;
    public string? input;
    public int intInput;

    public MainMenu()
    {
        //Obviously, the actual menu
        Console.WriteLine("-----------------------WELCOME TO THE LOST WORLDS-----------------------");
        Console.WriteLine("\n\n\n\n");

        Console.WriteLine("********************** 1. New game   **********************");
        Console.WriteLine("********************** 2. Continue   **********************");
        Console.WriteLine("********************** 3. Credits    **********************");
        Console.WriteLine("********************** 4. Exit       **********************");

        Console.WriteLine("Enter an Option. . . . . . . . . . .");


        do
        {
            while (validEntry == false)
            {
                input = Console.ReadLine();

                //Checking if the player input is valid
                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int value))
                {
                    intInput = Convert.ToInt32(input);
                    if (intInput < 1 || intInput > 4)
                    {
                        Console.WriteLine("Invalid option");
                    }
                    else { validEntry = true; }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a number corresponding to an option to proceed");
                }
            }
            validEntry = false;

            //Menu leads to other parts of the program
            switch (intInput)
            {
                case 1:
                    CharacterCreation newCharacter = new CharacterCreation();
                    World newWorld = new World();
                    break;

                case 2:
                Game.Load();
                    break;

                case 3:
                    Credits credits = new Credits();
                    break;

                case 4:
                    return;
            }
        }
        while (true);
    }

}
