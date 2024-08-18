namespace CarBuilder
{
    class Program
    {
        #region Background_Colours
        static void BackgroundSelection()
        {
            string BackgroundLoop = "start"; // Starts a loop for the colour selection code
            while (BackgroundLoop != "stop")
            {
                try
                {
                    Console.WriteLine("Please pick an option to choose a colour scheme:");
                    Console.WriteLine("Option 1 - White text on a blue background.");
                    Console.WriteLine("Option 2 - White text on a dark green background.");
                    Console.WriteLine("Option 3 - Black text on a dark yellow background.");
                    Console.WriteLine("Option 4 - Black text on a grey background.");
                    Console.WriteLine("Option 5 - White text on a black background.");
                    Console.WriteLine("Option 6 - White text on a red background.");
                    int ConsoleColourCombination = Convert.ToInt32(Console.ReadLine()); // An integer called 'ConsoleColourCombination' which will save the number the user enters
                    switch (ConsoleColourCombination)
                    {
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Blue; // Background colour of the console
                            Console.ForegroundColor = ConsoleColor.White; // Colour of the text displayed on the console
                            BackgroundLoop = "stop"; // Makes sure the user doesn't remain inside the loop
                            Console.Clear(); break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.DarkGreen; // Background colour of the console
                            Console.ForegroundColor = ConsoleColor.White; // Colour of the text displayed on the console
                            BackgroundLoop = "stop"; // Makes sure the user doesn't remain inside the loop
                            Console.Clear(); break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.DarkYellow; // Background colour of the console
                            Console.ForegroundColor = ConsoleColor.Black; // Colour of the text displayed on the console
                            BackgroundLoop = "stop"; // Makes sure the user doesn't remain inside the loop
                            Console.Clear(); break;
                        case 4:
                            Console.BackgroundColor = ConsoleColor.Gray; // Background colour of the console
                            Console.ForegroundColor = ConsoleColor.Black; // Colour of the text displayed on the console
                            BackgroundLoop = "stop"; // Makes sure the user doesn't remain inside the loop
                            Console.Clear(); break;
                        case 5:
                            Console.BackgroundColor = ConsoleColor.Black; // Background colour of the console
                            Console.ForegroundColor = ConsoleColor.White; // Colour of the text displayed on the console
                            BackgroundLoop = "stop"; // Makes sure the user doesn't remain inside the loop
                            Console.Clear(); break;
                        case 6:
                            Console.BackgroundColor = ConsoleColor.Red; // Background colour of the console
                            Console.ForegroundColor = ConsoleColor.White; // Colour of the text displayed on the console
                            BackgroundLoop = "stop"; // Makes sure the user doesn't remain inside the loop
                            Console.Clear(); break;
                        default: Console.WriteLine("Please enter an option between 1 and 6!\n"); break;
                    }
                    Console.WriteLine("This is what your console will look like!");
                    Console.WriteLine("You're being sent back into the program now!");
                    Console.WriteLine("-----------------------------------------------------------------\n");
                    BackgroundLoop = "stop"; // Makes sure the user doesn't remain inside the loop
                    break;
                }
                catch (Exception) // A catch used to catch any errors
                {
                    Console.WriteLine("Your input has caused an error. Please try again!"); // Error message when an error occurs
                }
            }
        }
        #endregion
        #region Login
        static int Login()
        {
            int LoginSelection = 0; // An integer called 'LoginSelection' that is set to 0
            string LoginLoop = "start"; // Starts a loop for the login code
            while (LoginLoop != "stop")
            {
                try
                {
                    Console.WriteLine("Welcome to the Car Builder App! Are you an existing user? If so, login! If not, please either register or continue as a guest user!\n"); // A welcome message displayed to the user
                    string[] MenuOptions = new[] { "1. Login", "2. Register New User", "3. Guest User", "4. Quit" }; // An array of menu options is created, and this allows the user to pick whichever option they want
                    Console.WriteLine(String.Join(Environment.NewLine, MenuOptions)); // All of the menu options will be displayed from the array, line by line
                    LoginSelection = Convert.ToInt32(Console.ReadLine()); // The choice the user makes is then converted to an integer
                    // The code below will make sure that only options between 1 and 4 are allowed
                    // The loop will be set to true and will allow the user to continue through the program
                    if ((LoginSelection >= 1) && (LoginSelection <= 4)) { LoginLoop = "stop"; break; } // Makes sure the user doesn't remain inside the loop break
                    // If the user has entered a number outside of this range, an error message will appear and send them back to the login menu
                    else { Console.WriteLine("Please enter a number between 1 and 4 to continue!"); }
                }
                catch (Exception) // A catch used to catch any errors
                { Console.WriteLine("Your input has caused an error. Please try again!"); } // Error message when an error occurs
            }
            return LoginSelection;
        }
        #endregion
        #region Car_Manufacturers
        static void CarBrands() // Method called CarBrands, which will display all of the available car brands that the user can pick from, as well as the budget, door selection, the colour etc
        {
            int Budget = 0; // A integer called 'Budget' created for the user to enter their desired budget. Set to 0
            int BudgetTotal = 0; // A integer called 'BudgetTotal' will be used to work out the budget for a user
            try
            {
                Boolean BudgetLoop = false; // A loop to make sure the a budget is entered and within the correct paramenters. Set to false by default
                while (!BudgetLoop)
                {
                    Console.WriteLine("\nPlease indicate the amount of money you'd be willing to spend by typing it in below! This will also give you an idea of what cars you could purchase (without extras). However, please take into consideration that some different options (like the engine), may limit this even further!");
                    Budget = Convert.ToInt32(Console.ReadLine()); // The users input is converted to a decimal
                    string UserBudget = @"\userbudget.txt"; // File created for the budget
                    StreamWriter stwr = File.CreateText(@"\userbudget.txt"); // StreamWriter object declared and any data will write to specified file
                    stwr.Flush();
                    stwr.Close(); // Closes the StreamWriter object and the stream buffer
                    using (StreamWriter sw = File.AppendText(UserBudget))
                    {
                        sw.WriteLine("Your budget is £" + Budget); // The budget that the user enters should write to the file and can be viewed
                        sw.Close(); // Closes the StreamWriter object and the stream buffer
                    }
                    if ((Budget >= 17000) && (Budget <= 24999)) { Console.WriteLine("\nWithin this budget, you are only able to buy the Ford Fiesta and Ford Puma.\n"); break; } // Tells the user what cars are available for their budget within this range 
                    // Tells the user what cars are available for their budget wuthin this range
                    else if ((Budget >= 25000) && (Budget <= 49999)) { Console.WriteLine("\nWithin this budget, you can purchase the following models: \nThe models below £25,000 and the\n118i M Sport\n520i M Sport Saloon\n420i M Sport Coupe\n218i M Sport Gran Coupe\nA-Class Compact Saloon\nB-Class Tourer\nC-Class Saloon\nand the E-Class Saloon\n"); break; }
                    else if ((Budget >= 50000) && (Budget <= 74999)) { Console.WriteLine("\nWithin this budget, you can purchase the following models: \nAll models below £50,000\n"); break; } // Tells the user what cars are available for their budget within this range
                    else if ((Budget >= 75000) && (Budget <= 99999)) { Console.WriteLine("\nWithin this budget, you can purchase the following models: \nAll models below £75,000\n"); break; } // Tells the user what cars are available for their budget within this range
                    else if ((Budget >= 100000) && (Budget <= 124999)) { Console.WriteLine("\nYou will be able to buy any of the available models (regardless of engine) from any of the manufacturers!\n"); break; } // Tells the user what cars are available for their budget within this range
                    else { Console.WriteLine("\nYou have entered a number that is not within the permitted range! Please try again!"); } // If a number entered isn't within any range, display this message to the user
                }
            }
            catch (FormatException) { Console.WriteLine("The input you have entered is invalid! Please try again!"); } // If the input entered is not valid (integers only), this error message will appear and the program will stop
            catch (OverflowException) { Console.WriteLine("This number is out of range for an integer!"); } // If an input is too large or too small to be an integer, this error message will appear
            // Code for the door selection below
            try
            {
                Boolean DoorCheckLoop= false; // A loop to make sure that only the correct numbers are entered by the user
                while (!DoorCheckLoop)
                {
                    // Note to the user regarding the lack of checks between a car with a chosen door type, and the manufacturer and model
                    Console.WriteLine("Note: There is currently no way to check your door option against your chosen manufacturer and model. Please make sure you stick to your selection all the way through!"); 
                    Console.WriteLine("You can choose either 3-door (option 1) or 5-door (option 2)! Please select either 1 or 2 for your selection:");
                    int DoorChoice = Convert.ToInt32(Console.ReadLine()); // The choice is converted into a 32-bit integer
                    switch (DoorChoice) // A switch for the door selection
                    {
                        case 1: // Cars with 3 doors
                            Console.WriteLine("You have chosen to build a 3-door car!");
                            Console.WriteLine("This is the model that has 3 doors:");
                            Console.WriteLine("420i M Sport Coupe"); DoorCheckLoop = true; break;
                        case 2: // Cars with 5 doors
                            Console.WriteLine("You have chosen to build a 5-door car!");
                            Console.WriteLine("These are the models that have 5 doors:");
                            Console.WriteLine("Ford Fiesta\nFord Puma\nBMW 118i M Sport\nBMW 520i M Sport Saloon\nBMW 218i M Sport Gran Coupe\nMercedes A-Class Compact Saloon\nMercedes B-Class Tourer\nMercedes C-Class Saloon\nMercedes E-Class Saloon"); DoorCheckLoop = true; break;
                        default: Console.WriteLine("Error! Please enter either 1 or 2!\n"); break;
                    }
                }
                // Code for the different manufacturers and models below
                Console.WriteLine("\nThese are the brands that you can choose from:\n"); // A message informing the user about the available car brands
                string[] DifferentBrands = new[] { "1 - Ford", "2 - BMW", "3 - Mercedes" }; // An array is created to show all of the different car brands
                Console.WriteLine(String.Join(Environment.NewLine, DifferentBrands)); // All of the car brands are displayed from the array, line by line
                Console.WriteLine("\nPlease enter the number related to the brand that you wish to choose:");
                int CarSelection = Convert.ToInt32(Console.ReadLine()); // The choice is converted into a 32-bit integer
                switch (CarSelection) // A switch statement that corresponds to the number that the user picks based on the car selection
                {
                    case 1:
                        Boolean FordModelLoop = false; // A loop to make sure a model chosen from the list - false by default
                        while (!FordModelLoop) // A while loop to make sure the chosen model matches any from the list (true), else it will loop until this condition is met
                        {
                            Console.WriteLine("\nYou have chosen Ford as your brand!");
                            Console.WriteLine("These are the current models that you can choose from:");
                            string ChosenFordModel; // String created for the user to pick out their chosen Ford model
                            List<string> FordModels = new(2); // A list is created to show all the different Ford models avaliable
                            FordModels.Add("Fiesta"); FordModels.Add("Puma");
                            FordModels.Sort(); // Will sort the list to be in alphabetical order
                            foreach (string a in FordModels) { Console.WriteLine(a); } // Foreach loop to display all of the car models
                            Console.WriteLine("\nPlease select your chosen model: ");
                            ChosenFordModel = Console.ReadLine().ToUpper(); // The chosen model will be whatever the user types in and will allow the user to use caps if they choose to
                            StreamWriter stwr = File.CreateText(@"\cardetails.txt"); // StreamWriter object declared and any data will write to specified file
                            stwr.Flush();
                            stwr.Close(); // Closes the StreamWriter object and the stream buffer
                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                            {
                                sw.WriteLine("Your car details\n" + "Your chosen model: Ford " + ChosenFordModel); // The model of car that the user enters should write to the file and can be viewed
                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                            }
                            // if and else if statements for the chosen models
                            if (ChosenFordModel == "Fiesta" || ChosenFordModel == "fiesta" || ChosenFordModel == "FIESTA") // Allows all three types to be entered by the user
                            {
                                Console.WriteLine("You have chosen the Ford Fiesta!\n"); FordModelLoop = true; // The loop is true, as the string matched
                                string[] FordFiestaEngines = new[] { "1 - 1.1L Ti-VCT 75PS 5-Speed manual", "2 - 1.0L EcoBoost 100PS 6-speed manual", "3 - 1.0L EcoBoost 125PS mHEV 6-Speed manual" }; // String array for all the engines for the Ford Fiesta
                                Boolean EngineConfirmationLoop = false; // A loop to make sure the user chooses the engine they want - set to false by default
                                while (!EngineConfirmationLoop) // A nested while loop to confirm the engine choice
                                {
                                    Console.WriteLine("These are the engines that you can choose from for the Ford Fiesta:");
                                    Console.WriteLine(string.Join(Environment.NewLine, FordFiestaEngines)); // All of the engines are displayed from the array, line by line
                                    Console.WriteLine("Please choose the engine you would like by selecting a number between 1 and 3:");
                                    int ChosenEngine = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenEngine' created and set based on users input on engine selection
                                    if (ChosenEngine == 1) { Console.WriteLine("The engine you have chosen is the 1.1L Ti-VCT 75PS 5-Speed manual, which costs £17,470 OTR"); } // Nested if and else if statements, based on engine selection. If 1 is selected
                                    else if (ChosenEngine == 2) { Console.WriteLine("The engine you have chosen is the 1.0L EcoBoost 100PS 6-speed manual, which costs £18,220 OTR"); } // If 2 is entered
                                    else if (ChosenEngine == 3) { Console.WriteLine("The engine you have chosen is the 1.0L EcoBoost 125PS mHEV 6-Speed manual, which costs £19,340 OTR"); } // If 3 is entered
                                    else { Console.WriteLine("Error! Please enter a number between 1 and 3!"); } // If a number between 1 or 3 isn't entered
                                    int Engine_One = 17470; // The price of the first engine
                                    int Engine_Two = 18220; // The price of the second engine
                                    int Engine_Three = 19340; // The price of the third engine
                                    Console.WriteLine("Are you happy with your chosen engine? (Y or N):"); // Making sure the user is happy with the engine choice
                                    string EngineConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (EngineConfirmation)
                                    {
                                        case "Y":
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                            {
                                                if (ChosenEngine == 1) { sw.WriteLine("Your chosen engine: 1.1L Ti-VCT 75PS 5-Speed manual"); } // If engine 1 was chosen, write this to the file
                                                else if (ChosenEngine == 2) { sw.WriteLine("Your chosen engine: 1.0L EcoBoost 100PS 6-speed manual"); } // If engine 2 was chosen, write this to the file
                                                else if (ChosenEngine == 3) { sw.WriteLine("Your chosen engine: 1.0L EcoBoost 125PS mHEV 6-Speed manual"); } // If engine 3 was chosen, write this to the file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt"))
                                            {
                                                if (ChosenEngine == 1) { sw.WriteLine("The engine you've chosen (1.1L Ti-VCT 75PS 5-Speed manual) costs " + Engine_One); // The price of engine one will be added to the 'UserBudget' file and can be viewed
                                                    BudgetTotal = Budget - Engine_One; sw.WriteLine("Your remaining budget is " + BudgetTotal); } // The price of the engine is taken away from budget entered by the user
                                                if (ChosenEngine == 2) { sw.WriteLine("The engine you've chosen (1.0L EcoBoost 100PS 6-speed manual) costs " + Engine_Two); // The price of engine two will be added to the 'UserBudget' file and can be viewed
                                                    BudgetTotal = Budget - Engine_Two; sw.WriteLine("Your remaining budget is " + BudgetTotal); } // The price of the engine is taken away from budget entered by the user
                                                if (ChosenEngine == 3) { sw.WriteLine("The engine you've chosen (1.0L EcoBoost 125PS mHEV 6-Speed manual) costs " + Engine_Three); // The price of engine three will be added to the 'UserBudget' file and can be viewed
                                                    BudgetTotal = Budget - Engine_Three; sw.WriteLine("Your remaining budget is " + BudgetTotal); } // The price of the engine is taken away from budget entered by the user
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); EngineConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and select a different engine.\n"); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                string[] FordColours = new[] { "Red", "White", "Black", "Silver", "Blue", "Grey" }; // Array of all colours for all Ford models
                                Array.Sort(FordColours); // The array will be sorted
                                int ColourRed = 775; // An integer (ColourRedPuma) has been declared and assigned the value of 775
                                int ColourWhite = 250; // An integer (ColourWhite) has been declared and assigned the value of 250
                                int ColourWhitePuma = 275; // An integer (ColourWhitePuma) has been delcared and assigned the value of 275
                                int ColourBlack = 525; // An integer (ColourBlack) has been declared and assigned the value of 525
                                int ColourSilver = 525; // An integer (ColourSilver) has been declared and assigned the value of 525
                                int ColourBlueFiesta = 525; // An integer (ColourBlueFiesta) has been declared and assigned the value of 525
                                int ColourGrey = 775; // An integer (ColourGreyPuma) has been declared and assigned the value of 775
                                Console.WriteLine("These are the colours you can choose from:");
                                foreach (string a in FordColours) { Console.WriteLine(a); } // Using a foreach loop to display all of the elements in the array to the user (to show all of the available colours)
                                Boolean FordCompatibleCombinationLoop = false; // A loop to make sure the colour and model combination matches. Set to false by default
                                while (!FordCompatibleCombinationLoop) // The while loop to the check the combination
                                {
                                    Console.WriteLine("\nNote 1: Some colours will cost extra if chosen, or might not be avaliable, depending on the model selected!"); // Message to the user about extra cost for certain colours
                                    // Another message to the user regarding exact spelling of the words
                                    Console.WriteLine("Note 2: Please enter the chosen colour EXACTLY as it is shown to you, otherwise, the program will not accept it. This is due to a coding fault. There were attempts to rectify it that were unsuccessful. However, this could be fixed in the future!\n");
                                    Console.WriteLine("Please choose a colour: ");
                                    string ChosenFordColour; // A local variable called 'ChosenFordColour' is created
                                    ChosenFordColour = Console.ReadLine(); // Whatever the user types in is set to the 'ChosenFordColour' variable
                                    int FordColourIndex = Array.BinarySearch(FordColours, ChosenFordColour); // Searches the entire array (FordColours) and sees if the colours that is input by the user matches
                                    if (FordColourIndex >= 0) // If the colour chosen is greater-than or equal to the first index in the array AND matches, output the colour and the position in the array
                                    {
                                        Console.WriteLine(ChosenFordColour + " is found at " + FordColourIndex.ToString() + " position!");
                                            if (ChosenFordColour == "Red") // Nested if statements that will go through all of the colours to inform the user about availability per model
                                            {
                                                Console.WriteLine("This colour is available on both models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The price on the Fiesta is free, but on the Puma, it will cost £775");
                                                string[] FordModelsColourRed = new[] { "1 - Fiesta", "2 - Puma" }; // An array called 'FordModels' that will display all of the models to the user
                                                Console.WriteLine(string.Join(Environment.NewLine, FordModelsColourRed)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                                {
                                                    if (ChosenFordColour == "Red") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen for this model is Red. This colour will not cost any extra."); } } // If the user chooses the colour red, and the Fiesta, the message will be written to the 'CarDetails' file
                                                    else if (ChosenFordColour == "Red") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen for this model is Red. This colour will cost an extra £775."); } } // If the user chooses the colour red, and the Puma, the message will be written to the 'CarDetails' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenFordColour == "Red") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Red) costs " + ColourRed); // If the user chose the Puma, and the colour red, this will be written to the 'UserBudget' file
                                                            BudgetTotal = Budget - ColourRed; sw.Close(); } } } // The price of the colour is taken away from budget entered by the user
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenFordColour == "White")
                                            {
                                                Console.WriteLine("This colour is available on both Ford models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The colour on the Fiesta will cost £250, whereas on the Puma, the colour will cost £275");
                                                string[] FordModelsColourWhite = new[] { "1 - Fiesta", "2 - Puma" }; // An array called 'FordModels' that will display all of the models to the user
                                                Console.WriteLine(string.Join(Environment.NewLine, FordModelsColourWhite)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                                {
                                                    if (ChosenFordColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen for this model is White. This colour will cost an extra £250."); } } // If the user chooses the colour white, and the Fiesta, the message will be written to the 'CarDetails' file
                                                    else if (ChosenFordColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen for this model is White. This colour will cost an extra £275."); } } // If the user chooses the colour white, and the Puma, the message will be written to the 'CarDetails' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt"))
                                                {
                                                    if (ChosenFordColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colur you have chosen (White) costs " + ColourWhite); // If the user chose the Fiesta, and the colour white, this will be written to the 'UserBudget' file
                                                            BudgetTotal = Budget - ColourWhite; } } // The price of the colour is taken away from budget entered by the user
                                                    else if (ChosenFordColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (White) costs " + ColourWhitePuma); // If the user chose the Puma, and the colour white, this will be written to the 'UserBudget' file
                                                        BudgetTotal = Budget - ColourWhite; } } // The price of the colour is taken away from budget entered by the user
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenFordColour == "Black")
                                            {
                                                Console.WriteLine("This colour is available on both Ford models and will both cost £525!");
                                                string[] FordModelsColourBlack = new[] { "1 - Fiesta", "2 - Puma" }; // An array called 'FordModels' that will display all of the models to the user
                                                Console.WriteLine(string.Join(Environment.NewLine, FordModelsColourBlack)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                                {
                                                    if (ChosenFordColour == "Black") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Black. It will cost an extra £525."); } } // If the user chose the Fiesta at the beginning, and the colour black, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenFordColour == "Black") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Black. It will cost an extra £525."); } } // If the user chose the Puma at the beginning, and the colour black, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt"))
                                                {
                                                    if (ChosenFordColour == "Black") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen (Black), for this model, will cost " + ColourBlack); // If the user chose the Fiesta, and the colour black, this will write the price of the colour to the 'UserBudget' file
                                                        BudgetTotal = Budget - ColourBlack; } } // The price of the colour is taken away from budget entered by the user
                                                    else if (ChosenFordColour == "Black") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen (Black), for this model, will cost " + ColourBlack); // If the user chose the Puma, and the colour black, this will write the price of the colour to the 'UserBudget' file
                                                        BudgetTotal = Budget - ColourBlack; } }  // The price of the colour is taken away from budget entered by the user
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenFordColour == "Silver")
                                            {
                                                Console.WriteLine("This colour is available on both Ford models and will both cost £525!");
                                                string[] FordModelsColourSilver = new[] { "1 - Fiesta", "2 - Puma" }; // An array called 'FordModels' that will display all of the models to the user
                                                Console.WriteLine(string.Join(Environment.NewLine, FordModelsColourSilver)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                                {
                                                    if (ChosenFordColour == "Silver") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen on this model is Silver. It will cost an extra £525."); } } // If the user chose the Fiesta at the beginning, and the colour silver, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenFordColour == "Silver") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen on this model is Silver. It will cost an extra £525."); } } // If the user chose the Puma at the beginning, and the colour silver, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt"))
                                                {
                                                    if (ChosenFordColour == "Silver") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen (Silver), will cost " + ColourSilver); // If the user chose the Fiesta, and the colour silver, this will write the price of the colour to the 'UserBudget' file
                                                        BudgetTotal = Budget - ColourSilver; } } // The price of the colour is taken away from budget entered by the user
                                                    else if (ChosenFordColour == "Silver") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen (Silver), will cost " + ColourSilver); // If the user chose the Puma, and the colour silver, this will write the price of the colour to the 'UserBudget' file
                                                        BudgetTotal = Budget - ColourSilver; } } // The price of the colour is taken away from budget entered by the user
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenFordColour == "Blue")
                                            {
                                                Console.WriteLine("This colour is available on all Ford models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The Fiesta will cost an extra £525!\nThe colour on the Puma is free, so no extra charge!");
                                                string[] FordModelsColourBlue = new[] { "1 - Fiesta", "2 - Puma" }; // An array called 'FordModels' that will display all of the models to the user
                                                Console.WriteLine(string.Join(Environment.NewLine, FordModelsColourBlue)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                                {
                                                    if (ChosenFordColour == "Blue") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Blue. It will cost an extra £525."); } } // If the user chose the Fiesta at the beginning, and the colour blue, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenFordColour == "Blue") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Blue. This colour will not cost any extra."); } } // If the user chose the Puma at the beginning, and the colour blue, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                // If the user chose the Fiesta, and the colour blue, this will write the price of the colour to the 'UserBudget' file
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenFordColour == "Blue") { if (ChosenModel == 1) { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you have chosen (Blue), for this model, will cost " + ColourBlueFiesta); BudgetTotal = Budget - ColourBlueFiesta; sw.Close(); } } } 
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenFordColour == "Grey")
                                            {
                                                Console.WriteLine("This colour is only available on the Puma!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        string FordModel = "Puma"; // An array called 'FordModels' that will display the model that this colour is applicable for
                                                        Console.WriteLine("The " + FordModel + " is the model that supports this colour and it will cost an extra £775!");
                                                        // If the user chose the Puma at the beginning, and the colour grey, this will write to the 'CarDetails' file if this colour is chosen
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenFordColour == "Grey") { sw.WriteLine("The colour you have chosen on this model is Grey. It will cost an extra £775."); sw.Close(); } } 
                                                        // If the user chose the Puma, and the colour grey, this will write the price of the colour to the 'UserBudget' file
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenFordColour == "Grey") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you have chosen (Grey), for this model, will cost " + ColourGrey); BudgetTotal = Budget - ColourGrey; sw.Close(); } } 
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); FordCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("The colour you have picked is not available!"); } // If the colour doesn't match, then that colour is not available and a message is displayed to the user
                                }
                                Console.WriteLine("The only wheels that are standard on this model are 15-inch alloy wheels, which do not cost extra.");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { sw.WriteLine("The only available wheels on this model are 15-inch alloy wheels."); } // Writing the details on the wheels to the 'CarDetails' file
                                Console.WriteLine("There is no option to select different tyres on this model. Whatever is on the car is what is available, and they don't cost extra!");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { sw.WriteLine("The only available tyres for the car are what come with it."); } // Writing the details on the tyres to the 'CarDetails' file
                                Console.WriteLine("\nIf you would like, you can also choose any of the following paid extras that are available for your model:");
                                string[] AdditionalExtras = new[] { "1 - 16” Alloys", "2 - Privacy Glass", "3 - Spare Wheel", "4 - Parking Pack", "5 - SYNC 3 with Navigation", "6 - Winter Pack", "7 - Floor mats", "8 - Boot liner", "9 - Dashboard camera", "10 - Pet travel mat" }; // Any additional extras will be displayed in the array
                                string[] ExtrasCost = new[] { "£300", "£250", "£150", "£600", "£600", "£350", "£70", "£61.69", "£284.36", "£264.50" }; // Cost of each extra item
                                Console.WriteLine(String.Join(Environment.NewLine, AdditionalExtras)); // All of the extras are displayed from the array, line by line
                                // Solution to selecting multiple options within an array (code below) has been slightly changed and adapted from the answer posted (by JackJJun-MSFT) from this link: https://docs.microsoft.com/en-us/answers/questions/835275/choose-multiple-options-within-an-array.html
                                List<string> ExtrasList = new(); // A list created called 'ExtrasList'
                                Dictionary<int, string> Dictionary = new(); // A new dictionary called 'Dictionary' - which will repesent the collection of values within the array
                                foreach (string item in AdditionalExtras)
                                { // For each item in the 'AdditionalExtras' array...
                                    int n = Convert.ToInt32(item.Split('-')[0].Trim()); // 1 - An integer called 'n' will convert it to a 32-bit integer. Each item within the array will be split into substrings, and then any whitespace will be trimmed away
                                    string m = item.Split('-')[1].Trim(); // 2 - A string called 'm' and the item will then also be split into substrings, and again, any whitespace will be trimmed away
                                    Dictionary.Add(n, m); // 3 - Finally, the values will be added to the Dictionary
                                }
                                while (true)
                                {
                                    Console.WriteLine("Note: If you want to end your choice selection, please press the speacebar in the console (after a number has been entered), otherwise, please press enter to keep making selections!");
                                    Console.WriteLine("Please select any of the extras that you would like to purchase!");
                                    int ExtraSelection = Convert.ToInt32(Console.ReadLine()); // Integer called 'ExtraSelection' created and will be set based on the users input
                                    // Solution to the below if statemement outputting the chosen extra item and the price was provided by JackJJun-MSFT from this link: https://docs.microsoft.com/en-us/answers/questions/840725/join-two-different-string-arrays-in-c.html
                                    if (Dictionary.ContainsKey(ExtraSelection)) { ExtrasList.Add(Dictionary[ExtraSelection] + " ---- " + ExtrasCost[ExtraSelection - 1]); } // If the Dictionary contains a key from the users input, that key will be added to the 'ExtraList' list, and the cost will be included of that item
                                    else { Console.WriteLine("Please input the correct number!"); } // If an incorrect number is entered by the user (or if the enter key is pressed), display this error message and the program will stop
                                    ConsoleKeyInfo c = Console.ReadKey(); // The info of the console key that was pressed, assign it the variable 'c'
                                    if (c.Key == ConsoleKey.Spacebar) { break; } // If the console key is the Spacebar key, break out of the loop for all of the selected options
                                }
                                Console.WriteLine("Below is your purchase list:");
                                foreach (var item in ExtrasList) { Console.WriteLine(item); } // Display each item in the 'ExtrasList' as well as the cost
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                {
                                    sw.WriteLine("\nThese are the items you've chose to add to your configuration:");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'CarDetails' file
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt"))
                                {
                                    sw.WriteLine("Here is the breakdown of the extra items chosen and their costs");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'UserBudget' file
                                    Console.WriteLine("There is no way to calculate the price of the extras against the budget you have entered. You may need to add this on separately to see if the extras might cause you to go overbudget. However, this could be fixed in the future.");
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n");
                                Console.WriteLine("You have now completed building your car!");
                                Console.WriteLine("Note: There is no way of checking that you can afford it or not as that system caused problems so was not implemented.");
                                Boolean DepositConfirmationLoop = false; // A loop to make sure the deposit is paid. Set to false by default
                                while (!DepositConfirmationLoop) // A while loop to confirm if it has been paid
                                {
                                    Console.WriteLine("Before you can purchase it, have you paid your deposit and has it cleared? (Y or N):");
                                    string DepositConfirmation = Console.ReadLine().ToUpper(); 
                                    switch (DepositConfirmation)
                                    {
                                        case "Y": // If the user has paid their deposit, break out of the loop
                                            Console.WriteLine("You may now confirm your payment!"); DepositConfirmationLoop = true; break;
                                        default: Console.WriteLine("Please make it has been paid before you continue!"); break; // If the user still needs to pay the deposit, go back and ask again
                                    }
                                }
                                Boolean PurchaseConfirmationLoop = false; // A loop ot make sure the purchase confirmation is complete. Set to false by default
                                while (!PurchaseConfirmationLoop)
                                { 
                                    Console.WriteLine("Before you confirm your purchase, please note that once you do, you cannot change your mind! Are you happy with your purchase? (Y or N):");
                                    string PurchaseConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (PurchaseConfirmation)
                                    {
                                        case "Y": // If the user is happy with their purchase
                                            Console.WriteLine("You can now pay for your car and confirm your purchase!");
                                            Console.WriteLine("Thank you for using the Car Builder App!"); PurchaseConfirmationLoop = true; break;
                                        default: Console.WriteLine("You can start the program again and build a new car!"); System.Environment.Exit(0); break; // If the user still isn't sure, they can quit the program and start again
                                    }
                                }
                            }
                            else if (ChosenFordModel == "Puma" || ChosenFordModel == "puma" || ChosenFordModel == "PUMA") // Allows all three types to be entered by the user
                            {

                                Console.WriteLine("You have chosen the Ford Puma!\n"); FordModelLoop = true; // The loop is true, as the string matched
                                string[] FordPumaEngines = new[] { "1 - 1.0L Ford EcoBoost Hybrid (mHEV) 125PS 6-speed", "2 - 1.0L Ford EcoBoost Hybrid (mHEV) 155PS 6-speed", "3 - 1.0L Ford EcoBoost Hybrid (mHEV) 125PS 7-speed Automatic" }; // String array for all the engines for the Ford Puma
                                Boolean EngineConfirmationLoop = false; // A loop to make sure the user chooses the engine they want - set to false by default
                                while (!EngineConfirmationLoop) // A nested while loop to confirm the engine choice
                                {
                                    Console.WriteLine("These are the engines that you can choose from for the Ford Puma:");
                                    Console.WriteLine(String.Join(Environment.NewLine, FordPumaEngines)); // All of the engines are displayed from the array, line by line
                                    Console.WriteLine("Please choose the engine you would like by selecting a number between 1 and 3:");
                                    int ChosenEngine = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenEngine' created and set based on users input on engine selection
                                    if (ChosenEngine == 1) { Console.WriteLine("The engine you have chosen is the 1.0L Ford EcoBoost Hybrid (mHEV) 125PS 6-speed, which costs £23,145 OTR"); } // Nested if and else if statements, based on engine selection. If 1 is selected
                                    else if (ChosenEngine == 2) { Console.WriteLine("The engine you have chosen is the 1.0L Ford EcoBoost Hybrid (mHEV) 155PS 6-speed, which costs £23,895 OTR"); } // If 2 is entered
                                    else if (ChosenEngine == 3) { Console.WriteLine("The engine you have chosen is the 1.0L Ford EcoBoost Hybrid (mHEV) 125PS 7-speed Automatic, which costs £24,945 OTR"); } // If 3 is entered
                                    else { Console.WriteLine("Error! Please enter a number between 1 and 3!"); } // If a number between 1 or 3 isn't entered
                                    int Engine_One = 23145; // The price of the first engine
                                    int Engine_Two = 23895; // The price of the second engine
                                    int Engine_Three = 24945; // The price of the third engine
                                    Console.WriteLine("Are you happy with your chosen engine? (Y or N):"); // Making sure the user is happy with the engine choice
                                    string EngineConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (EngineConfirmation)
                                    {
                                        case "Y": // If the user is happy with their engine choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                            {
                                                if (ChosenEngine == 1) { sw.WriteLine("Your chosen engine: 1.0L Ford EcoBoost Hybrid (mHEV) 125PS 6-speed"); } // If engine 1 was chosen, write this to the file
                                                else if (ChosenEngine == 2) { sw.WriteLine("Your chosen engine: 1.0L Ford EcoBoost Hybrid (mHEV) 155PS 6-speed"); } // If engine 2 was chosen, write this to the file
                                                else if (ChosenEngine == 3) { sw.WriteLine("Your chosen engine: 1.0L Ford EcoBoost Hybrid (mHEV) 125PS 7-speed Automatic"); } // If engine 3 was chosen, write this to the file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt"))
                                            {
                                                sw.WriteLine("Your current budget is: " + Budget);
                                                if (ChosenEngine == 1) { sw.WriteLine("The engine you've chosen (1.0L Ford EcoBoost Hybrid (mHEV) 125PS 6-speed) costs " + Engine_One); // The price of engine one will be added to the 'UserBudget' file and can be viewed
                                                BudgetTotal = Budget - Engine_One; sw.WriteLine("Your remaining budget is " + BudgetTotal); } // The price of the engine is taken away from budget entered by the user
                                                else if (ChosenEngine == 2) { sw.WriteLine("The engine you've chosen (1.0L Ford EcoBoost Hybrid (mHEV) 155PS 6-speed) costs " + Engine_Two); // The price of engine two will be added to the 'UserBudget' file and can be viewed
                                                BudgetTotal = Budget - Engine_Two; sw.WriteLine("Your remaining budget is " + BudgetTotal); } // The price of the engine is taken away from budget entered by the user
                                                else if (ChosenEngine == 3) { sw.WriteLine("The engine you've chosen (1.0L Ford EcoBoost Hybrid (mHEV) 125PS 7-speed Automatic) costs " + Engine_Three);  // The price of engine three will be added to the 'UserBudget' file and can be viewed
                                                BudgetTotal = Budget - Engine_Three; sw.WriteLine("Your remaining budget is " + BudgetTotal); } // The price of the engine is taken away from budget entered by the user
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); EngineConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and select a different engine."); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                string[] FordColours = new[] { "Red", "White", "Black", "Silver", "Blue", "Grey" }; // Array of all colours for all Ford models
                                Array.Sort(FordColours); // The array will be sorted
                                int ColourRed = 775; // An integer (ColourRedPuma) has been declared and assigned the value of 775
                                int ColourWhite = 250; // An integer (ColourWhite) has been declared and assigned the value of 250
                                int ColourWhitePuma = 275; // An integer (ColourWhitePuma) has been delcared and assigned the value of 275
                                int ColourBlack = 525; // An integer (ColourBlack) has been declared and assigned the value of 525
                                int ColourSilver = 525; // An integer (ColourSilver) has been declared and assigned the value of 525
                                int ColourBlueFiesta = 525; // An integer (ColourBlueFiesta) has been declared and assigned the value of 525
                                int ColourGrey = 775; // An integer (ColourGreyPuma) has been declared and assigned the value of 775
                                Console.WriteLine("These are the colours you can choose from:");
                                foreach (string a in FordColours) { Console.WriteLine(a); } // Using a foreach loop to display all of the elements in the array to the user (to show all of the available colours)
                                Boolean FordCompatibleCombinationLoop = false; // A loop to make sure the colour and model combination matches. Set to false by default
                                while (!FordCompatibleCombinationLoop) // The while loop to the check the combination
                                {
                                    Console.WriteLine("\nNote 1: Some colours will cost extra if chosen, or might not be avaliable, depending on the model selected!"); // Message to the user about extra cost for certain colours
                                    // Another message to the user regarding exact spelling of the words
                                    Console.WriteLine("Note 2: Please enter the chosen colour EXACTLY as it is shown to you, otherwise, the program will not accept it. This is due to a coding fault. There were attempts to rectify it that were unsuccessful. However, this could be fixed in the future!\n");
                                    Console.WriteLine("Please choose a colour: ");
                                    string ChosenFordColour; // A local variable called 'ChosenFordColour' is created
                                    ChosenFordColour = Console.ReadLine(); // Whatever the user types in is set to the 'ChosenFordColour' variable
                                    int FordColourIndex = Array.BinarySearch(FordColours, ChosenFordColour); // Searches the entire array (FordColours) and sees if the colours that is input by the user matches
                                    if (FordColourIndex >= 0) // If the colour chosen is greater-than or equal to the first index in the array AND matches, output the colour and the position in the array
                                    {
                                        Console.WriteLine(ChosenFordColour + " is found at " + FordColourIndex.ToString() + " position!");
                                            if (ChosenFordColour == "Red") // Nested if statements that will go through all of the colours to inform the user about availability per model
                                            {
                                                Console.WriteLine("This colour is available on both models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The price on the Fiesta is free, but on the Puma, it will cost £775");
                                                string[] FordModelsColourRed = new[] { "1 - Fiesta", "2 - Puma" }; // An array called 'FordModels' that will display all of the models to the user
                                                Console.WriteLine(string.Join(Environment.NewLine, FordModelsColourRed)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                                {
                                                    if (ChosenFordColour == "Red") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen for this model is Red. This colour will not cost any extra."); } } // If the user chooses the colour red, and the Fiesta, the message will be written to the 'CarDetails' file
                                                    else if (ChosenFordColour == "Red") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen for this model is Red. This colour will cost an extra £775."); } } // If the user chooses the colour red, and the Puma, the message will be written to the 'CarDetails' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                // If the user chose the Puma, and the colour red, this will be written to the 'UserBudget' file
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenFordColour == "Red") { if (ChosenModel == 2) { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you have chosen (Red) costs " + ColourRed); BudgetTotal = Budget - ColourRed; sw.Close(); } } } 
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenFordColour == "White")
                                            {
                                                Console.WriteLine("This colour is available on both Ford models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The colour on the Fiesta will cost £250, whereas on the Puma, the colour will cost £275");
                                                string[] FordModelsColourWhite = new[] { "1 - Fiesta", "2 - Puma" }; // An array called 'FordModels' that will display all of the models to the user
                                                Console.WriteLine(string.Join(Environment.NewLine, FordModelsColourWhite)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                                {
                                                    if (ChosenFordColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen for this model is White. This colour will cost an extra £250."); } } // If the user chooses the colour white, and the Fiesta, the message will be written to the 'CarDetails' file
                                                    else if (ChosenFordColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen for this model is White. This colour will cost an extra £275."); } } // If the user chooses the colour white, and the Puma, the message will be written to the 'CarDetails' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt"))
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenFordColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colur you have chosen (White) costs " + ColourWhite); BudgetTotal = Budget - ColourWhite; } } // If the user chose the Fiesta, and the colour white, this will be written to the 'UserBudget' file
                                                    else if (ChosenFordColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (White) costs " + ColourWhitePuma); BudgetTotal = Budget = ColourWhite; } } // If the user chose the Puma, and the colour white, this will be written to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenFordColour == "Black")
                                            {
                                                Console.WriteLine("This colour is available on both Ford models and will both cost £525!");
                                                string[] FordModelsColourBlack = new[] { "1 - Fiesta", "2 - Puma" }; // An array called 'FordModels' that will display all of the models to the user
                                                Console.WriteLine(string.Join(Environment.NewLine, FordModelsColourBlack)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                                {
                                                    if (ChosenFordColour == "Black") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Black. It will cost an extra £525."); } } // If the user chose the Fiesta at the beginning, and the colour black, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenFordColour == "Black") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Black. It will cost an extra £525."); } } // If the user chose the Puma at the beginning, and the colour black, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt"))
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenFordColour == "Black") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen (Black), for this model, will cost " + ColourBlack); BudgetTotal = Budget - ColourBlack; } } // If the user chose the Fiesta, and the colour black, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenFordColour == "Black") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen (Black), for this model, will cost " + ColourBlack); BudgetTotal = Budget - ColourBlack; } }  // If the user chose the Puma, and the colour black, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenFordColour == "Silver")
                                            {
                                                Console.WriteLine("This colour is available on both Ford models and will both cost £525!");
                                                string[] FordModelsColourSilver = new[] { "1 - Fiesta", "2 - Puma" }; // An array called 'FordModels' that will display all of the models to the user
                                                Console.WriteLine(string.Join(Environment.NewLine, FordModelsColourSilver)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                                {
                                                    if (ChosenFordColour == "Silver") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen on this model is Silver. It will cost an extra £525."); } } // If the user chose the Fiesta at the beginning, and the colour silver, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenFordColour == "Silver") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen on this model is Silver. It will cost an extra £525."); } } // If the user chose the Puma at the beginning, and the colour silver, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt"))
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenFordColour == "Silver") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen (Silver), will cost " + ColourSilver); BudgetTotal = Budget - ColourSilver; } } // If the user chose the Fiesta, and the colour silver, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenFordColour == "Silver") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen (Silver), will cost " + ColourSilver); BudgetTotal = Budget - ColourSilver; } } // If the user chose the Puma, and the colour silver, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenFordColour == "Blue")
                                            {
                                                Console.WriteLine("This colour is available on all Ford models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The Fiesta will cost an extra £525!\nThe colour on the Puma is free, so no extra charge!");
                                                string[] FordModelsColourBlue = new[] { "1 - Fiesta", "2 - Puma" }; // An array called 'FordModels' that will display all of the models to the user
                                                Console.WriteLine(string.Join(Environment.NewLine, FordModelsColourBlue)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                                {
                                                    if (ChosenFordColour == "Blue") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Blue. It will cost an extra £525."); } } // If the user chose the Fiesta at the beginning, and the colour blue, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenFordColour == "Blue") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Blue. This colour will not cost any extra."); } } // If the user chose the Puma at the beginning, and the colour blue, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                // If the user chose the Fiesta, and the colour blue, this will write the price of the colour to the 'UserBudget' file
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenFordColour == "Blue") { if (ChosenModel == 1) { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you have chosen (Blue), for this model, will cost " + ColourBlueFiesta); BudgetTotal = Budget - ColourBlueFiesta; sw.Close(); } } } 
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenFordColour == "Grey")
                                            {
                                                Console.WriteLine("This colour is only available on the Puma!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        string FordModel = "Puma"; // An array called 'FordModels' that will display the model that this colour is applicable for
                                                        Console.WriteLine("The " + FordModel + "is the model that supports this colour and it will cost an extra £775!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenFordColour == "Grey") { sw.WriteLine("The colour you have chosen on this model is Grey. It will cost an extra £775."); sw.Close(); } } // If the user chose the Puma at the beginning, and the colour grey, this will write to the 'CarDetails' file if this colour is chosen
                                                        // If the user chose the Puma, and the colour grey, this will write the price of the colour to the 'UserBudget' file
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenFordColour == "Grey") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you have chosen (Grey), for this model, will cost " + ColourGrey); BudgetTotal = Budget - ColourGrey; sw.Close(); } } 
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); FordCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("The colour you have picked is not available!"); } // If the colour doesn't match, then that colour is not available and a message is displayed to the user
                                }
                                Console.WriteLine("The only wheels available for this model are the ones that come with the car, which do not cost extra.");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { sw.WriteLine("The only wheels available for this car are what come with it."); } // Writing the details on the wheels to the 'CarDetails' file
                                Console.WriteLine("There is no option to select different tyres on this model. Whatever is on the car is what is available, and they don't cost extra!\n");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { sw.WriteLine("The only tyres available for this car are what come with it."); } // Writing the details on the tyres to the 'CarDetails' file
                                Console.WriteLine("If you would like, you can also choose any of the following paid extras that are available for your model:");
                                // Any additional extras will be displayed in the array
                                string[] AdditionalExtras = new[] { "1 - Black Roof Rails", "2 - Mini Spare Steel Wheel", "3 - Handsfree Power Tailgate", "4 - Detachable Towbar", "5 - Parking Pack", "6 - Driver Assistance Pack with parking", "7 - 12.3” Full Colour Digital Cluster", "8 - Rear Privacy Glass", "9 - Winter Pack", "10 - Panorama Roof – openable", "11 - Wireless Charging Pad" }; 
                                string[] ExtrasCost = new[] { "£200", "£150", "£600", "£500", "£450", "£900", "£500", "£250", "£300", "£950", "£150" }; // Cost of each extra item
                                Console.WriteLine(String.Join(Environment.NewLine, AdditionalExtras)); // All of the extras are displayed from the array, line by line
                                // Solution to selecting multiple options within an array (code below) has been slightly changed and adapted from the answer posted (by JackJJun-MSFT) from this link: https://docs.microsoft.com/en-us/answers/questions/835275/choose-multiple-options-within-an-array.html
                                List<string> ExtrasList = new(); // A list created called 'ExtrasList'
                                Dictionary<int, string> Dictionary = new(); // A new dictionary called 'Dictionary' - which will repesent the collection of values within the array
                                foreach (string item in AdditionalExtras)
                                { // For each item in the 'AdditionalExtras' array...
                                    int n = Convert.ToInt32(item.Split('-')[0].Trim()); // 1 - An integer called 'n' will convert it to a 32-bit integer. Each item within the array will be split into substrings, and then any whitespace will be trimmed away
                                    string m = item.Split('-')[1].Trim(); // 2 - A string called 'm' and the item will then also be split into substrings, and again, any whitespace will be trimmed away
                                    Dictionary.Add(n, m); // 3 - Finally, the values will be added to the Dictionary
                                }
                                while (true)
                                {
                                    Console.WriteLine("Note: If you want to end your choice selection, please press the speacebar in the console (after a number has been entered), otherwise, please press enter to keep making selections!");
                                    Console.WriteLine("Please select any of the extras that you would like to purchase!");
                                    int ExtraSelection = Convert.ToInt32(Console.ReadLine()); // Integer called 'ExtraSelection' created and will be set based on the users input
                                    // Solution to the below if statemement outputting the chosen extra item and the price was provided by JackJJun-MSFT from this link: https://docs.microsoft.com/en-us/answers/questions/840725/join-two-different-string-arrays-in-c.html
                                    if (Dictionary.ContainsKey(ExtraSelection)) { ExtrasList.Add(Dictionary[ExtraSelection] + " ---- " + ExtrasCost[ExtraSelection - 1]); } // If the Dictionary contains a key from the users input, that key will be added to the 'ExtraList' list, and the cost will be included of that item
                                    else { Console.WriteLine("Please input the correct number!"); } // If an incorrect number is entered by the user (or if the enter key is pressed), display this error message and the program will stop
                                    ConsoleKeyInfo c = Console.ReadKey(); // The info of the console key that was pressed, assign it the variable 'c'
                                    if (c.Key == ConsoleKey.Spacebar) { break; } // If the console key is the Spacebar key, break out of the loop for all of the selected options
                                }
                                Console.WriteLine("Below is your purchase list:");
                                foreach (var item in ExtrasList) { Console.WriteLine(item); } // Display each item in the 'ExtrasList' as well as the cost
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                                {
                                    sw.WriteLine("\nThese are the items you've chose to add to your configuration:");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'CarDetails' file
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt"))
                                {
                                    sw.WriteLine("Here is the breakdown of the extra items chosen and their costs");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'UserBudget' file
                                    Console.WriteLine("There is no way to calculate the price of the extras against the budget you have entered. However, this could be fixed in the future.");
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n");
                                Console.WriteLine("You have now completed building your car!");
                                Console.WriteLine("Note: There is no way of checking that you can afford it or not as that system caused problems so was not implemented.");
                                Boolean DepositConfirmationLoop = false; // A loop to make sure the deposit is paid. Set to false by default
                                while (!DepositConfirmationLoop) // A while loop to confirm if it has been paid
                                {
                                    Console.WriteLine("Before you can purchase it, have you paid your deposit and has it cleared? (Y or N):");
                                    string DepositConfirmation = Console.ReadLine().ToUpper();
                                    switch (DepositConfirmation)
                                    {
                                        case "Y": // If the user has paid their deposit, break out of the loop
                                            Console.WriteLine("You may now confirm your payment!"); DepositConfirmationLoop = true; break;
                                        default: Console.WriteLine("Please make it has been paid before you continue!"); break; // If the user still needs to pay the deposit, go back and ask again
                                    }
                                }
                                Boolean PurchaseConfirmationLoop = false; // A loop ot make sure the purchase confirmation is complete. Set to false by default
                                while (!PurchaseConfirmationLoop)
                                {
                                    Console.WriteLine("Before you confirm your purchase, please note that once you do, you cannot change your mind! Are you happy with your purchase? (Y or N):");
                                    string PurchaseConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (PurchaseConfirmation)
                                    {
                                        case "Y": // If the user is happy with their purchase
                                            Console.WriteLine("You can now pay for your car and confirm your purchase!");
                                            Console.WriteLine("Thank you for using the Car Builder App!"); PurchaseConfirmationLoop = true; break;
                                        default: Console.WriteLine("You can start the program again and build a new car!"); System.Environment.Exit(0); break; // If the user still isn't sure, they can quit the program and start again
                                    }
                                }
                            }
                            else { Console.WriteLine("Please try again!"); } // ...otherwise, this message will appear and it will loop back round to ask the user to select a model again
                        }
                        break;
                    case 2:
                        Boolean BMWModelLoop = false; // A loop to make sure a model chosen from the list - false by default
                        while (!BMWModelLoop) // A while loop to make sure the chosen model matches any from the list (true), else it will loop until this condition is met
                        {
                            Console.WriteLine("You have chosen BMW as your brand!\n");
                            Console.WriteLine("These are the current models you can choose from:");
                            string ChosenBMWModel; // String created for the user to pick out their chosen BMW model
                            List<string> BMWModels = new(5); // A list is created to show all of the BMW models available
                            BMWModels.Add("118i M Sport"); BMWModels.Add("520i M Sport Saloon"); BMWModels.Add("420i M Sport Coupe"); BMWModels.Add("218i M Sport Gran Coupe");
                            BMWModels.Sort(); // Will sort the list in alphabetical order
                            foreach (string a in BMWModels) { Console.WriteLine(a); } // Foreach loop to display all of the models
                            Console.WriteLine("\nPlease select your chosen model: ");
                            ChosenBMWModel = Console.ReadLine().ToUpper(); // The chosen model will be whatever the user types in (caps or lower cases should be allowed)
                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                            {
                                sw.WriteLine("Your car details\n" + "Your chosen model: " + ChosenBMWModel); // The model of car that the user enters should write to the file and can be viewed
                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                            }
                            // if and else if statements for the chosen models
                            if (ChosenBMWModel == "118i M Sport" || ChosenBMWModel == "118i m sport" || ChosenBMWModel == "118I M SPORT") // Allows all three types to be entered by the user
                            {
                                Console.WriteLine("You have chosen the 118i M Sport!"); BMWModelLoop = true; // The loop is true, as the string matched
                                string[] BMW118iMSportEngines = new[] { "1 - Manual", "2 - Automatic DTC Transmission" }; // String array for all the engines for the BMW 118i M Sport
                                Boolean EngineConfirmationLoop = false; // A loop to make sure the user chooses the engine they want - set to false by default
                                while (!EngineConfirmationLoop) // A nested while loop to confirm the engine choice
                                {
                                    Console.WriteLine("These are the engines that you can choose for the BMW 118i M Sport:");
                                    Console.WriteLine(String.Join(Environment.NewLine, BMW118iMSportEngines)); // All of the engines are displayed from the array, line by line
                                    Console.WriteLine("Please either choose 1 or 2 based on your engine choice:");
                                    int ChosenEngine = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenEngine' created and set based on users input on engine selection
                                    if (ChosenEngine == 1) { Console.WriteLine("The engine that you have chosen is the manual engine, which costs £29,290"); } // Nested if and else if statement, if the user enters 1
                                    else if (ChosenEngine == 2) { Console.WriteLine("The engine that you have chosen is the Automatic DTC Transmission, which costs £30,640"); } // If the user enters 2
                                    else { Console.WriteLine("Error! Please enter either 1 or 2!"); } // If the user enters a number other than 1 or 2
                                    int Engine_One = 29290; // The price of the first engine
                                    int Engine_Two = 30640; // The price of the second engine
                                    Console.WriteLine("Are you happy with your chosen engine? (Y or N):"); // Making sure the user is happy with the engine choice
                                    string EngineConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (EngineConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen engine 
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenEngine == 1) { sw.WriteLine("You have chosen the manual engine."); } // If engine 1 was chosen, write this to the 'cardetails' file
                                                else if (ChosenEngine == 2) { sw.WriteLine("You have chosen the Automatic DTC transmission."); } // If engine 2 was chosen, write this to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                            {
                                                sw.WriteLine("Your current budget is: " + Budget);
                                                if (ChosenEngine == 1) { sw.WriteLine("The manual engines costs " + Engine_One); BudgetTotal = Budget - Engine_One; } // The price of engine one will be added to the 'UserBudget' file and can be viewed
                                                else if (ChosenEngine == 2) { sw.WriteLine("The Automatic DTC transmission costs " + Engine_Two); BudgetTotal = Budget - Engine_Two; } // The price of engine one will be added to the 'UserBudget' file and can be viewed
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); EngineConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and select a different engine."); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                string[] BMWColours = new[] { "White", "Black - metallic", "Red - metallic", "Blue - metallic", "Grey - metallic", "White – metallic", "Green – metallic" }; // Array of all colours for all BMW models
                                Array.Sort(BMWColours); // The array will be sorted
                                int ColourBlackMetallic = 595; // An integer (ColourBlackMetallic) has been created and assigned the value of 595
                                int ColourBlackMetallic420i = 695; // An integer (ColourBlueMetallic420i) has been created and assigned the value of 695
                                int ColourBlackMetallic520i = 900; // An integer (ColourBlackMetallic520i) has been created and assigned the value of 900
                                int ColourRedMetallic = 595; // An integer (ColourRedMetallic) has been created and assigned the value of 595
                                int ColourRedMetallic520i = 1995; // An integer (ColourRedMetallic520i) has been created and assigned the value of 1995
                                int ColourBlueMetallic = 595; // An integer (ColourBlueMetallic) has been created and assigned the value of 595
                                int ColourBlueMetallic420i = 695; // An integer (ColourBlueMatallic420i) has been created and assigned the value of 695
                                int ColourBlueMetallic520i = 900; // An integer (ColourBlueMetallic520i) has been created and assigned the value of 900
                                int ColourGreyMetallic = 595; // An integer (ColourGreyMetallic) has been created and assigned the value of 595
                                int ColourGreyMetallic520i = 900; // An integer (ColourGreyMetallic520i) has been created and assigned the value of 900
                                int ColourWhiteMetallic = 695; // An integer (ColourWhiteMetallic) has been created and assigned the value of 695
                                int ColourGreenMetallic = 695; // An integer (ColourGreenMetallic) has been created and assigned the value of 695
                                Console.WriteLine("These are the colours you can choose from:");
                                foreach (string a in BMWColours) { Console.WriteLine(a); } // Using a foreach loop to display all of the elements in the array to the user (to show all of the available colours
                                Boolean BMWCompatibleCombinationLoop = false; // A loop to make sure the colour and model combination matches. Set to false by default
                                while (!BMWCompatibleCombinationLoop) // The while loop to the check the combination
                                {
                                    Console.WriteLine("\nNote 1: Some colours will cost extra if chosen, or might not be avaliable, depending on the model selected!"); // Message to the user about extra cost for certain colours
                                    Console.WriteLine("Note 2: Please enter the chosen colour EXACTLY as it is shown to you, otherwise, the program will not accept it. This is due to a coding fault, but could be fixed in the future!\n");// Another message to the user regarding exact spelling of the words
                                    Console.WriteLine("Please choose a colour: ");
                                    string ChosenBMWColour = Console.ReadLine(); // A local variable called 'ChosenBMWColour' is created and whatever the user types in is set to that variable
                                    int BMWColourIndex = Array.BinarySearch(BMWColours, ChosenBMWColour); // Searches the entire array (BMWColours) and sees if the colours that is input by the user matches
                                    if (BMWColourIndex >= 0) // If the colour chosen is greater-than or equal to the first index in the array AND matches, output the colour and the position in the array
                                    {
                                        Console.WriteLine(ChosenBMWColour + " is found at " + BMWColourIndex.ToString() + " position!");
                                            if (ChosenBMWColour == "White") // Nested if statements that will go through all of the colours to inform the user about availability per model
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("The colour is the standard colour, so will not cost any additional money!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 118i M Sport and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 218i M Sport Gran Coupe and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 420i M Sport Coupe and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 520i M Sport Saloon and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Black - metallic")
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The colour on the 118i M Sport and the 218i M Sport Gran Coupe is an extra £595!\nBut, the 420i M Sport Coupe is slightly more expensive (£695 extra)!\nThe 520i M Sport Saloon is the most expensive (£900 extra)!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £695."); } } // If the user chose the 420i M Sport Coupe and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer                      
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the 118i M Sport, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the 218i M Sport Gran Coupe, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic420i); BudgetTotal = Budget - ColourBlackMetallic420i; } } // If the user chose the 420i M Sport Coupe, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic520i); BudgetTotal = Budget - ColourBlackMetallic520i; } } // If the user chose the 520i M Sport Saloon, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Red - metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 118i M Sport, 520i M Sport Saloon and the 218i M Sport Gran Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The colour will cost £595 extra when applied to the 118i M Sport or the 218i M Sport Gran Coupe!\nWhereas, for the colour to be applied to the 520i M Sport Saloon, it will cost an additional £1,995!");
                                                        string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 520i M Sport Saloon" }; // An array of all the BMW models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £1,995."); } }  // If the user chose the 520i M Sport Saloon and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic); BudgetTotal = Budget - ColourRedMetallic; } } // If the user chose the 118i M Sport and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic); BudgetTotal = Budget - ColourRedMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic520i); BudgetTotal = Budget - ColourRedMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "Blue - metallic")
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The colour on the 118i M Sport and the 218i M Sport Gran Coupe is an extra £595!\nBut, the colour is slightly more expensive on the 420i M Sport Coupe (£695 extra)!\nThe 520i M Sport Saloon is more expensive than that, costing £900 extra!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £695."); } } // If the user chose the 420i M Sport Coupe and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the 118i M Sport and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic420i); BudgetTotal = Budget - ColourBlueMetallic420i; } } // If the user chose the 420i M Sport Coupe and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic520i); BudgetTotal = Budget - ColourBlueMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Grey - metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 218i M Sport Gran Coupe, 520i M Sport Saloon and the 118i M Sport!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The colour will cost £595 extra when applied to the 118i M Sport or the 218i M Sport Gran Coupe!\nThe 520i M Sport Saloon is more expensive than that, costing £900 extra!");
                                                        string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 520i M Sport Saloon" }; // An array of all the BMW models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the 118i M Sport and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic520i); BudgetTotal = Budget - ColourGreyMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "White – metallic")
                                            {
                                                Console.WriteLine("The colour is only available on the 420i M Sport Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        string BMW_Model = "420i M Sport Coupe";
                                                        Console.WriteLine("The " + BMW_Model + "is the model that supports this colour and it will cost an extra £695!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenBMWColour == "White – metallic") { sw.WriteLine("The colour you have chosen is White – metallic. This colour will cost an extra £695."); sw.Close(); } } // If the user chose the 420i M Sport Coupe and the colour white - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                        // If the user chose the 420i M Sport Coupe and the colour white - metallic, this will write to the 'UserBudget' file if this colour is chosen
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenBMWColour == "White metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you have chosen, (White - metallic), will cost " + ColourWhiteMetallic); BudgetTotal = Budget - ColourWhiteMetallic; sw.Close(); } }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "Green – metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 420i M Sport Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        string BMW_Model = "420i M Sport Coupe"; // A string called 'BMW_Model' that will display the model that this colour is applicable for
                                                        Console.WriteLine("The " + BMW_Model + "is the model that supports this colour and it will cost an extra £695!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenBMWColour == "Green – metallic") { sw.WriteLine("The colour you've chosen is Green – metallic. It will cost an extra £695."); sw.Close(); } } // If the user chose the 420i M Sport Coupe and the colour green - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                        // If the user chose the 420i M Sport Coupe and the colour green - metallic, this will write to the 'UserBudget' file if this colour is chosen
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenBMWColour == "Green - metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you've chosen, (Green - metallic), will cost " + ColourGreenMetallic); BudgetTotal = Budget - ColourGreenMetallic; sw.Close(); } } 
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("The colour you have picked is not available"); } // If the colour doesn't match, then that colour is not available and a message is displayed to the user
                                }
                                string[] WheelSelection = new[] { "1 - 18” Double-spoke style 819 M alloy wheels", "2 - 18” Orbit Grey V-spoke style 554 M alloy wheels", "3 - 18” 554M V - spoke style alloy wheels Orbit Grey with Performance tyres", "4 - 19” Bicolour Double-spoke style 552M alloy wheels" }; // String array for all the wheels for this model
                                Boolean WheelConfirmationLoop = false; // A loop to make sure the user chooses the wheels they want - set to false by default
                                while (!WheelConfirmationLoop)
                                {
                                    Console.WriteLine("These are the wheels that you can choose for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, WheelSelection)); // All of the wheels are displayed from the array, line by line
                                    Console.WriteLine("\nPlease choose a number between 1 and 4:");
                                    int ChosenWheels = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenWheels' created and set based on users input on wheel selection
                                    if (ChosenWheels == 1) { Console.WriteLine("The wheels you have chosen are the 18” Double-spoke style 819 M alloy wheels. These wheels don't cost anything extra to have fitted! However, the only tyres available will come with the car!"); } // Nested if and else if statements - if the user enters 1, these wheels are selected
                                    else if (ChosenWheels == 2) { Console.WriteLine("The wheels you have chosen are the 18” Orbit Grey V-spoke style 554 M alloy wheels. These wheels don't cost anything extra to have fitted! However, the only tyres available will come with the car!"); } // If the user enters 2, these wheels are selected
                                    else if (ChosenWheels == 3) { Console.WriteLine("The wheels you have chosen are the 18” 554M V - spoke style alloy wheels Orbit Grey with Performance tyres. These will cost an extra £1,350 to have fitted!"); } // If the user enters 3, these wheels (and tyres) are selected
                                    else if (ChosenWheels == 4) { Console.WriteLine("The wheels you have chosen are the 19” Bicolour Double-spoke style 552M alloy wheels. These wheels will cost an extra £595 to have fitted! However, the only tyres available will come with the car!"); }
                                    else { Console.WriteLine("Error! please enter a number between 1 and 4!"); } // If the user enters a number that isn't between 1 and 4
                                    int Wheels_One = 1350; // The price of the wheels in option 3
                                    int Wheels_Two = 595; // The price of the wheels in option 4
                                    Console.WriteLine("Are you happy with your choice of wheels? (Y or N):"); // Making sure the user is happy with their choice 
                                    string WheelConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (WheelConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen wheel choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenWheels == 1) { sw.WriteLine("The wheels you have chosen, (the 18” Double-spoke style 819 M alloy wheels), will cost nothing extra to be fitted. The only tyres available will come with the car."); } // If choice one for the wheels was chosen, write this to the 'cardetails' file
                                                else if (ChosenWheels == 2) { sw.WriteLine("The wheels you have chosen, (the 18” Orbit Grey V-spoke style 554 M alloy wheels), will cost nothing extra to be fitted. The only tyres available will come with the car."); } // If choice two for the wheels was chosen, write this to the 'cardetails' file 
                                                else if (ChosenWheels == 3) { sw.WriteLine("The wheels you have chosen, (the 18” 554M V - spoke style alloy wheels Orbit Grey with Performance tyres), will cost an extra £1,350 to have fitted. The Performance tyres wil lcome with the chosen wheels."); } // If choice three for the wheels was chosen, write this to the 'cardetails' file
                                                else if (ChosenWheels == 4) { sw.WriteLine("The wheels you have chosen, (the 19” Bicolour Double-spoke style 552M alloy wheels), will cost an extra £595 to have fitted. The only tyres available will come with the car."); } // If choice four for the wheels was chosen, write this to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                            {
                                                sw.WriteLine("Your current budget is: " + Budget);
                                                if (ChosenWheels == 3) { sw.WriteLine("The 18” 554M V - spoke style alloy wheels Orbit Grey with Performance tyres cost " + Wheels_One); BudgetTotal = Budget - Wheels_One; } // The price of the wheels for option 3 will be added to the 'UserBudget' file and can be viewed
                                                else if (ChosenWheels == 4) { sw.WriteLine("The 19” Bicolour Double-spoke style 552M alloy wheels cost " + Wheels_Two); BudgetTotal = Budget - Wheels_Two; } // The price of the wheels for option 4 will be added to the 'UserBudget' file and can be viewed
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); WheelConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and choose different wheels."); break; // The default will assume the uer isn't happy with their choice
                                    }
                                }
                                string[] UpholsterySelection = new[] { "1 - Black Trigon Cloth/Sensatec", "2 - Magma Red with grey highlight Dakota leather with perforations", "3 - Mocha Dakota leather w/ perforations", "4 - Black w/ blue highlight Dakota leather w/ perforations", "5 - Black Dakota leather with perforations" }; // A string array for all of the upholstery available for this model
                                Boolean UpholsteryConfirmationLoop = false; // A loop to make sure the user chooses the upholstery they want - set to false by default
                                while (!UpholsteryConfirmationLoop)
                                {
                                    Console.WriteLine("These are the different upholsteries that you can choose for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, UpholsterySelection)); // All of the different upholsteries are displayed from the array, line by line
                                    Console.WriteLine("\nPlease choose a number between 1 and 5:");
                                    int ChosenUpholstery = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenUpholstery' created and set based on users input on upholstery selection
                                    if (ChosenUpholstery == 1) { Console.WriteLine("The upholstery you have chosen is the Black Trigon Cloth/Sensatec. This costs nothing have applied to the seats."); } // If the user enters 1
                                    else if (ChosenUpholstery == 2) { Console.WriteLine("The upholstery you have chosen is the Magma Red with grey highlight Dakota leather with perforations. This will cost an extra £1,150 to have applied to the seats."); } // If the user enters 2 
                                    else if (ChosenUpholstery == 3) { Console.WriteLine("The upholstery you have chosen is the Mocha Dakota leather w/ perforations. This will cost an extra £1,150 to have applied to the seats."); } // If the user enters 3
                                    else if (ChosenUpholstery == 4) { Console.WriteLine("The upholstery you have chosen is the Black w/ blue highlight Dakota leather w/ perforations. This will cost an extra £1,150 to have applied to the seats."); } // If the user enters 4
                                    else if (ChosenUpholstery == 5) { Console.WriteLine("The upholstery you have chosen is the Black Dakota leather with perforations. This will cost an extra £1,150 to have applied to the seats."); } // If the user enters 5
                                    else { Console.WriteLine("Error! Please enter a number between 1 and 5!"); } // If the user enters a number that isn't between 1 and 5
                                    int Upholstery_Price = 1150; // The price of the upholstery for option 2, 3, 4 and 5
                                    Console.WriteLine("Are you happy with your choice of upholstery? (Y or N):"); // Making sure the user is happy with their choice 
                                    string UpholsteryConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (UpholsteryConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenUpholstery == 1) { sw.WriteLine("The upholstery you have chosen, (Black Trigon Cloth/Sensatec), will cost nothing extra to have it applied to the seats."); } // If choice 1 for the upholstery is chosen by the user, write this to the 'cardetails' file
                                                else if (ChosenUpholstery == 2) { sw.WriteLine("The upholstery you have chosen, (Magma Red with grey highlight Dakota leather with perforations), will cost an extra £1,150 to have applied to the seats."); } // If choice 2 for the upholstery is chosen by the user, write this to the 'cardetails' file
                                                else if (ChosenUpholstery == 3) { sw.WriteLine("The upholstery you have chosen, (Mocha Dakota leather w/ perforations), will cost an extra £1,150 to have applied to the seats."); } // If choice 3 for the upholstery is chosen by the user, write this to the 'cardetails' file
                                                else if (ChosenUpholstery == 4) { sw.WriteLine("The upholstery you have chosen, (Black w/ blue highlight Dakota leather w/ perforations), will cost an extra £1,150 to have applied to the seats."); } // If choice 4 for the upholstery is chosen by the user, write this to the 'cardetails' file
                                                else if (ChosenUpholstery == 5) { sw.WriteLine("The upholstery you have chosen, (Black Dakota leather with perforations), will cost an extra £1,150 to have applied to the seats."); } // If choice 5 for the upholstery is chosen by the user, write this to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                            {
                                                sw.WriteLine("Your current budget is: " + Budget);
                                                if (ChosenUpholstery == 2) { sw.WriteLine("The upholstery (Magma Red with grey highlight Dakota leather with perforations) will cost " + Upholstery_Price); BudgetTotal = Budget - Upholstery_Price; } // The price of the upholstery for option 2 will be added to the 'UserBudget' file and can be viewed
                                                else if (ChosenUpholstery == 3) { sw.WriteLine("The upholstery (Mocha Dakota leather w/ perforations) will cost " + Upholstery_Price); BudgetTotal = Budget - Upholstery_Price; } // The price of the upholstery for option 3 will be added to the 'UserBudget' file and can be viewed
                                                else if (ChosenUpholstery == 4) { sw.WriteLine("The upholstery (Black w/ blue highlight Dakota leather w/ perforations) will cost " + Upholstery_Price); BudgetTotal = Budget - Upholstery_Price; } // The price of the upholstery for option 4 will be added to the 'UserBudget' file and can be viewed
                                                else if (ChosenUpholstery == 5) { sw.WriteLine("The upholstery (Black Dakota leather with perforations) will cost " + Upholstery_Price); BudgetTotal = Budget - Upholstery_Price; } // The price of the upholstery for option 5 will be added to the 'UserBudget' file and can be viewed
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); UpholsteryConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and choose different upholstery."); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                Boolean InteriorTrimConfirmationLoop = false; // A loop to make sure the user chooses the interior trim they want - set to false by default
                                while (!InteriorTrimConfirmationLoop)
                                {
                                    string[] InteriorTrimSelection = new[] { "1 - Illuminated Boston Interior Trim", "2 - Illuminated Berlin Interior Trim" }; // An array of the different interior trims available for this model
                                    Console.WriteLine("These are the different interior trims you have to choose from for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, InteriorTrimSelection)); // All of the different interior trims are displayed from the array, line by line
                                    Console.WriteLine("Please choose either 1 or 2:");
                                    int ChosenInterior = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenInterior' created and set based on users input on interior trim selection
                                    if (ChosenInterior == 1) { Console.WriteLine("The interior trim you have chosen is the Illuminated Boston Interior Trim. This costs nothing to have applied."); } // If the user enters 1
                                    else if (ChosenInterior == 2) { Console.WriteLine("The interior trim you have chosen is the Illuminated Berlin Interior Trim. This cost nothing to have applied."); } // If the user enters 2
                                    else { Console.WriteLine("Error! Please enter either 1 or 2!"); } // If the user doesn't enter 1 or 2
                                    Console.WriteLine("Are you happy with your interior trim? (Y or N):"); // Making sure the user is happy with their choice 
                                    string InteriorTrimConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (InteriorTrimConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(@"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenInterior == 1) { sw.WriteLine("The interior trim you've chosen, (Illuminated Boston Interior Trim), will cost nothing extra to be applied."); } // If choice 1 for the interior trim is chosen by the user, write this to the 'cardetails' file
                                                if (ChosenInterior == 2) { sw.WriteLine("The interior trim you've chosen, (Illuminated Berlin Interior Trim), will cost nothing extra to be applied."); } // If choice 2 for the interior trim is chosen by the user, write this to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); InteriorTrimConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and choose the other interior trim."); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                Console.WriteLine("If you would like, you can also choose any of the following paid extras that are available for your model:");
                                string[] AdditionalExtras = new[] { "1 - Wi-Fi Hotspot", "2 - Larger Fuel Tank", "3 - Space-saver Spare Wheel", "4 - Heated Steering Wheel", "5 - Luggage Net", "6 - Split Folding Rear Seats", "7 - Front Lumbar Support", "8 - M Sport Steering", "9 - Gesture Control", "10 - Sun Protection Glass", "11 - Enhanced Bluetooth with Wireless Charging", "12 - Parking Assistance", 
                                    "13 - Electric Bootlid", "14 - Harman/Kardon Surround Sound Audio System", "15 - Towbar", "16 - Electric Front Seats + Driver Memory", "17 - Panoramic Glass Roof" }; // An array of all of the extras that are available for this model
                                string[] ExtrasCost = new[] { "No added charge", "£50", "£150", "£150", "£150", "£150", "£150", "£150", "£300", "£300", "£350", "£350", "£500", "£750", "£750", "£750", "£1,000" }; // An array of all the prices for all of the additional extras
                                Console.WriteLine(String.Join(Environment.NewLine, AdditionalExtras)); // All of the extras are displayed from the array, line by line
                                // Solution to selecting multiple options within an array (code below) has been slightly changed and adapted from the answer posted (by JackJJun-MSFT) from this link: https://docs.microsoft.com/en-us/answers/questions/835275/choose-multiple-options-within-an-array.html
                                List<string> ExtrasList = new(); // A list created called 'ExtrasList'
                                Dictionary<int, string> Dictionary = new(); // A new dictionary called 'Dictionary' - which will repesent the collection of values within the array
                                foreach (string item in AdditionalExtras)
                                { // For each item in the 'AdditionalExtras' array...
                                    int n = Convert.ToInt32(item.Split('-')[0].Trim()); // 1 - An integer called 'n' will convert it to a 32-bit integer. Each item within the array will be split into substrings, and then any whitespace will be trimmed away
                                    string m = item.Split('-')[1].Trim(); // 2 - A string called 'm' and the item will then also be split into substrings, and again, any whitespace will be trimmed away
                                    Dictionary.Add(n, m); // 3 - Finally, the values will be added to the Dictionary
                                }
                                while (true)
                                {
                                    Console.WriteLine("Note: If you want to end your choice selection, please press the speacebar in the console (after a number has been entered), otherwise, please press enter to keep making selections!");
                                    Console.WriteLine("Please select any of the extras that you would like to purchase!");
                                    int ExtraSelection = Convert.ToInt32(Console.ReadLine()); // Integer called 'ExtraSelection' created and will be set based on the users input
                                    // Solution to the below if statemement outputting the chosen extra item and the price was provided by JackJJun-MSFT from this link: https://docs.microsoft.com/en-us/answers/questions/840725/join-two-different-string-arrays-in-c.html
                                    if (Dictionary.ContainsKey(ExtraSelection)) { ExtrasList.Add(Dictionary[ExtraSelection] + " ---- " + ExtrasCost[ExtraSelection - 1]); } // If the Dictionary contains a key from the users input, that key will be added to the 'ExtraList' list, and the cost will be included of that item
                                    else { Console.WriteLine("Please input the correct number!"); } // If an incorrect number is entered by the user (or if the enter key is pressed), display this error message and the program will stop
                                    ConsoleKeyInfo c = Console.ReadKey(); // The info of the console key that was pressed, assign it the variable 'c'
                                    if (c.Key == ConsoleKey.Spacebar) { break; } // If the console key is the Spacebar key, break out of the loop for all of the selected options
                                }
                                Console.WriteLine("Below is your purchase list:");
                                foreach (var item in ExtrasList) { Console.WriteLine(item); } // Display each item in the 'ExtrasList' as well as the cost
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                {
                                    sw.WriteLine("\nThese are the items you've chose to add to your configuration:");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'CarDetails' file
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                {
                                    sw.WriteLine("Your current budget is: " + Budget);
                                    sw.WriteLine("Here is the breakdown of the extra items chosen and their costs");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'UserBudget' file
                                    Console.WriteLine("There is no way to calculate the price of the extras against the budget you have entered. However, this could be fixed in the future.");
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n");
                                Console.WriteLine("You have now completed building your car!");
                                Console.WriteLine("Note: There is no way of checking that you can afford it or not as that system caused problems so was not implemented.");
                                Boolean DepositConfirmationLoop = false; // A loop to make sure the deposit is paid. Set to false by default
                                while (!DepositConfirmationLoop) // A while loop to confirm if it has been paid
                                {
                                    Console.WriteLine("Before you can purchase it, have you paid your deposit and has it cleared? (Y or N):");
                                    string DepositConfirmation = Console.ReadLine().ToUpper();
                                    switch (DepositConfirmation)
                                    {
                                        case "Y": // If the user has paid their deposit, break out of the loop
                                            Console.WriteLine("You may now confirm your payment!"); DepositConfirmationLoop = true; break;
                                        default: Console.WriteLine("Please make it has been paid before you continue!"); break; // If the user still needs to pay the deposit, go back and ask again
                                    }
                                }
                                Boolean PurchaseConfirmationLoop = false; // A loop ot make sure the purchase confirmation is complete. Set to false by default
                                while (!PurchaseConfirmationLoop)
                                {
                                    Console.WriteLine("Before you confirm your purchase, please note that once you do, you cannot change your mind! Are you happy with your purchase? (Y or N):");
                                    string PurchaseConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (PurchaseConfirmation)
                                    {
                                        case "Y": // If the user is happy with their purchase
                                            Console.WriteLine("You can now pay for your car and confirm your purchase!");
                                            Console.WriteLine("Thank you for using the Car Builder App!"); PurchaseConfirmationLoop = true; break;
                                        default: Console.WriteLine("You can start the program again and build a new car!"); System.Environment.Exit(0); break; // If the user still isn't sure, they can quit the program and start again
                                    }
                                }
                            }
                            else if (ChosenBMWModel == "520i M Sport Saloon" || ChosenBMWModel == "520i m sport saloon" || ChosenBMWModel == "520I M SPORT SALOON") // Allows all three types to be entered by the user
                            {
                                Console.WriteLine("You have chosen the 520i M Sport Saloon!"); BMWModelLoop = true; // The loop is true, as the string matched
                                string BMW_Model = "BMW 520i M Sport Saloon"; // A string for the model
                                string BMWEngine = "Automatic Transmission with Gearshift Paddles"; // A string for the engine for this model
                                int EnginePrice = 43625; // Integer called 'EnginePrice' has been created and assigned the value of 43625
                                Console.WriteLine("The " + BMW_Model + "only has one engine, the " + BMWEngine + ", which will cost £43,625.");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only engine for this model, the " + BMWEngine + ", will cost £43,625"); } // If the user chooses this model, this is the only avaliable engine - so this will be written to the 'cardetails' file
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The only engine for this model, the " + BMWEngine + ", will cost " + EnginePrice); } // If the user chooses this model, this is the only available engine - so this will be written to the 'userbudget' file
                                string[] BMWColours = new[] { "White", "Black - metallic", "Red - metallic", "Blue - metallic", "Grey - metallic", "White – metallic", "Green – metallic" }; // Array of all colours for all BMW models
                                Array.Sort(BMWColours); // The array will be sorted
                                int ColourBlackMetallic = 595; // An integer (ColourBlackMetallic) has been created and assigned the value of 595
                                int ColourBlackMetallic420i = 695; // An integer (ColourBlueMetallic420i) has been created and assigned the value of 695
                                int ColourBlackMetallic520i = 900; // An integer (ColourBlackMetallic520i) has been created and assigned the value of 900
                                int ColourRedMetallic = 595; // An integer (ColourRedMetallic) has been created and assigned the value of 595
                                int ColourRedMetallic520i = 1995; // An integer (ColourRedMetallic520i) has been created and assigned the value of 1995
                                int ColourBlueMetallic = 595; // An integer (ColourBlueMetallic) has been created and assigned the value of 595
                                int ColourBlueMetallic420i = 695; // An integer (ColourBlueMatallic420i) has been created and assigned the value of 695
                                int ColourBlueMetallic520i = 900; // An integer (ColourBlueMetallic520i) has been created and assigned the value of 900
                                int ColourGreyMetallic = 595; // An integer (ColourGreyMetallic) has been created and assigned the value of 595
                                int ColourGreyMetallic520i = 900; // An integer (ColourGreyMetallic520i) has been created and assigned the value of 900
                                int ColourWhiteMetallic = 695; // An integer (ColourWhiteMetallic) has been created and assigned the value of 695
                                int ColourGreenMetallic = 695; // An integer (ColourGreenMetallic) has been created and assigned the value of 695
                                Console.WriteLine("These are the colours you can choose from:");
                                foreach (string a in BMWColours) { Console.WriteLine(a); } // Using a foreach loop to display all of the elements in the array to the user (to show all of the available colours
                                Boolean BMWCompatibleCombinationLoop = false; // A loop to make sure the colour and model combination matches. Set to false by default
                                while (!BMWCompatibleCombinationLoop) // The while loop to the check the combination
                                {
                                    Console.WriteLine("\nNote 1: Some colours will cost extra if chosen, or might not be avaliable, depending on the model selected!"); // Message to the user about extra cost for certain colours
                                    Console.WriteLine("Note 2: Please enter the chosen colour EXACTLY as it is shown to you, otherwise, the program will not accept it. This is due to a coding fault, but could be fixed in the future!\n");// Another message to the user regarding exact spelling of the words
                                    Console.WriteLine("Please choose a colour: ");
                                    string ChosenBMWColour = Console.ReadLine(); // A local variable called 'ChosenBMWColour' is created and whatever the user types in is set to that variable
                                    int BMWColourIndex = Array.BinarySearch(BMWColours, ChosenBMWColour); // Searches the entire array (BMWColours) and sees if the colours that is input by the user matches
                                    if (BMWColourIndex >= 0) // If the colour chosen is greater-than or equal to the first index in the array AND matches, output the colour and the position in the array
                                    {
                                        Console.WriteLine(ChosenBMWColour + " is found at " + BMWColourIndex.ToString() + " position!");
                                            if (ChosenBMWColour == "White") // Nested if statements that will go through all of the colours to inform the user about availability per model
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("The colour is the standard colour, so will not cost any additional money!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 118i M Sport and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 218i M Sport Gran Coupe and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 420i M Sport Coupe and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 520i M Sport Saloon and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Black - metallic")
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The colour on the 118i M Sport and the 218i M Sport Gran Coupe is an extra £595!\nBut, the 420i M Sport Coupe is slightly more expensive (£695 extra)!\nThe 520i M Sport Saloon is the most expensive (£900 extra)!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £695."); } } // If the user chose the 420i M Sport Coupe and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer                      
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the 118i M Sport, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the 218i M Sport Gran Coupe, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic420i); BudgetTotal = Budget - ColourBlackMetallic420i; } } // If the user chose the 420i M Sport Coupe, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic520i); BudgetTotal = Budget - ColourBlackMetallic520i; } } // If the user chose the 520i M Sport Saloon, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Red - metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 118i M Sport, 520i M Sport Saloon and the 218i M Sport Gran Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The colour will cost £595 extra when applied to the 118i M Sport or the 218i M Sport Gran Coupe!\nWhereas, for the colour to be applied to the 520i M Sport Saloon, it will cost an additional £1,995!");
                                                        string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 520i M Sport Saloon" }; // An array of all the BMW models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £1,995."); } }  // If the user chose the 520i M Sport Saloon and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic); BudgetTotal = Budget - ColourRedMetallic; } } // If the user chose the 118i M Sport and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic); BudgetTotal = Budget - ColourRedMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic520i); BudgetTotal = Budget - ColourRedMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "Blue - metallic")
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The colour on the 118i M Sport and the 218i M Sport Gran Coupe is an extra £595!\nBut, the colour is slightly more expensive on the 420i M Sport Coupe (£695 extra)!\nThe 520i M Sport Saloon is more expensive than that, costing £900 extra!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £695."); } } // If the user chose the 420i M Sport Coupe and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the 118i M Sport and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic420i); BudgetTotal = Budget - ColourBlueMetallic420i; } } // If the user chose the 420i M Sport Coupe and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic520i); BudgetTotal = Budget - ColourBlueMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Grey - metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 218i M Sport Gran Coupe, 520i M Sport Saloon and the 118i M Sport!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The colour will cost £595 extra when applied to the 118i M Sport or the 218i M Sport Gran Coupe!\nThe 520i M Sport Saloon is more expensive than that, costing £900 extra!");
                                                        string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 520i M Sport Saloon" }; // An array of all the BMW models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the 118i M Sport and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic520i); BudgetTotal = Budget - ColourGreyMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "White – metallic")
                                            {
                                                Console.WriteLine("The colour is only available on the 420i M Sport Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        string BMW_Model_420i_White = "420i M Sport Coupe";
                                                        Console.WriteLine("The " + BMW_Model_420i_White + "is the model that supports this colour and it will cost an extra £695!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenBMWColour == "White – metallic") { sw.WriteLine("The colour you have chosen is White – metallic. This colour will cost an extra £695."); sw.Close(); } } // If the user chose the 420i M Sport Coupe and the colour white - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                        // If the user chose the 420i M Sport Coupe and the colour white - metallic, this will write to the 'UserBudget' file if this colour is chosen
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) {  if (ChosenBMWColour == "White metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you have chosen, (White - metallic), will cost " + ColourWhiteMetallic); BudgetTotal = Budget - ColourWhiteMetallic; sw.Close(); } } 
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "Green – metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 420i M Sport Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        string BMW_Model_420i_Green = "420i M Sport Coupe"; // A string called 'BMW_Model' that will display the model that this colour is applicable for
                                                        Console.WriteLine("The " + BMW_Model_420i_Green + "is the model that supports this colour and it will cost an extra £695!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenBMWColour == "Green – metallic") { sw.WriteLine("The colour you've chosen is Green – metallic. It will cost an extra £695."); sw.Close(); } } // If the user chose the 420i M Sport Coupe and the colour green - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                        // If the user chose the 420i M Sport Coupe and the colour green - metallic, this will write to the 'UserBudget' file if this colour is chosen
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenBMWColour == "Green - metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you've chosen, (Green - metallic), will cost " + ColourGreenMetallic); BudgetTotal = Budget - ColourGreenMetallic; sw.Close(); } }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("The colour you have picked is not available"); } // If the colour doesn't match, then that colour is not available and a message is displayed to the user
                                }
                                Boolean WheelConfirmationLoop = false; // A loop to make sure that they has selected the wheels that they want. Set to false by default.
                                while (!WheelConfirmationLoop)
                                {
                                    string[] WheelSelection = new[] { "1 - 19” Bicolour Jet Black Y-spoke style 845 M light alloy wheels", "2 - 20” Bicolour Jet Black Y-spoke style 846 M light alloy wheels with run-flat tyres" }; // String array for all the wheels for this model
                                    Console.WriteLine("These are the wheels that you can choose for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, WheelSelection)); // All of the wheels are displayed from the array, line by line
                                    Console.WriteLine("\nPlease choose either 1 or 2:");
                                    int ChosenWheels = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenWheels' created and set based on users input on wheel selection
                                    if (ChosenWheels == 1) { Console.WriteLine("The wheels you have have chosen are the 19” Bicolour Jet Black Y-spoke style 845 M light alloy wheels. These wheels don't cost anything extra to have fitted! However, the only tyres available will come with the car!"); } // Nested if and else if statements - if the user enters 1, these wheels are selected
                                    else if (ChosenWheels == 2) { Console.WriteLine("The wheels you have chosen are the 20” Bicolour Jet Black Y-spoke style 846 M light alloy wheels with run-flat tyres. These will cost an extra £995 to have fitted!"); } // If the user enters 2, these wheels (and tyres) are selected
                                    else { Console.WriteLine("Error! Please enter either 1 or 2!"); } // If the user enters a number that isn't 1 or 2
                                    int WheelsPrice = 995; // An integer called 'WheelsPrice' has been created and assigned the value of 995 for choice 2 during the wheels selection 
                                    Console.WriteLine("Are you happy with with your chosen wheels? (Y or N):"); // Making sure the user is happy with the wheel choice
                                    string WheelConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (WheelConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenWheels == 1) { sw.WriteLine("The wheels you've chosen are the 19” Bicolour Jet Black Y-spoke style 845 M light alloy wheels. These wheels will cost nothing extra to be fitted. The only tyres available will come with the car."); } // If the user chooses option 1 for wheels, this will be written to the 'cardetails' file
                                                else if (ChosenWheels == 2) { sw.WriteLine("The wheels you've chosen are the 20” Bicolour Jet Black Y-spoke style 846 M light alloy wheels with run-flat tyres. These wheels will cost an extra £995 to be fitted."); } // If the user chooses option 2 for the wheels, this will be written to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be viewed after
                                                // If the user picked tyre option 2, then the wheels and the price will be written to the 'userbudget' file
                                            { if (ChosenWheels == 2) { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The wheels you've chosen, (the 20” Bicolour Jet Black Y-spoke style 846 M light alloy wheels with run-flat tyres), will cost " + WheelsPrice); BudgetTotal = Budget - WheelsPrice; sw.Close(); } } 
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); WheelConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and choose the other wheels."); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                Boolean UpholsteryConfirmationLoop = false; // A loop to make sure that they have selected the upholstery that they want. Set to false by default.
                                while (!UpholsteryConfirmationLoop)
                                {
                                    string[] UpholsterySelection = new[] { "1 - Ivory White Dakota Leather", "2 - Black Dakota Leather", "3 - Black Dakota Leather with Blue Contrast Stitching", "4 - Cognac Dakota Leather" }; // A string array for all of the upholstery available for this model
                                    Console.WriteLine("These are the different upholsteries that you can choose for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, UpholsterySelection)); // All of the different upholsteries are displayed from the array, line by line
                                    Console.WriteLine("\nPlease choose a number between 1 and 4:");
                                    int ChosenUpholstery = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenUpholstery' created and set based on users input on upholstery selection
                                    if (ChosenUpholstery == 1) { Console.WriteLine("The upholsery you have chosen is the Ivory White Dakota Leather. This costs nothing have applied to the seats."); } // If the user enters 1
                                    else if (ChosenUpholstery == 2) { Console.WriteLine("The upholsery you have chosen is the Black Dakota Leather. This costs nothing have applied to the seats."); } // If the user enters 2
                                    else if (ChosenUpholstery == 3) { Console.WriteLine("The upholsery you have chosen is the Black Dakota Leather with Blue Contrast Stitching. This costs nothing have applied to the seats."); } // If the user enters 3
                                    else if (ChosenUpholstery == 4) { Console.WriteLine("The upholsery you have chosen is the Cognac Dakota Leather. This costs nothing have applied to the seats."); } // If the user enters 4
                                    else { Console.WriteLine("Error! Please enter a number between 1 and 4!"); } // If the user enters a number that isn't between 1 and 4
                                    Console.WriteLine("Are you happy with your choice of upholstery? (Y or N):"); // Making sure the user is happy with their choice 
                                    string UpholsteryConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (UpholsteryConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                sw.WriteLine("Your current budget is: " + Budget);
                                                if (ChosenUpholstery == 1) { sw.WriteLine("The upholstery you have chosen, (Ivory White Dakota Leather), will cost nothing extra to have applied to the seats."); } // If the user chooses option 1 for the upholstery, this will be written to the 'cardetails' file
                                                else if (ChosenUpholstery == 2) { sw.WriteLine("The upholsetry you have chosen, (Black Dakota Leather), will cost nothing extra to have applied to the seats."); } // If the user chooses option 2 for the upholstery, this will be written to the 'cardetails' file
                                                else if (ChosenUpholstery == 3) { sw.WriteLine("The upholsetry you have chosen, (Black Dakota Leather with Blue Contrast Stitching), will cost nothing extra to have applied to the seats."); } // If the user chooses option 3 for the upholstery, this will be written to the 'cardetails' file
                                                else if (ChosenUpholstery == 4) { sw.WriteLine("The upholsetry you have chosen, (Cognac Dakota Leather), will cost nothing extra to have applied to the seats."); } // If the user chooses option 4 forthe upholstery, this will be written to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); UpholsteryConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and choose another upholstery."); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                Boolean InteriorTrimConfirmationLoop = false; // A loop to make sure that they have selected the upholstery that they want. Set to false by default.
                                while (!InteriorTrimConfirmationLoop)
                                {
                                    string[] InteriorTrimSelection = new[] { "1 - Aluminium Rhombicle Smoke Grey with highlight trim finisher Pearl Chrome", "2 - Ash Trunkwood open-pored Fine-wood with highlight trim finisher Pearl Chrome", "3 - Fineline Ridge Fine-wood with trim finisher Pearl Chrome", "4 - Individual Piano Black Interior Trim" }; // An array of the different interior trims available for this model
                                    Console.WriteLine("These are the different interior trims you have to choose from for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, InteriorTrimSelection)); // All of the different interior trims are displayed from the array, line by line
                                    Console.WriteLine("\nPlease choose a number between 1 and 4:");
                                    int ChosenInterior = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenInterior' created and set based on users input on interior trim selection
                                    if (ChosenInterior == 1) { Console.WriteLine("The interior trim you have chosen is the Aluminium Rhombicle Smoke Grey with highlight trim finisher Pearl Chrome. This costs nothing to have applied."); } // If the user enters 1
                                    else if (ChosenInterior == 2) { Console.WriteLine("The interior trim you have chosen is the Ash Trunkwood open-pored Fine-wood with highlight trim finisher Pearl Chrome. This will cost an extra £360 to have applied."); } // If the user enters 2
                                    else if (ChosenInterior == 3) { Console.WriteLine("The interior trim you have chosen is the Fineline Ridge Fine-wood with trim finisher Pearl Chrome. This will cost an extra £360 to have applied."); } // If the user enters 3
                                    else if (ChosenInterior == 4) { Console.WriteLine("The interior trim you have chosen is the Individual Piano Black Interior Trim. This will cost an extra £560 to have applied."); } // If the user enters 4
                                    else { Console.WriteLine("Error! Please enter a number between 1 and 4!"); } // If the user enters a number that isn't between 1 and 4
                                    int InteriorTrimOne = 360; // An integer called 'InteriorTrimOne' has been created and assigned the value of 360
                                    int InteriorTrimTwo = 560; // An integer called 'InteriorTrimOne' has been created and assigned the value of 560
                                    Console.WriteLine("Are you happy with your choice of interior trim? (Y or N):"); // Making sure the user is happy with their choice 
                                    string InteriorTrimConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (InteriorTrimConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen interior trim
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenInterior == 1) { sw.WriteLine("The interior trim you've chosen, (Aluminium Rhombicle Smoke Grey with highlight trim finisher Pearl Chrome), will cost nothing to have applied."); } // If the user chooses option 1 for the interior trim, this will be written to the 'cardetails' file 
                                                else if (ChosenInterior == 2) { sw.WriteLine("The interior trim you've chosen, (Ash Trunkwood open-pored Fine-wood with highlight trim finisher Pearl Chrome), will cost an extra £360 to have applied."); } // If the user chooses option 2 for the interior trim, this will be written to the 'cardetails' file 
                                                else if (ChosenInterior == 3) { sw.WriteLine("The interior trim you've chosen, (Fineline Ridge Fine-wood with trim finisher Pearl Chrome), will cost an extra £360 to have applied."); } // If the user chooses option 3 for the interior trim, this will be written to the 'cardetails' file 
                                                else if (ChosenInterior == 4) { sw.WriteLine("The interior trim you've chosen, (Individual Piano Black Interior Trim), will cost an extra £560 to have applied."); } // If the user chooses option 4 for the interior trim, this will be written to the 'cardetails' file 
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be viewed after
                                            {
                                                sw.WriteLine("Your current budget is: " + Budget);
                                                if (ChosenInterior == 2) { sw.WriteLine("The interior trim you have chosen is the Ash Trunkwood open-pored Fine-wood with highlight trim finisher Pearl Chrome, which will cost an extra  " + InteriorTrimOne + " to have applied."); BudgetTotal = Budget - InteriorTrimOne; } // If the user chooses option 2 for the interior trim, this will be written to the 'userbudget' file
                                                else if (ChosenInterior == 3) { sw.WriteLine("The interior trim you have chosen is the Fineline Ridge Fine-wood with trim finisher Pearl Chrome, which will cost an extra " + InteriorTrimOne + " to have applied."); BudgetTotal = Budget - InteriorTrimOne; } // If the user chooses option 3 for the interior trim, this will be written to the 'userbudget' file
                                                else if (ChosenInterior == 4) { sw.WriteLine("The interior trim you have chosen is the Individual Piano Black Interior Trim, which will cost an extra " + InteriorTrimTwo + " to have applied."); BudgetTotal = Budget - InteriorTrimTwo; } // If the user chooses option 4 for the interior trim, this will be written to the 'userbudget' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); InteriorTrimConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and pick a different interiot trim."); break;
                                    }
                                }
                                string[] AdditionalExtras = new[] { "1 - Sport Leather Steering Wheel", "2 - Front Comfort Seats", "3 - Additional 12V socket", "4 - Run-flat tyres", "5 - Front and Rear Parking Sensors", "6 - Live Cockpit Plus", "7 - Heated Steering Wheel", "8 - BMW Individual Lights Shadow Line", "9 - Sun Protection Glass", "10 - Split Folding Rear Seats", "11 - Accessory Trackstar", "12 - Leather Dashboard", 
                                    "13 - Harman/Kardon Surround Sound Audio System", "14 - Towbar", "15 - Laserlights", "16 - Electric Glass Sunroof", "17 - Anthracite Alcantara Headlining", "18 - M Electric Front Sport Seats", "19 - Bower & Wilkins Diamond Surround Sound Audio System" }; // An array of all of the extras that are available for this model
                                string[] ExtrasCost = new[] { "No added charge", "No added charge", "No added charge", "No added charge", "No added charge", "No added charge", "£270", "£350", "£390", "£395", "£500", "£575", "£820", "£995", "£1,000", "£1,095", "£1,100", "£2,095", "£4,220" }; // An array of all the prices for all of the additional extras
                                Console.WriteLine(String.Join(Environment.NewLine, AdditionalExtras)); // All of the extras are displayed from the array, line by line
                                // Solution to selecting multiple options within an array (code below) has been slightly changed and adapted from the answer posted (by JackJJun-MSFT) from this link: https://docs.microsoft.com/en-us/answers/questions/835275/choose-multiple-options-within-an-array.html
                                List<string> ExtrasList = new(); // A list created called 'ExtrasList'
                                Dictionary<int, string> Dictionary = new(); // A new dictionary called 'Dictionary' - which will repesent the collection of values within the array
                                foreach (string item in AdditionalExtras)
                                { // For each item in the 'AdditionalExtras' array...
                                    int n = Convert.ToInt32(item.Split('-')[0].Trim()); // 1 - An integer called 'n' will convert it to a 32-bit integer. Each item within the array will be split into substrings, and then any whitespace will be trimmed away
                                    string m = item.Split('-')[1].Trim(); // 2 - A string called 'm' and the item will then also be split into substrings, and again, any whitespace will be trimmed away
                                    Dictionary.Add(n, m); // 3 - Finally, the values will be added to the Dictionary
                                }
                                while (true)
                                {
                                    Console.WriteLine("Note: If you want to end your choice selection, please press the speacebar in the console (after a number has been entered), otherwise, please press enter to keep making selections!");
                                    Console.WriteLine("Please select any of the extras that you would like to purchase!");
                                    int ExtraSelection = Convert.ToInt32(Console.ReadLine()); // Integer called 'ExtraSelection' created and will be set based on the users input
                                    // Solution to the below if statemement outputting the chosen extra item and the price was provided by JackJJun-MSFT from this link: https://docs.microsoft.com/en-us/answers/questions/840725/join-two-different-string-arrays-in-c.html
                                    if (Dictionary.ContainsKey(ExtraSelection)) { ExtrasList.Add(Dictionary[ExtraSelection] + " ---- " + ExtrasCost[ExtraSelection - 1]); } // If the Dictionary contains a key from the users input, that key will be added to the 'ExtraList' list, and the cost will be included of that item
                                    else { Console.WriteLine("Please input the correct number!"); } // If an incorrect number is entered by the user (or if the enter key is pressed), display this error message and the program will stop
                                    ConsoleKeyInfo c = Console.ReadKey(); // The info of the console key that was pressed, assign it the variable 'c'
                                    if (c.Key == ConsoleKey.Spacebar) { break; } // If the console key is the Spacebar key, break out of the loop for all of the selected options
                                }
                                Console.WriteLine("Below is your purchase list:");
                                foreach (var item in ExtrasList) { Console.WriteLine(item); } // Display each item in the 'ExtrasList' as well as the cost
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                {
                                    sw.WriteLine("\nThese are the items you've chose to add to your configuration:");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'CarDetails' file
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                {
                                    sw.WriteLine("Here is the breakdown of the extra items chosen and their costs");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'UserBudget' file
                                    Console.WriteLine("There is no way to calculate the price of the extras against the budget you have entered. However, this could be fixed in the future.");
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n");
                                Console.WriteLine("You have now completed building your car!");
                                Console.WriteLine("Note: There is no way of checking that you can afford it or not as that system caused problems so was not implemented.");
                                Console.WriteLine("Before you can purchase it, have you paid your deposit and has it cleared? (Y or N):");
                                string DepositConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                Boolean DepositConfirmationLoop = false; // A loop to make sure the deposit is paid. Set to false by default
                                while (!DepositConfirmationLoop) // A while loop to confirm if it has been paid
                                {
                                    switch (DepositConfirmation)
                                    {
                                        case "Y": // If the user has paid their deposit, break out of the loop
                                            Console.WriteLine("You may now confirm your payment!"); DepositConfirmationLoop = true; break;
                                        default: Console.WriteLine("Please make it has been paid before you continue!"); break; // If the user still needs to pay the deposit, go back and ask again
                                    }
                                }
                                Console.WriteLine("Before you confirm your purchase, please note that once you do, you cannot change your mind! Are you happy with your purchase? (Y or N):");
                                string PurchaseConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                Boolean PurchaseConfirmationLoop = false; // A loop to make sure the purchase confirmation is complete. Set to false by default
                                while (!PurchaseConfirmationLoop)
                                {
                                    switch (PurchaseConfirmation)
                                    {
                                        case "Y": // If the user is happy with their purchase
                                            Console.WriteLine("You can now pay for your car and confirm your purchase!");
                                            Console.WriteLine("Thank you for using the Car Builder App!"); PurchaseConfirmationLoop = true; break;
                                        default: Console.WriteLine("You can start the program again and build a new car!"); System.Environment.Exit(0); break; // If the user still isn't sure, they can quit the program and start again
                                    }
                                }
                            }
                            else if (ChosenBMWModel == "420i M Sport Coupe" || ChosenBMWModel == "420i m sport coupe" || ChosenBMWModel == "420I M SPORT COUPE") // Allows all three types to be entered by the user
                            {
                                Console.WriteLine("You have chosen the 420i M Sport Coupe!"); BMWModelLoop = true; // The loop is true, as the string matched
                                string BMW_Model = "BMW 520i M Sport Coupe"; // A string for the model
                                string BMWEngine = "Sport Automatic Transmission with Gearshift Paddles"; // A string for the engine for this model
                                int EnginePrice = 40465; // Integer called 'EnginePrice' has been created and assigned the value of 40465
                                Console.WriteLine("The " + BMW_Model + "only has one engine, the " + BMWEngine + ", which will cost £40,465.");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only engine for this model, the " + BMWEngine + ", will cost £40,465"); sw.Close(); } // If the user chooses this model, this is the only avaliable engine - so this will be written to the 'cardetails' file
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The only engine for this model, the " + BMWEngine + ", will cost " + EnginePrice); BudgetTotal = Budget - EnginePrice; sw.Close(); } // If the user chooses this model, this is the only available engine - so this will be written to the 'userbudget' file
                                string[] BMWColours = new[] { "White", "Black - metallic", "Red - metallic", "Blue - metallic", "Grey - metallic", "White – metallic", "Green – metallic" }; // Array of all colours for all BMW models
                                Array.Sort(BMWColours); // The array will be sorted
                                int ColourBlackMetallic = 595; // An integer (ColourBlackMetallic) has been created and assigned the value of 595
                                int ColourBlackMetallic420i = 695; // An integer (ColourBlueMetallic420i) has been created and assigned the value of 695
                                int ColourBlackMetallic520i = 900; // An integer (ColourBlackMetallic520i) has been created and assigned the value of 900
                                int ColourRedMetallic = 595; // An integer (ColourRedMetallic) has been created and assigned the value of 595
                                int ColourRedMetallic520i = 1995; // An integer (ColourRedMetallic520i) has been created and assigned the value of 1995
                                int ColourBlueMetallic = 595; // An integer (ColourBlueMetallic) has been created and assigned the value of 595
                                int ColourBlueMetallic420i = 695; // An integer (ColourBlueMetallic420i) has been created and assigned the value of 695
                                int ColourBlueMetallic520i = 900; // An integer (ColourBlueMetallic520i) has been created and assigned the value of 900
                                int ColourGreyMetallic = 595; // An integer (ColourGreyMetallic) has been created and assigned the value of 595
                                int ColourGreyMetallic520i = 900; // An integer (ColourGreyMetallic520i) has been created and assigned the value of 900
                                int ColourWhiteMetallic = 695; // An integer (ColourWhiteMetallic) has been created and assigned the value of 695
                                int ColourGreenMetallic = 695; // An integer (ColourGreenMetallic) has been created and assigned the value of 695
                                Console.WriteLine("These are the colours you can choose from:");
                                foreach (string a in BMWColours) { Console.WriteLine(a); } // Using a foreach loop to display all of the elements in the array to the user (to show all of the available colours
                                Boolean BMWCompatibleCombinationLoop = false; // A loop to make sure the colour and model combination matches. Set to false by default
                                while (!BMWCompatibleCombinationLoop) // The while loop to the check the combination
                                {
                                    Console.WriteLine("\nNote 1: Some colours will cost extra if chosen, or might not be avaliable, depending on the model selected!"); // Message to the user about extra cost for certain colours
                                    Console.WriteLine("Note 2: Please enter the chosen colour EXACTLY as it is shown to you, otherwise, the program will not accept it. This is due to a coding fault, but could be fixed in the future!\n");// Another message to the user regarding exact spelling of the words
                                    Console.WriteLine("Please choose a colour: ");
                                    string ChosenBMWColour = Console.ReadLine(); // A local variable called 'ChosenBMWColour' is created and whatever the user types in is set to that variable
                                    int BMWColourIndex = Array.BinarySearch(BMWColours, ChosenBMWColour); // Searches the entire array (BMWColours) and sees if the colours that is input by the user matches
                                    if (BMWColourIndex >= 0) // If the colour chosen is greater-than or equal to the first index in the array AND matches, output the colour and the position in the array
                                    {
                                        Console.WriteLine(ChosenBMWColour + " is found at " + BMWColourIndex.ToString() + " position!");
                                            if (ChosenBMWColour == "White") // Nested if statements that will go through all of the colours to inform the user about availability per model
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("The colour is the standard colour, so will not cost any additional money!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 118i M Sport and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 218i M Sport Gran Coupe and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 420i M Sport Coupe and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 520i M Sport Saloon and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Black - metallic")
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The colour on the 118i M Sport and the 218i M Sport Gran Coupe is an extra £595!\nBut, the 420i M Sport Coupe is slightly more expensive (£695 extra)!\nThe 520i M Sport Saloon is the most expensive (£900 extra)!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £695."); } } // If the user chose the 420i M Sport Coupe and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer                      
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the 118i M Sport, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the 218i M Sport Gran Coupe, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic420i); BudgetTotal = Budget - ColourBlackMetallic420i; } } // If the user chose the 420i M Sport Coupe, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic520i); BudgetTotal = Budget - ColourBlackMetallic520i; } } // If the user chose the 520i M Sport Saloon, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Red - metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 118i M Sport, 520i M Sport Saloon and the 218i M Sport Gran Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The colour will cost £595 extra when applied to the 118i M Sport or the 218i M Sport Gran Coupe!\nWhereas, for the colour to be applied to the 520i M Sport Saloon, it will cost an additional £1,995!");
                                                        string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 520i M Sport Saloon" }; // An array of all the BMW models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £1,995."); } }  // If the user chose the 520i M Sport Saloon and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic); BudgetTotal = Budget - ColourRedMetallic; } } // If the user chose the 118i M Sport and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic); BudgetTotal = Budget - ColourRedMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic520i); BudgetTotal = Budget - ColourRedMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "Blue - metallic")
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The colour on the 118i M Sport and the 218i M Sport Gran Coupe is an extra £595!\nBut, the colour is slightly more expensive on the 420i M Sport Coupe (£695 extra)!\nThe 520i M Sport Saloon is more expensive than that, costing £900 extra!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £695."); } } // If the user chose the 420i M Sport Coupe and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the 118i M Sport and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic420i); BudgetTotal = Budget - ColourBlueMetallic420i; } } // If the user chose the 420i M Sport Coupe and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic520i); BudgetTotal = Budget - ColourBlueMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Grey - metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 218i M Sport Gran Coupe, 520i M Sport Saloon and the 118i M Sport!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The colour will cost £595 extra when applied to the 118i M Sport or the 218i M Sport Gran Coupe!\nThe 520i M Sport Saloon is more expensive than that, costing £900 extra!");
                                                        string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 520i M Sport Saloon" }; // An array of all the BMW models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the 118i M Sport and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic520i); BudgetTotal = Budget - ColourGreyMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "White – metallic")
                                            {
                                                Console.WriteLine("The colour is only available on the 420i M Sport Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        string BMW_Model_420i_White = "420i M Sport Coupe";
                                                        Console.WriteLine("The " + BMW_Model_420i_White + "is the model that supports this colour and it will cost an extra £695!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenBMWColour == "White – metallic") { sw.WriteLine("The colour you have chosen is White – metallic. This colour will cost an extra £695."); sw.Close(); } } // If the user chose the 420i M Sport Coupe and the colour white - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                        // If the user chose the 420i M Sport Coupe and the colour white - metallic, this will write to the 'UserBudget' file if this colour is chosen
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenBMWColour == "White metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you have chosen, (White - metallic), will cost " + ColourWhiteMetallic); BudgetTotal = Budget - ColourWhiteMetallic; sw.Close(); } } 
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "Green – metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 420i M Sport Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        string BMW_Model_420i_Green = "420i M Sport Coupe"; // A string called 'BMW_Model' that will display the model that this colour is applicable for
                                                        Console.WriteLine("The " + BMW_Model_420i_Green + "is the model that supports this colour and it will cost an extra £695!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenBMWColour == "Green – metallic") { sw.WriteLine("The colour you've chosen is Green – metallic. It will cost an extra £695."); sw.Close(); } } // If the user chose the 420i M Sport Coupe and the colour green - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                        // If the user chose the 420i M Sport Coupe and the colour green - metallic, this will write to the 'UserBudget' file if this colour is chosen
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenBMWColour == "Green - metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you've chosen, (Green - metallic), will cost " + ColourGreenMetallic); BudgetTotal = Budget - ColourGreenMetallic; sw.Close(); } } 
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("The colour you have picked is not available"); } // If the colour doesn't match, then that colour is not available and a message is displayed to the user
                                }
                                Boolean WheelSelectionLoop = false; // A loop to make sure that they has selected the wheels that they want. Set to false by default.
                                while (!WheelSelectionLoop)
                                {
                                    string[] WheelSelection = new[] { "1 - 18” Bicolour Jet Black Double-spoke style 848 M light alloy wheels", "2 - 19” Bicolour Jet Black Double spoke style 797 M light alloy wheels", "3 - 19” Bicolour Orbit Grey Double-spoke style 793 BMW Individual alloy wheels with run-flat tyres" }; // String array for all the wheels for this model
                                    Console.WriteLine("These are the wheels that you can choose for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, WheelSelection)); // All of the wheels are displayed from the array, line by line
                                    Console.WriteLine("\nPlease enter a number between 1 and 3:");
                                    int ChosenWheels = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenWheels' created and set based on users input on wheel selection
                                    if (ChosenWheels == 1) { Console.WriteLine("The wheels you have chosen are the 18” Bicolour Jet Black Double-spoke style 848 M light alloy wheels. These wheels don't cost anything extra to have fitted! However, the only tyres available will come with the car!"); } // Nested if and else if statements - if the user enters 1, these wheels are selected
                                    else if (ChosenWheels == 2) { Console.WriteLine("The wheels you have chosen are the 19” Bicolour Jet Black Double spoke style 797 M light alloy wheels. These wheels don't cost anything extra to have fitted! However, the only tyres available will come with the car!"); } // If the user enters 2, these wheels are selected
                                    else if (ChosenWheels == 3) { Console.WriteLine("The wheels you have chosen are the 19” Bicolour Orbit Grey Double-spoke style 793 BMW Individual alloy wheels with run-flat tyres. These will cost an extra £750 to have fitted!"); } // If the user enters 3, these wheels (and tyres) are selected
                                    else { Console.WriteLine("Error! Please enter a number between 1 and 3!"); } // If the number entered isn't between 1 and 3
                                    int WheelPrice = 750; // A price for the wheels (for option 3) - created and assigned a value of 750 
                                    Console.WriteLine("Are you happy with with your chosen wheels? (Y or N):"); // Making sure the user is happy with the wheel choice
                                    string WheelConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (WheelConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenWheels == 1) { sw.WriteLine("The wheels you've chosen, (the 18” Bicolour Jet Black Double-spoke style 848 M light alloy wheels), will cost nothing extra to have fitted. The only tyres available will come with the car."); } // If the user chooses option 1 for wheels, this will be written to the 'cardetails' file
                                                else if (ChosenWheels == 2) { sw.WriteLine("The wheels you've chosen, (the 19” Bicolour Jet Black Double spoke style 797 M light alloy wheels), will cost nothing extra to have fitted. The only tyres available will come with the car."); } // If the user chooses option 2 for wheels, this will be written to the 'cardetails' file
                                                else if (ChosenWheels == 3) { sw.WriteLine("The wheels you've chosen, (the 19” Bicolour Orbit Grey Double-spoke style 793 BMW Individual alloy wheels with run-flat tyres), will cost an extra £750 to have fitted."); } // If the user chooses option 3 for wheels, this will be written to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                // If the user chooses option 3 for the wheels, this will be written to the 'userbudget' file
                                            { if (ChosenWheels == 3) { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The wheels you've chosen, the 19” Bicolour Orbit Grey Double-spoke style 793 BMW Individual alloy wheels with run-flat tyres, will cost " + WheelPrice); BudgetTotal = Budget - WheelPrice; sw.Close(); } } 
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); WheelSelectionLoop = true; break;
                                        default: Console.WriteLine("Go back and choose the other wheels."); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                Boolean UpholsteryConfirmationLoop = false; // A loop to make sure that they have selected the upholstery that they want. Set to false by default.
                                while (!UpholsteryConfirmationLoop)
                                {
                                    string[] UpholsterySelection = new[] { "1 - Tacora Red with Décor stitching Vernasca leather", "2 - Black with Grey Contrast Stitching Vernasca Leather", "3 - Black with Blue stitching Vernasca Leather", "4 - Oyster with Grey contrast stitching Vernasca Leather" }; // A string array for all of the upholstery available for this model
                                    Console.WriteLine("These are the different upholsteries that you can choose for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, UpholsterySelection)); // All of the different upholsteries are displayed from the array, line by line
                                    Console.WriteLine("\nPlease choose a number between 1 and 4:");
                                    int ChosenUpholstery = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenUpholstery' created and set based on users input on upholstery selection
                                    if (ChosenUpholstery == 1) { Console.WriteLine("The upholsery you have chosen is the Tacora Red with Décor stitching Vernasca leather. This costs nothing have applied to the seats."); } // If the user enters 1
                                    else if (ChosenUpholstery == 2) { Console.WriteLine("The upholsery you have chosen is the Black with Grey Contrast Stitching Vernasca Leather. This costs nothing have applied to the seats."); } // If the user enters 2
                                    else if (ChosenUpholstery == 3) { Console.WriteLine("The upholsery you have chosen is the Black with Blue stitching Vernasca Leather. This costs nothing have applied to the seats."); } // If the user enters 3
                                    else if (ChosenUpholstery == 4) { Console.WriteLine("The upholsery you have chosen is the Oyster with Grey contrast stitching Vernasca Leather. This costs nothing have applied to the seats."); } // If the user enters 4
                                    else { Console.WriteLine("Error! Please enter a number between 1 and 4!"); } // If the number entered isn't between 1 and 4
                                    Console.WriteLine("Are you happy with your choice of upholstery? (Y or N):"); // Making sure the user is happy with their choice 
                                    string UpholsteryConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (UpholsteryConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenUpholstery == 1) { sw.WriteLine("The upholstery you have chosen, (Tacora Red with Décor stitching Vernasca leather), will cost nothing extra to have applied to the seats."); } // If the user chooses option 1 for the upholstery, this will be written to the 'cardetails' file
                                                else if (ChosenUpholstery == 2) { sw.WriteLine("The upholstery you have chosen, (Black with Grey Contrast Stitching Vernasca Leather), will cost nothing extra to have applied to the seats."); } // If the user chooses option 2 for the upholstery, this will be written to the 'cardetails' file
                                                else if (ChosenUpholstery == 3) { sw.WriteLine("The upholstery you have chosen, (Black with Blue stitching Vernasca Leather), will cost nothing extra to have applied to the seats."); } // If the user chooses option 3 for the upholstery, this will be written to the 'cardetails' file
                                                else if (ChosenUpholstery == 4) { sw.WriteLine("The upholstery you have chosen, (Oyster with Grey contrast stitching Vernasca Leather), will cost nothing extra to have applied to the seats."); } // If the user chooses option 4 for the upholstery, this will be written to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); UpholsteryConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and choose another upholstery."); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                Boolean InteriorTrimConfirmationLoop = false; // A loop to make sure that they have selected the upholstery that they want. Set to false by default.
                                while (!InteriorTrimConfirmationLoop)
                                {
                                    string[] InteriorTrimSelection = new[] { "1 - Aluminium Tetragon Interior Trim", "2 - Aluminium Mesheffect Interior Trim", "3 - Individual Piano Black Interior Trim" }; // An array of the different interior trims available for this model
                                    Console.WriteLine("These are the different interior trims you have to choose from for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, InteriorTrimSelection)); // All of the different interior trims are displayed from the array, line by line
                                    Console.WriteLine("\nPlease choose a number between 1 and 3:");
                                    int ChosenInterior = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenInterior' created and set based on users input on interior trim selection
                                    if (ChosenInterior == 1) { Console.WriteLine("The interior trim you have chosen is the Aluminium Tetragon Interior Trim. This costs nothing to have applied."); } // If the user enters 1
                                    else if (ChosenInterior == 2) { Console.WriteLine("The interior trim you have chosen is the Aluminium Mesheffect Interior Trim. This costs nothing to have applied."); } // If the user enters 2
                                    else if (ChosenInterior == 3) { Console.WriteLine("The interior trim you have chosen is the Individual Piano Black Interior Trim. This will cost an extra £500 to have applied."); } // If the user enters 3
                                    else { Console.WriteLine("Error! Please enter a number between 1 and 3!"); } // If the number entered isn't between 1 and 3
                                    int InteriorTrimOne = 500; // An integer called 'InteriorTrimOne' has been created and assigned the value of 500 (for option 3)
                                    Console.WriteLine("Are you happy with your choice of interior trim? (Y or N):"); // Making sure the user is happy with their choice 
                                    string InteriorTrimConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (InteriorTrimConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenInterior == 1) { sw.WriteLine("The interior trim you've chosen, (Aluminium Tetragon Interior Trim), will cost nothing to have applied."); } // If the user chooses option 1 for the interior trim, this will be written to the 'cardetails' file
                                                else if (ChosenInterior == 2) { sw.WriteLine("The interior trim you've chosen, (Aluminium Mesheffect Interior Trim), will cost nothing to have applied."); } // If the user chooses option 2 for the interior trim, this will be written to the 'cardetails' file
                                                else if (ChosenInterior == 3) { sw.WriteLine("The interior trim you've chosen, (Individual Piano Black Interior Trim), will cost any extra £500 to have applied."); } // If the user chooses option 3 for the interior trim, this will be written to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                            { if (ChosenInterior == 3) { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The interior trim you've chosen, the Individual Piano Black Interior Trim, will cost an extra " + InteriorTrimOne + " to have applied."); BudgetTotal = Budget - InteriorTrimOne; sw.Close(); } } // If the user chooses option 3 for the wheels, this will be written to the 'userbudget' file
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); InteriorTrimConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and pick a different interiot trim."); break;
                                    }
                                }
                                // An array of all of the extras that are available for this model
                                string[] AdditionalExtras = new[] { "1 - Drive Assistant Professional", "2 - M Adaptive Suspension", "3 - Heated Steering Wheel", "4 - Front Lumbar Support", "5 - Sun Protection Glass", "6 - Enhanced Bluetooth with Wireless Charging", "7 - Parking Assistance Plus", "8 - Harman/Kardon Surround Sound Audio System", "9 - Towbar", "10 - Electric Glass Sunroof" }; 
                                string[] ExtrasCost = new[] { "No extra charge", "No extra charge", "£170", "£195", "£320", "£350", "£650", "£820", "£850", "£950" }; // An array of all the prices for all of the additional extras
                                Console.WriteLine(String.Join(Environment.NewLine, AdditionalExtras)); // All of the extras are displayed from the array, line by line
                                // Solution to selecting multiple options within an array (code below) has been slightly changed and adapted from the answer posted (by JackJJun-MSFT) from this link: https://docs.microsoft.com/en-us/answers/questions/835275/choose-multiple-options-within-an-array.html
                                List<string> ExtrasList = new(); // A list created called 'ExtrasList'
                                Dictionary<int, string> Dictionary = new(); // A new dictionary called 'Dictionary' - which will repesent the collection of values within the array
                                foreach (string item in AdditionalExtras)
                                { // For each item in the 'AdditionalExtras' array...
                                    int n = Convert.ToInt32(item.Split('-')[0].Trim()); // 1 - An integer called 'n' will convert it to a 32-bit integer. Each item within the array will be split into substrings, and then any whitespace will be trimmed away
                                    string m = item.Split('-')[1].Trim(); // 2 - A string called 'm' and the item will then also be split into substrings, and again, any whitespace will be trimmed away
                                    Dictionary.Add(n, m); // 3 - Finally, the values will be added to the Dictionary
                                }
                                while (true)
                                {
                                    Console.WriteLine("Note: If you want to end your choice selection, please press the speacebar in the console (after a number has been entered), otherwise, please press enter to keep making selections!");
                                    Console.WriteLine("Please select any of the extras that you would like to purchase!");
                                    int ExtraSelection = Convert.ToInt32(Console.ReadLine()); // Integer called 'ExtraSelection' created and will be set based on the users input
                                    // Solution to the below if statemement outputting the chosen extra item and the price was provided by JackJJun-MSFT from this link: https://docs.microsoft.com/en-us/answers/questions/840725/join-two-different-string-arrays-in-c.html
                                    if (Dictionary.ContainsKey(ExtraSelection)) { ExtrasList.Add(Dictionary[ExtraSelection] + " ---- " + ExtrasCost[ExtraSelection - 1]); } // If the Dictionary contains a key from the users input, that key will be added to the 'ExtraList' list, and the cost will be included of that item
                                    else { Console.WriteLine("Please input the correct number!"); } // If an incorrect number is entered by the user (or if the enter key is pressed), display this error message and the program will stop
                                    ConsoleKeyInfo c = Console.ReadKey(); // The info of the console key that was pressed, assign it the variable 'c'
                                    if (c.Key == ConsoleKey.Spacebar) { break; } // If the console key is the Spacebar key, break out of the loop for all of the selected options
                                }
                                Console.WriteLine("Below is your purchase list:");
                                foreach (var item in ExtrasList) { Console.WriteLine(item); } // Display each item in the 'ExtrasList' as well as the cost
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                {
                                    sw.WriteLine("\nThese are the items you've chose to add to your configuration:");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'CarDetails' file
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                {
                                    sw.WriteLine("Here is the breakdown of the extra items chosen and their costs");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'UserBudget' file
                                    Console.WriteLine("There is no way to calculate the price of the extras against the budget you have entered. However, this could be fixed in the future.");
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n");
                                Console.WriteLine("You have now completed building your car!");
                                Console.WriteLine("Note: There is no way of checking that you can afford it or not as that system caused problems so was not implemented.");
                                Boolean DepositConfirmationLoop = false; // A loop to make sure the deposit is paid. Set to false by default
                                while (!DepositConfirmationLoop) // A while loop to confirm if it has been paid
                                {
                                    Console.WriteLine("Before you can purchase it, have you paid your deposit and has it cleared? (Y or N):");
                                    string DepositConfirmation = Console.ReadLine().ToUpper();
                                    switch (DepositConfirmation)
                                    {
                                        case "Y": // If the user has paid their deposit, break out of the loop
                                            Console.WriteLine("You may now confirm your payment!"); DepositConfirmationLoop = true; break;
                                        default: Console.WriteLine("Please make it has been paid before you continue!"); break; // If the user still needs to pay the deposit, go back and ask again
                                    }
                                }
                                Boolean PurchaseConfirmationLoop = false; // A loop ot make sure the purchase confirmation is complete. Set to false by default
                                while (!PurchaseConfirmationLoop)
                                {
                                    Console.WriteLine("Before you confirm your purchase, please note that once you do, you cannot change your mind! Are you happy with your purchase? (Y or N):");
                                    string PurchaseConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (PurchaseConfirmation)
                                    {
                                        case "Y": // If the user is happy with their purchase
                                            Console.WriteLine("You can now pay for your car and confirm your purchase!");
                                            Console.WriteLine("Thank you for using the Car Builder App!"); PurchaseConfirmationLoop = true; break;
                                        default: Console.WriteLine("You can start the program again and build a new car!"); System.Environment.Exit(0); break; // If the user still isn't sure, they can quit the program and start again
                                    }
                                }
                            }
                            else if (ChosenBMWModel == "218i M Sport Gran Coupe" || ChosenBMWModel == "218i m sport gran coupe" || ChosenBMWModel == "218I M SPORT GRAN COUPE") // Allows all types to be entered by the user
                            {
                                Console.WriteLine("You have chosen the 218i M Sport Gran Coupe!"); BMWModelLoop = true; // The loop is true, as the string matched
                                string[] BMW218iMSportGranCoupeEngine = new[] { "1 - Manual", "2 - Automatic DTC Transmission" }; // String array for all the engines for the BMW 218i M Sport Gran Coupe
                                Boolean EngineConfirmationLoop = false; // A loop to make sure the user chooses the engine they want - set to false by default
                                while (!EngineConfirmationLoop) // A nested while loop to confirm the engine choice
                                {
                                    Console.WriteLine("These are the engines that you can choose for the BMW 218i M Sport Gran Coupe:");
                                    Console.WriteLine(String.Join(Environment.NewLine, BMW218iMSportGranCoupeEngine)); // All of the engines are displayed from the array, line by line
                                    Console.WriteLine("Please either choose 1 or 2 based on your engine choice:");
                                    int ChosenEngine = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenEngine' created and set based on users input on engine selection
                                    if (ChosenEngine == 1) { Console.WriteLine("The engine that you have chosen is the manual engine, which costs £29,880"); } // Nested if and else if statement, if the user enters 1
                                    else if (ChosenEngine == 2) { Console.WriteLine("The engine that you have chosen is the Automatic DTC Transmission, which costs £31,230"); } // If the user enters 2
                                    else { Console.WriteLine("Error! Please enter either 1 or 2!"); } // If the user enters a number other than 1 or 2
                                    int Engine_One = 29880; // The price of the first engine
                                    int Engine_Two = 31230; // The price of the second engine
                                    Console.WriteLine("Are you happy with your chosen engine? (Y or N):"); // Making sure the user is happy with the engine choice
                                    string EngineConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (EngineConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenEngine == 1) { sw.WriteLine("You've chosen the manual engine, which wlll cost £29,880"); } // If engine 1 was chosen, write this to the 'cardetails' file
                                                else if (ChosenEngine == 2) { sw.WriteLine("You've chosen the Automatic DTC Transmission, which will cost £31,230"); } // If engine 2 was chosen, write this to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                            {
                                                sw.WriteLine("Your current budget is: " + Budget);
                                                if (ChosenEngine == 1) { sw.WriteLine("The manual engine costs " + Engine_One); } // The price of engine one will be added to the 'UserBudget' file and can be viewed
                                                else if (ChosenEngine == 2) { sw.WriteLine("The Automatic DTC Transmission costs " + Engine_Two); } // The price of engine one will be added to the 'UserBudget' file and can be viewed
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); EngineConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and select a different engine."); break;
                                    }
                                }
                                string[] BMWColours = new[] { "White", "Black - metallic", "Red - metallic", "Blue - metallic", "Grey - metallic", "White – metallic", "Green – metallic" }; // Array of all colours for all BMW models
                                Array.Sort(BMWColours); // The array will be sorted
                                int ColourBlackMetallic = 595; // An integer (ColourBlackMetallic) has been created and assigned the value of 595
                                int ColourBlackMetallic420i = 695; // An integer (ColourBlueMetallic420i) has been created and assigned the value of 695
                                int ColourBlackMetallic520i = 900; // An integer (ColourBlackMetallic520i) has been created and assigned the value of 900
                                int ColourRedMetallic = 595; // An integer (ColourRedMetallic) has been created and assigned the value of 595
                                int ColourRedMetallic520i = 1995; // An integer (ColourRedMetallic520i) has been created and assigned the value of 1995
                                int ColourBlueMetallic = 595; // An integer (ColourBlueMetallic) has been created and assigned the value of 595
                                int ColourBlueMetallic420i = 695; // An integer (ColourBlueMetallic420i) has been created and assigned the value of 695
                                int ColourBlueMetallic520i = 900; // An integer (ColourBlueMetallic520i) has been created and assigned the value of 900
                                int ColourGreyMetallic = 595; // An integer (ColourGreyMetallic) has been created and assigned the value of 595
                                int ColourGreyMetallic520i = 900; // An integer (ColourGreyMetallic520i) has been created and assigned the value of 900
                                int ColourWhiteMetallic = 695; // An integer (ColourWhiteMetallic) has been created and assigned the value of 695
                                int ColourGreenMetallic = 695; // An integer (ColourGreenMetallic) has been created and assigned the value of 695
                                Console.WriteLine("These are the colours you can choose from:");
                                foreach (string a in BMWColours) { Console.WriteLine(a); } // Using a foreach loop to display all of the elements in the array to the user (to show all of the available colours
                                Boolean BMWCompatibleCombinationLoop = false; // A loop to make sure the colour and model combination matches. Set to false by default
                                while (!BMWCompatibleCombinationLoop) // The while loop to the check the combination
                                {
                                    Console.WriteLine("\nNote 1: Some colours will cost extra if chosen, or might not be avaliable, depending on the model selected!"); // Message to the user about extra cost for certain colours
                                    Console.WriteLine("Note 2: Please enter the chosen colour EXACTLY as it is shown to you, otherwise, the program will not accept it. This is due to a coding fault, but could be fixed in the future!\n");// Another message to the user regarding exact spelling of the words
                                    Console.WriteLine("Please choose a colour: ");
                                    string ChosenBMWColour = Console.ReadLine(); // A local variable called 'ChosenBMWColour' is created and whatever the user types in is set to that variable
                                    int BMWColourIndex = Array.BinarySearch(BMWColours, ChosenBMWColour); // Searches the entire array (BMWColours) and sees if the colours that is input by the user matches
                                    if (BMWColourIndex >= 0) // If the colour chosen is greater-than or equal to the first index in the array AND matches, output the colour and the position in the array
                                    {
                                        Console.WriteLine(ChosenBMWColour + " is found at " + BMWColourIndex.ToString() + " position!");
                                            if (ChosenBMWColour == "White") // Nested if statements that will go through all of the colours to inform the user about availability per model
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("The colour is the standard colour, so will not cost any additional money!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 118i M Sport and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 218i M Sport Gran Coupe and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 420i M Sport Coupe and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "White") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is White. This colour will not cost any extra."); } } // If the user chose the 520i M Sport Saloon and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Black - metallic")
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The colour on the 118i M Sport and the 218i M Sport Gran Coupe is an extra £595!\nBut, the 420i M Sport Coupe is slightly more expensive (£695 extra)!\nThe 520i M Sport Saloon is the most expensive (£900 extra)!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £695."); } } // If the user chose the 420i M Sport Coupe and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is Black - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer                      
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the 118i M Sport, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the 218i M Sport Gran Coupe, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic420i); BudgetTotal = Budget - ColourBlackMetallic420i; } } // If the user chose the 420i M Sport Coupe, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Black - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen (Black - metallic), will cost " + ColourBlackMetallic520i); BudgetTotal = Budget - ColourBlackMetallic520i; } } // If the user chose the 520i M Sport Saloon, and the colour black - metallic , this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Red - metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 118i M Sport, 520i M Sport Saloon and the 218i M Sport Gran Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The colour will cost £595 extra when applied to the 118i M Sport or the 218i M Sport Gran Coupe!\nWhereas, for the colour to be applied to the 520i M Sport Saloon, it will cost an additional £1,995!");
                                                        string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 520i M Sport Saloon" }; // An array of all the BMW models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Red - metallic. This colour will cost an extra £1,995."); } }  // If the user chose the 520i M Sport Saloon and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic); BudgetTotal = Budget - ColourRedMetallic; } } // If the user chose the 118i M Sport and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic); BudgetTotal = Budget - ColourRedMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Red - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Red - metallic), will cost " + ColourRedMetallic520i); BudgetTotal = Budget - ColourRedMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "Blue - metallic")
                                            {
                                                Console.WriteLine("This colour is available on all BMW models!");
                                                Console.WriteLine("However, the price of the colour varies depending on which model selected:");
                                                Console.WriteLine("The colour on the 118i M Sport and the 218i M Sport Gran Coupe is an extra £595!\nBut, the colour is slightly more expensive on the 420i M Sport Coupe (£695 extra)!\nThe 520i M Sport Saloon is more expensive than that, costing £900 extra!");
                                                string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 420i M Sport Coupe", "4 - 520i M Sport Saloon" }; // An array of all the BMW models
                                                Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £695."); } } // If the user chose the 420i M Sport Coupe and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen on this model is Blue - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the 118i M Sport and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic420i); BudgetTotal = Budget - ColourBlueMetallic420i; } } // If the user chose the 420i M Sport Coupe and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenBMWColour == "Blue - metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you have chosen (Blue - metallic), will cost " + ColourBlueMetallic520i); BudgetTotal = Budget - ColourBlueMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenBMWColour == "Grey - metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 218i M Sport Gran Coupe, 520i M Sport Saloon and the 118i M Sport!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The colour will cost £595 extra when applied to the 118i M Sport or the 218i M Sport Gran Coupe!\nThe 520i M Sport Saloon is more expensive than that, costing £900 extra!");
                                                        string[] BMW_Models = new[] { "1 - 118i M Sport", "2 - 218i M Sport Gran Coupe", "3 - 520i M Sport Saloon" }; // An array of all the BMW models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, BMW_Models)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £595."); } } // If the user chose the 118i M Sport and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £595."); } } // If the user chose the 218i M Sport Gran Coupe and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen is Grey - metallic. This colour will cost an extra £900."); } } // If the user chose the 520i M Sport Saloon and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the 118i M Sport and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the 218i M Sport Gran Coupe and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenBMWColour == "Grey - metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you have chosen, (Grey - metallic), will cost " + ColourGreyMetallic520i); BudgetTotal = Budget - ColourGreyMetallic520i; } } // If the user chose the 520i M Sport Saloon and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "White – metallic")
                                            {
                                                Console.WriteLine("The colour is only available on the 420i M Sport Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        string BMW_Model_420i_White = "420i M Sport Coupe";
                                                        Console.WriteLine("The " + BMW_Model_420i_White + "is the model that supports this colour and it will cost an extra £695!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenBMWColour == "White – metallic") { sw.WriteLine("The colour you have chosen is White – metallic. This colour will cost an extra £695."); sw.Close(); } } // If the user chose the 420i M Sport Coupe and the colour white - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                        // If the user chose the 420i M Sport Coupe and the colour white - metallic, this will write to the 'UserBudget' file if this colour is chosen
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenBMWColour == "White metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you have chosen, (White - metallic), will cost " + ColourWhiteMetallic); BudgetTotal = Budget - ColourWhiteMetallic; sw.Close(); } }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenBMWColour == "Green – metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the 420i M Sport Coupe!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        string BMW_Model_420i_Green = "420i M Sport Coupe"; // A string called 'BMW_Model' that will display the model that this colour is applicable for
                                                        Console.WriteLine("The " + BMW_Model_420i_Green + "is the model that supports this colour and it will cost an extra £695!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenBMWColour == "Green – metallic") { sw.WriteLine("The colour you've chosen is Green – metallic. It will cost an extra £695."); sw.Close(); } } // If the user chose the 420i M Sport Coupe and the colour green - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                        // If the user chose the 420i M Sport Coupe and the colour green - metallic, this will write to the 'UserBudget' file if this colour is chosen
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenBMWColour == "Green - metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you've chosen, (Green - metallic), will cost " + ColourGreenMetallic); BudgetTotal = Budget - ColourGreenMetallic; sw.Close(); } }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); BMWCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("The colour you have picked is not available"); } // If the colour doesn't match, then that colour is not available and a message is displayed to the user
                                }
                                Boolean WheelSelectionLoop = false; // A loop to make sure that they has selected the wheels that they want. Set to false by default.
                                while (!WheelSelectionLoop)
                                {
                                    string[] WheelSelection = new[] { "1 - 18” Double-spoke style 819 M alloy wheels", "2 - 18” Orbit Grey V-spoke style 554 M alloy wheels", "3 - 18” 554M V-spoke style alloy wheels Orbit Grey with Performance tyres", "4 - 19” Bicolour Double spoke style 552 M alloy wheels" }; // String array for all the wheels for this model
                                    Console.WriteLine("These are the wheels that you can choose for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, WheelSelection)); // All of the wheels are displayed from the array, line by line
                                    Console.WriteLine("\nPlease enter a number between 1 and 4:");
                                    int ChosenWheels = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenWheels' created and set based on users input on wheel selection
                                    if (ChosenWheels == 1) { Console.WriteLine("The wheels you have chosen are the 18” Double-spoke style 819 M alloy wheels. These wheels don't cost anything extra to have fitted! However, the only tyres available will come with the car!"); } // Nested if and else if statements - if the user enters 1, these wheels are selected
                                    else if (ChosenWheels == 2) { Console.WriteLine("The wheels you have chosen are the 18” Orbit Grey V-spoke style 554 M alloy wheels. These wheels don't cost anything extra to have fitted! However, the only tyres available will come with the car!"); } // If the user enters 2, these wheels are selected
                                    else if (ChosenWheels == 3) { Console.WriteLine("The wheels you have chosen are the 18” 554M V-spoke style alloy wheels Orbit Grey with Performance tyres. These will cost an extra £1,350 to have fitted!"); } // If the user enters 3, these wheels (and tyres) are selected
                                    else if (ChosenWheels == 4) { Console.WriteLine("The wheels you have chosen are the 19” Bicolour Double spoke style 552 M alloy wheels. These will cost an extra £595 to have fitted! However, the only tyres available will come with the car!"); } // If the user enters 4, these wheels are selected
                                    else { Console.WriteLine("Error! Please enter a number between 1 and 4!"); } // If the user enters a number that is not between 1 and 4
                                    int WheelPrice = 1350; // A price for the wheels (for option 3) - created and assigned a value of 1350
                                    int WheelsPriceTwo = 595; // A price for the wheels (for option 4) - created and assigned the value of 595
                                    Console.WriteLine("Are you happy with with your chosen wheels? (Y or N):"); // Making sure the user is happy with the wheel choice
                                    string WheelConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (WheelConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenWheels == 1) { sw.WriteLine("The wheels you've chosen, (the 18” Double-spoke style 819 M alloy wheels), will cost nothing extra to have fitted. The only tyres available will come with the car."); } // If the user chooses option 1 for wheels, this will be written to the 'cardetails' file
                                                else if (ChosenWheels == 2) { sw.WriteLine("The wheels you've chosen, (the 18” Orbit Grey V-spoke style 554 M alloy wheels), will cost nothing extra to have fitted. The only tyres available will come with the car."); } // If the user chooses option 2 for wheels, this will be written to the 'cardetails' file
                                                else if (ChosenWheels == 3) { sw.WriteLine("The wheels you've chosen, (the 18” 554M V-spoke style alloy wheels Orbit Grey with Performance tyres), will cost an extra £1,350 to have fitted."); } // If the user chooses option 3 for wheels, this will be written to the 'cardetails' file
                                                else if (ChosenWheels == 4) { sw.WriteLine("The wheels you've chosen, (the 19” Bicolour Double spoke style 552 M alloy wheels), will cost an extra 595 to have fitted. The only tyres available will come with the car."); } // If the user chooses option 4 for wheels, this will be written to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                            {
                                                sw.WriteLine("Your current budget is: " + Budget);
                                                if (ChosenWheels == 3) { sw.WriteLine("The wheels you've chosen, the 18” 554M V-spoke style alloy wheels Orbit Grey with Performance tyres, will cost " + WheelPrice); BudgetTotal = Budget - WheelPrice; } // If the user chooses option 3 for the wheels, this will be written to the 'userbudget' file
                                                else if (ChosenWheels == 4) { sw.WriteLine("The wheels you've chosen, the 19” Bicolour Double spoke style 552 M alloy wheels, will cost " + WheelsPriceTwo); Budget = Budget - WheelsPriceTwo; sw.Close(); } // If the user chooses option 4 for the wheels, this will be written to the 'userbudget' file
                                            }
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); WheelSelectionLoop = true; break;
                                        default: Console.WriteLine("Go back and choose the other wheels."); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                Boolean UpholsteryConfirmationLoop = false; // A loop to make sure that they have selected the upholstery that they want. Set to false by default.
                                while (!UpholsteryConfirmationLoop)
                                {
                                    string[] UpholsterySelection = new[] { "1 - Black Trigon Cloth/Sensatec", "2 - Magma Red with grey highlight Dakota leather with perforations", "3 - Mocha Dakota leather w/ perforations", "4 - Black w/ blue highlight Dakota leather w/ perforations", "5 - Black Dakota leather with perforations" }; // A string array for all of the upholstery available for this model
                                    Console.WriteLine("These are the different upholsteries that you can choose for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, UpholsterySelection)); // All of the different upholsteries are displayed from the array, line by line
                                    Console.WriteLine("\nPlease choose a number between 1 and 5:");
                                    int ChosenUpholstery = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenUpholstery' created and set based on users input on upholstery selection
                                    if (ChosenUpholstery == 1) { Console.WriteLine("The upholsery you have chosen is the Black Trigon Cloth/Sensatec. This costs nothing have applied to the seats."); } // If the user enters 1
                                    else if (ChosenUpholstery == 2) { Console.WriteLine("The upholsery you have chosen is the Magma Red with grey highlight Dakota leather with perforations. This will cost an extra £1,150 to have applied to the seats."); } // If the user enters 2
                                    else if (ChosenUpholstery == 3) { Console.WriteLine("The upholsery you have chosen is the Mocha Dakota leather w/ perforations. This will cost an extra £1,150 to have applied to the seats."); } // If the user enters 3
                                    else if (ChosenUpholstery == 4) { Console.WriteLine("The upholsery you have chosen is the Black w/ blue highlight Dakota leather w/ perforations. This will cost an extra £1,150 to have applied to the seats."); } // If the user enters 4
                                    else if (ChosenUpholstery == 5) { Console.WriteLine("The upholsery you have chosen is the Black Dakota leather with perforations. This will cost an extra £1,150 to have applied to the seats."); } // If the user enters 5
                                    else { Console.WriteLine("Error! Please enter a number between 1 and 5!"); } // If the user enters a number that is not between 1 and 5
                                    int UpholsteryPrice = 1150; // An integer (UpholsteryPrice), that has been created and assigned the value of 1150
                                    Console.WriteLine("Are you happy with your choice of upholstery? (Y or N):"); // Making sure the user is happy with their choice 
                                    string UpholsteryConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (UpholsteryConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenUpholstery == 1) { sw.WriteLine("The upholstery you have chosen, (Black Trigon Cloth/Sensatec), will cost nothing extra to have applied to the seats."); } // If the user chooses option 1 for the upholstery, this will be written to the 'cardetails' file
                                                else if (ChosenUpholstery == 2) { sw.WriteLine("The upholstery you have chosen, (Magma Red with grey highlight Dakota leather with perforations), will cost an extra £1,150 to have applied to the seats."); } // If the user chooses option 2 for the upholstery, this will be written to the 'cardetails' file
                                                else if (ChosenUpholstery == 3) { sw.WriteLine("The upholstery you have chosen, (Mocha Dakota leather w/ perforations), will cost an extra £1,150 to have applied to the seats."); } // If the user chooses option 3 for the upholstery, this will be written to the 'cardetails' file
                                                else if (ChosenUpholstery == 4) { sw.WriteLine("The upholstery you have chosen, (Black w/ blue highlight Dakota leather w/ perforations), will cost an extra £1,150 to have applied to the seats."); } // If the user chooses option 4 for the upholstery, this will be written to the 'cardetails' file
                                                else if (ChosenUpholstery == 5) { sw.WriteLine("The upholstery you have chosen, (Black Dakota leather with perforations), will cost an extra £1,150 to have applied to the seats."); } // If the user chooses option 5 for the upholstery, this will be written to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                            {
                                                sw.WriteLine("Your current budget is: " + Budget);
                                                if (ChosenUpholstery == 2) { sw.WriteLine("The upholstery you've chosen, Magma Red with grey highlight Dakota leather with perforations, will cost " + UpholsteryPrice); BudgetTotal = Budget - UpholsteryPrice; } // If the user chooses option 2 for the upholstery, this will be written to the 'userbudget' file
                                                else if (ChosenUpholstery == 3) { sw.WriteLine("The upholstery you've chosen, Mocha Dakota leather w/ perforations, will cost " + UpholsteryPrice); BudgetTotal = Budget - UpholsteryPrice; } // If the user chooses option 3 for the upholstery, this will be written to the 'userbudget' file
                                                else if (ChosenUpholstery == 4) { sw.WriteLine("The upholstery you've chosen, Black w/ blue highlight Dakota leather w/ perforations, will cost " + UpholsteryPrice); BudgetTotal = Budget - UpholsteryPrice; } // If the user chooses option 4 for the upholstery, this will be written to the 'userbudget' file
                                                else if (ChosenUpholstery == 5) { sw.WriteLine("The upholstery you've chosen, Black Dakota leather with perforations, will cost " + UpholsteryPrice); BudgetTotal = Budget - UpholsteryPrice; } // If the user chooses option 5 for the upholstery, this will be written to the 'userbudget' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); UpholsteryConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and choose another upholstery."); break; // The default will assume the user isn't happy with their choice
                                    }
                                }
                                Boolean InteriorTrimConfirmationLoop = false; // A loop to make sure that they have selected the upholstery that they want. Set to false by default.
                                while (!InteriorTrimConfirmationLoop)
                                {
                                    string[] InteriorTrimSelection = new[] { "1 - Illuminated Boston Interior Trim", "2 - Illuminated Berlin Interior Trim" }; // An array of the different interior trims available for this model
                                    Console.WriteLine("These are the different interior trims you have to choose from for this model:");
                                    Console.WriteLine(String.Join(Environment.NewLine, InteriorTrimSelection)); // All of the different interior trims are displayed from the array, line by line
                                    Console.WriteLine("\nPlease choose either 1 or 2:");
                                    int ChosenInterior = Convert.ToInt32(Console.ReadLine()); // Integer called 'ChosenInterior' created and set based on users input on interior trim selection
                                    if (ChosenInterior == 1) { Console.WriteLine("The interior trim you have chosen is the Illuminated Boston Interior Trim. This costs nothing to have applied."); } // If the user enters 1
                                    else if (ChosenInterior == 2) { Console.WriteLine("The interior trim you have chosen is the Illuminated Berlin Interior Trim. This costs nothing to have applied."); } // If the user enters 2
                                    else { Console.WriteLine("Error! Please enter either 1 or 2!"); } // If the user enters a number that is not 1 or 2
                                    Console.WriteLine("Are you happy with your choice of interior trim? (Y or N):"); // Making sure the user is happy with their choice 
                                    string InteriorTrimConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (InteriorTrimConfirmation)
                                    {
                                        case "Y": // If the user is happy with their chosen upholstery choice
                                            Console.WriteLine("Please continue with building your car!");
                                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                            {
                                                if (ChosenInterior == 1) { sw.WriteLine("The interior trim you've chosen, (Illuminated Boston Interior Trim), will cost nothing to have applied."); } // If the user chooses option 1 for the interior trim, this will be written to the 'cardetails' file
                                                else if (ChosenInterior == 2) { sw.WriteLine("The interior trim you've chosen, (Illuminated Berlin Interior Trim), will cost nothing to have applied."); } // If the user chooses option 2 for the interior trim, this will be written to the 'cardetails' file
                                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                                            }
                                            Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); InteriorTrimConfirmationLoop = true; break;
                                        default: Console.WriteLine("Go back and pick a different interiot trim."); break;
                                    }
                                }
                                string[] AdditionalExtras = new[] { "1 - Wi-Fi Hotspot", "2 - Larger Fuel Tank", "3 - Space-saver Spare Wheel", "4 - Heated Steering Wheel", "5 - Front Lumbar Support", "6 - Gesture Control", "7 - Sun Protection Glass", "8 - Enhanced Bluetooth with Wireless Charging", "9 - Parking Assistance", "10 - Harman/Kardon Surround Sound Audio System", "11 - Towbar", 
                                    "12 - Electric Front Seats + Driver Memory", "13 - Panoramic Glass Roof" }; // An array of all of the extras that are available for this model
                                string[] ExtrasCost = new[] { "No added charge", "£50", "£150", "£150", "£150", "£300", "£300", "£350", "£350", "£750", "£750", "£750", "£1,000" }; // An array of all the prices for all of the additional extras
                                Console.WriteLine(String.Join(Environment.NewLine, AdditionalExtras)); // All of the extras are displayed from the array, line by line
                                // Solution to selecting multiple options within an array (code below) has been slightly changed and adapted from the answer posted (by JackJJun-MSFT) from this link: https://docs.microsoft.com/en-us/answers/questions/835275/choose-multiple-options-within-an-array.html
                                List<string> ExtrasList = new(); // A list created called 'ExtrasList'
                                Dictionary<int, string> Dictionary = new(); // A new dictionary called 'Dictionary' - which will repesent the collection of values within the array
                                foreach (string item in AdditionalExtras)
                                { // For each item in the 'AdditionalExtras' array...
                                    int n = Convert.ToInt32(item.Split('-')[0].Trim()); // 1 - An integer called 'n' will convert it to a 32-bit integer. Each item within the array will be split into substrings, and then any whitespace will be trimmed away
                                    string m = item.Split('-')[1].Trim(); // 2 - A string called 'm' and the item will then also be split into substrings, and again, any whitespace will be trimmed away
                                    Dictionary.Add(n, m); // 3 - Finally, the values will be added to the Dictionary
                                }
                                while (true)
                                {
                                    Console.WriteLine("Note: If you want to end your choice selection, please press the speacebar in the console (after a number has been entered), otherwise, please press enter to keep making selections!");
                                    Console.WriteLine("Please select any of the extras that you would like to purchase!");
                                    int ExtraSelection = Convert.ToInt32(Console.ReadLine()); // Integer called 'ExtraSelection' created and will be set based on the users input
                                    // Solution to the below if statemement outputting the chosen extra item and the price was provided by JackJJun-MSFT from this link: https://docs.microsoft.com/en-us/answers/questions/840725/join-two-different-string-arrays-in-c.html
                                    if (Dictionary.ContainsKey(ExtraSelection)) { ExtrasList.Add(Dictionary[ExtraSelection] + " ---- " + ExtrasCost[ExtraSelection - 1]); } // If the Dictionary contains a key from the users input, that key will be added to the 'ExtraList' list, and the cost will be included of that item
                                    else { Console.WriteLine("Please input the correct number!"); } // If an incorrect number is entered by the user (or if the enter key is pressed), display this error message and the program will stop
                                    ConsoleKeyInfo c = Console.ReadKey(); // The info of the console key that was pressed, assign it the variable 'c'
                                    if (c.Key == ConsoleKey.Spacebar) { break; } // If the console key is the Spacebar key, break out of the loop for all of the selected options
                                }
                                Console.WriteLine("Below is your purchase list:");
                                foreach (var item in ExtrasList) { Console.WriteLine(item); } // Display each item in the 'ExtrasList' as well as the cost
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                {
                                    sw.WriteLine("\nThese are the items you've chose to add to your configuration:");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'CarDetails' file
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                {
                                    sw.WriteLine("Here is the breakdown of the extra items chosen and their costs");
                                    sw.WriteLine(String.Join(Environment.NewLine, ExtrasList)); // The chosen items in 'ExtrasList' are written to the 'UserBudget' file
                                    Console.WriteLine("There is no way to calculate the price of the extras against the budget you have entered. However, this could be fixed in the future.");
                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                }
                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n");
                                Console.WriteLine("You have now completed building your car!");
                                Console.WriteLine("Note: There is no way of checking that you can afford it or not as that system caused problems so was not implemented.");
                                Boolean DepositConfirmationLoop = false; // A loop to make sure the deposit is paid. Set to false by default
                                while (!DepositConfirmationLoop) // A while loop to confirm if it has been paid
                                {
                                    Console.WriteLine("Before you can purchase it, have you paid your deposit and has it cleared? (Y or N):");
                                    string DepositConfirmation = Console.ReadLine().ToUpper();
                                    switch (DepositConfirmation)
                                    {
                                        case "Y": // If the user has paid their deposit, break out of the loop
                                            Console.WriteLine("You may now confirm your payment!"); DepositConfirmationLoop = true; break;
                                        default: Console.WriteLine("Please make it has been paid before you continue!"); break; // If the user still needs to pay the deposit, go back and ask again
                                    }
                                }
                                Boolean PurchaseConfirmationLoop = false; // A loop ot make sure the purchase confirmation is complete. Set to false by default
                                while (!PurchaseConfirmationLoop)
                                {
                                    Console.WriteLine("Before you confirm your purchase, please note that once you do, you cannot change your mind! Are you happy with your purchase? (Y or N):");
                                    string PurchaseConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (PurchaseConfirmation)
                                    {
                                        case "Y": // If the user is happy with their purchase
                                            Console.WriteLine("You can now pay for your car and confirm your purchase!");
                                            Console.WriteLine("Thank you for using the Car Builder App!"); PurchaseConfirmationLoop = true; break;
                                        default: Console.WriteLine("You can start the program again and build a new car!"); System.Environment.Exit(0); break; // If the user still isn't sure, they can quit the program and start again
                                    }
                                }
                            }
                            else { Console.WriteLine("Please try again!"); } // ...otherwise, this message will appear and it will loop back round to ask the user to select a model again
                        }
                        break;
                    case 3:
                        Boolean MercedesModelLoop = false; // A loop to make sure a model chosen from the list - false by default
                        while (!MercedesModelLoop) // A while loop to make sure the chosen model matches any from the list (true), else it will loop until this condition is met
                        {
                            Console.WriteLine("You have chosen Mercedes as your brand!\n");
                            Console.WriteLine("There are the current models that you can choose from:");
                            string ChosenMercedesModel; // String created for the user to pick out their chosen Mercedes model
                            List<string> MercedesModels = new(4); // A list crated to show all of the Mercedes models available
                            MercedesModels.Add("A-Class Compact Saloon"); MercedesModels.Add("B-Class Tourer"); MercedesModels.Add("C-Class Saloon"); MercedesModels.Add("E-Class Saloon");
                            MercedesModels.Sort(); // Will sort the list in alphabetical order
                            foreach (string a in MercedesModels) { Console.WriteLine(a); } // Foreach loop to display all of the models
                            Console.WriteLine("\nPlease select your chosen model: ");
                            ChosenMercedesModel = Console.ReadLine().ToUpper(); // The chosen model will be whatever the user types in (caps and lower cases should both be allowed)
                            using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt"))
                            {
                                sw.WriteLine("Your car details\n" + "Your chosen model: Ford " + ChosenMercedesModel); // The model of car that the user enters should write to the file and can be viewed
                                sw.Close(); // Closes the StreamWriter object and the stream buffer
                            }
                            // if and else if statements for the chosen models
                            if (ChosenMercedesModel == "A-Class Compact Saloon" || ChosenMercedesModel == "a-class compact saloon" || ChosenMercedesModel == "A-CLASS COMPACT SALOON") // Allows all types to be entered by the user
                            {
                                Console.WriteLine("You have chosen the A-Class Compact Saloon!"); MercedesModelLoop = true; // The loop is true, as the string matched
                                string MercedesModel = "A-Class Compact Saloon"; // A string for the model
                                string MercedesEngine = "A 180 Sport Hatchback"; // A string for the engine for this model
                                int EnginePrice = 26550; // Integer called 'EnginePrice' that has been created and assigned the value of 26550
                                Console.WriteLine("The " + MercedesModel + "only have one engine, the " + MercedesEngine + ", which will cost £26,550");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only engine available for this model, the " + MercedesEngine + ", will cost £26,550"); sw.Close(); } // If the user chooses this model, this is the only available engine - so this will be written to the 'cardetails' file
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The only engine for this model, the " + MercedesEngine + ", will cost " + EnginePrice); BudgetTotal = Budget - EnginePrice; sw.Close(); } // If the user chooses this model, this is the only available engine - so this will be written to the 'userbudget' file
                                string[] MercedesColours = new[] { "White", "Red – metallic", "White – metallic", "Black – metallic", "Blue – metallic", "Silver – metallic", "Grey – metallic", "Rose gold – metallic" }; // Array of all colours for all Mercedes models
                                Array.Sort(MercedesColours); // The array will be sorted
                                int ColourRedMetallicAClass = 831; // An integer (ColourRedMetallicAClass) has been created and assigned the value of 831
                                int ColourRedMetallic_C_Class = 925; // An integer (ColourRedMetallic_C_Class) has been created and assigned the value of 925
                                int ColourRedMetallicEClass = 1095; // An integer (ColourRedMetallicEClass) has been created and assigned the value of 1095
                                int ColourWhiteMetallic = 625; // An integer (ColourWhiteMetallic) has been created and assigned the value of 625
                                int ColourBlackMetallic = 625; // An integer (ColourBlackMetallic) has been created and assigned the value of 625
                                int ColourBlackMetallic_C_Class = 715; // An integer (ColourBlackMetallic_C_Class) has been created and assigned the value of 715
                                int ColourBlackMetallicEClass = 895; // An integer (ColourBlackMetallicEClass) has been created and assigned the value of 895
                                int ColourBlueMetallic = 625; // An integer (ColourBlueMetallic) has been created and assigned the value of 625
                                int ColourBlueMetallic_C_Class = 715; // An integer (ColourBlueMetallic_C_Class) has been created and assigned the value of 715
                                int ColourBlueMetallicEClass = 895; // An integer (ColourBlueMetallicEClass) has been created and assigned the value of 895
                                int ColourSilverMetallic = 625; // An integer (ColourSilverMetallic) has been created and assigned the value of 625
                                int ColourSilverMetallic_C_Class = 715; // An integer (ColourSilverMetallic_C_Class) has been created and assigned the value of 715
                                int ColourSilverMetallicEClass = 895; // An integer (ColourSilverMetallicEClass) has been created and assigned the value of 895
                                int ColourGreyMetallic = 625; // An integer (ColourGreyMetallic) has been created and assigned the value of 625
                                int ColourGreyMetallic_C_Class = 715; // An integer (ColourGreyMetallic_C_Class) has been created and assigned the value of 715
                                int ColourGreyMetallicEClass = 895; // An integer (ColourGreyMetallicEClass) has been created and assigned the value of 895
                                int ColourRoseGoldMetallic = 625; // An integer (ColourRoseGoldMetallic) has been created and assigned the value of 625
                                Console.WriteLine("These are the colours you can choose from:");
                                foreach (string a in MercedesColours) { Console.WriteLine(a); } // Using a foreach loop to display all of the elements in the array to the user (to show all of the available colours)
                                Boolean MercedesCompatibleCombinationLoop = false; // A loop to make sure the colour and model combination matches. Set to false by default
                                while (!MercedesCompatibleCombinationLoop) // The while loop to the check the combination
                                {
                                    Console.WriteLine("\nNote 1: Some colours will cost extra if chosen, or might not be avaliable, depending on the model selected!"); // Message to the user about extra cost for certain colours
                                    Console.WriteLine("Note 2: Please enter the chosen colour EXACTLY as it is shown to you, otherwise, the program will not accept it. This is due to a coding fault, but could be fixed in the future!\n");// Another message to the user regarding exact spelling of the words
                                    Console.WriteLine("Please choose a colour: ");
                                    string ChosenMercedesColour = Console.ReadLine(); // A local variable called 'ChosenBMWColour' is created and whatever the user types in is set to that variable
                                    int MercedesColourIndex = Array.BinarySearch(MercedesColours, ChosenMercedesColour); // Searches the entire array (BMWColours) and sees if the colours that is input by the user matches
                                    if (MercedesColourIndex >= 0) // If the colour chosen is greater-than or equal to the first index in the array AND matches, output the colour and the position in the array
                                    {
                                        Console.WriteLine(ChosenMercedesColour + " is found at " + MercedesColourIndex.ToString() + " position!");
                                            if (ChosenMercedesColour == "White") // Nested if statements that will go through all of the colours to inform the user about availability per model
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour is the standard colour, so will not cost any additional money!");
                                                string[] MercedesModelsColourWhite = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourWhite)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the A-Class Compact Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the B-Class Tourer, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the C-Class Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the E-Class Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Red – metallic")
                                            {
                                                Console.WriteLine("This colour is available on the A-Class Compact Saloon, the C-Class Saloon and the E-Class Saloon!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The cost of the colour on the A-Class Compact Saloon will be an extra £831!\nThe cost of the colour on the C-Class Saloon will be an extra £925!\nHowever, it will cost the most expensive on the E-Class Saloon (£1,095 extra)!");
                                                        string[] MercedesModelsColourRed = new[] { "1 - A-Class Compact Saloon", "2 - C-Class Saloon", "3 - E-Class Saloon" }; // An array of all the Mercedes models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourRed)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £831."); } } // If the user chose the A-Class Compact Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £925."); } } // If the user chose the C-Class Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £1,095."); } } // If the user chose the E-Class Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallicAClass); BudgetTotal = Budget - ColourRedMetallicAClass; } } // If the user chose the A-Class Compact Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallic_C_Class); BudgetTotal = Budget - ColourRedMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallicEClass); BudgetTotal = Budget - ColourRedMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenMercedesColour == "White – metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the A-Class Compact Saloon!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will cost an extra £625!");
                                                        string MercedesModelColourWhiteMetallic = "A-Class Compact Saloon"; // A string of the Mercedes model that the colour applies to
                                                        Console.WriteLine("The " + MercedesModelColourWhiteMetallic + "is the model that supports this colour and it will cost an extra £625!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenMercedesColour == "White – metallic") { sw.WriteLine("The colour you've chosen is White - metallic. This colour will cost an extra £625."); sw.Close(); } } // If the user chose the A-Class Compact Saloon and the colour white - metallic, this will write to the 'CarDetails' file is this colour is chosen
                                                        // If the user chose the A-Class Compact Saloon, and the colour white - metallic, this will write the price of the colour to the 'UserBudget' file
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenMercedesColour == "White - metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you've chosen, (White - metallic), will cost" + ColourWhiteMetallic); BudgetTotal = Budget - ColourWhiteMetallic; sw.Close(); } } 
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenMercedesColour == "Black – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourBlack = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourBlack)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the B-Class Tourer, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic_C_Class); BudgetTotal = Budget - ColourBlackMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallicEClass); BudgetTotal = Budget - ColourBlackMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Blue – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourBlue = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourBlue)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the B-Class Tourer, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic_C_Class); BudgetTotal = Budget - ColourBlueMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallicEClass); BudgetTotal = Budget - ColourBlueMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Silver – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourSilver = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourSilver)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic); BudgetTotal = Budget - ColourSilverMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic); BudgetTotal = Budget - ColourSilverMetallic; } } // If the user chose the B-Class Tourer, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic_C_Class); BudgetTotal = Budget - ColourSilverMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallicEClass); BudgetTotal = Budget - ColourSilverMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Grey – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourGrey = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourGrey)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the B-Class Tourer, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic_C_Class); BudgetTotal = Budget - ColourGreyMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallicEClass); BudgetTotal = Budget - ColourGreyMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Rose gold – metallic")
                                            {
                                                Console.WriteLine("This colour only applies to the A-Class Compact Saloon and the B-Class Tourer!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will cost an extra £625 for both models!");
                                                        string[] MercedesModelsColourRoseGold = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer" }; // An array of all the Mercedes models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourRoseGold)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Rose gold - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour rose gold - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Rose gold - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour rose gold - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Rose gold - metallic), will cost " + ColourRoseGoldMetallic); BudgetTotal = Budget - ColourRoseGoldMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour rose gold - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Rose gold - metallic), will cost " + ColourRoseGoldMetallic); BudgetTotal = Budget - ColourRoseGoldMetallic; } } // If the user chose the B-Class Tourer, and the colour rose gold - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("The colour you have picked is not available"); } // If the colour doesn't match, then that colour is not available and a message is displayed to the user
                                }
                                Console.WriteLine("The " + MercedesModel + "only have one set of wheels, the 17” alloy wheels 5-twin-spoke design. Though, they are standard on this mode, so don't cost anything.");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only wheels for this model are the 17” alloy wheels 5-twin-spoke design. These don't cost anything extra and are standard with the car."); sw.Close(); } // If the user chooses this model, these are the only wheels available - so this will be written to the 'cardetails' file
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only tyres that come available with the models are ones that come with the standard wheels."); sw.Close(); } // If the user chooses this model, these are the only wheels available - so this will be written to the 'cardetails' file
                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.");
                                Console.WriteLine("Note: This model has no additional extras available to choose from.");
                                Console.WriteLine("You have now completed building your car!");
                                Console.WriteLine("Note: There is no way of checking that you can afford it or not as that system caused problems so was not implemented.");
                                Boolean DepositConfirmationLoop = false; // A loop to make sure the deposit is paid. Set to false by default
                                while (!DepositConfirmationLoop) // A while loop to confirm if it has been paid
                                {
                                    Console.WriteLine("Before you can purchase it, have you paid your deposit and has it cleared? (Y or N):");
                                    string DepositConfirmation = Console.ReadLine().ToUpper();
                                    switch (DepositConfirmation)
                                    {
                                        case "Y": // If the user has paid their deposit, break out of the loop
                                            Console.WriteLine("You may now confirm your payment!"); DepositConfirmationLoop = true; break;
                                        default: Console.WriteLine("Please make it has been paid before you continue!"); break; // If the user still needs to pay the deposit, go back and ask again
                                    }
                                }
                                Boolean PurchaseConfirmationLoop = false; // A loop ot make sure the purchase confirmation is complete. Set to false by default
                                while (!PurchaseConfirmationLoop)
                                {
                                    Console.WriteLine("Before you confirm your purchase, please note that once you do, you cannot change your mind! Are you happy with your purchase? (Y or N):");
                                    string PurchaseConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (PurchaseConfirmation)
                                    {
                                        case "Y": // If the user is happy with their purchase
                                            Console.WriteLine("You can now pay for your car and confirm your purchase!");
                                            Console.WriteLine("Thank you for using the Car Builder App!"); PurchaseConfirmationLoop = true; break;
                                        default: Console.WriteLine("You can start the program again and build a new car!"); System.Environment.Exit(0); break; // If the user still isn't sure, they can quit the program and start again
                                    }
                                }
                            }
                            else if (ChosenMercedesModel == "B-Class Tourer" || ChosenMercedesModel == "b-class tourer" || ChosenMercedesModel == "B-CLASS TOURER") // Allows all types to be entered by the user
                            {
                                Console.WriteLine("You have chosen the B-Class Tourer!"); MercedesModelLoop = true; // The loop is true, as the string matched
                                string MercedesModel = "B-Class Tourer"; // A string for the model
                                string MercedesEngine = "B 200 Sport Executive Edition"; // A string for the engine for this model
                                int EnginePrice = 32675; // Integer called 'EnginePrice' that has been created and assigned the value of 32675
                                Console.WriteLine("The " + MercedesModel + "only have one engine, the " + MercedesEngine + ", which will cost £32,675");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only engine available for this model, the " + MercedesEngine + ", will cost £32,675"); sw.Close(); } // If the user chooses this model, this is the only available engine - so this will be written to the 'cardetails' file
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The only engine for this model, the " + MercedesEngine + ", will cost " + EnginePrice); BudgetTotal = Budget - EnginePrice; sw.Close(); } // If the user chooses this model, this is the only available engine - so this will be written to the 'userbudget' file
                                string[] MercedesColours = new[] { "White", "Red – metallic", "White – metallic", "Black – metallic", "Blue – metallic", "Silver – metallic", "Grey – metallic", "Rose gold – metallic" }; // Array of all colours for all Mercedes models
                                Array.Sort(MercedesColours); // The array will be sorted
                                int ColourRedMetallicAClass = 831; // An integer (ColourRedMetallicAClass) has been created and assigned the value of 831
                                int ColourRedMetallic_C_Class = 925; // An integer (ColourRedMetallic_C_Class) has been created and assigned the value of 925
                                int ColourRedMetallicEClass = 1095; // An integer (ColourRedMetallicEClass) has been created and assigned the value of 1095
                                int ColourWhiteMetallic = 625; // An integer (ColourWhiteMetallic) has been created and assigned the value of 625
                                int ColourBlackMetallic = 625; // An integer (ColourBlackMetallic) has been created and assigned the value of 625
                                int ColourBlackMetallic_C_Class = 715; // An integer (ColourBlackMetallic_C_Class) has been created and assigned the value of 715
                                int ColourBlackMetallicEClass = 895; // An integer (ColourBlackMetallicEClass) has been created and assigned the value of 895
                                int ColourBlueMetallic = 625; // An integer (ColourBlueMetallic) has been created and assigned the value of 625
                                int ColourBlueMetallic_C_Class = 715; // An integer (ColourBlueMetallic_C_Class) has been created and assigned the value of 715
                                int ColourBlueMetallicEClass = 895; // An integer (ColourBlueMetallicEClass) has been created and assigned the value of 895
                                int ColourSilverMetallic = 625; // An integer (ColourSilverMetallic) has been created and assigned the value of 625
                                int ColourSilverMetallic_C_Class = 715; // An integer (ColourSilverMetallic_C_Class) has been created and assigned the value of 715
                                int ColourSilverMetallicEClass = 895; // An integer (ColourSilverMetallicEClass) has been created and assigned the value of 895
                                int ColourGreyMetallic = 625; // An integer (ColourGreyMetallic) has been created and assigned the value of 625
                                int ColourGreyMetallic_C_Class = 715; // An integer (ColourGreyMetallic_C_Class) has been created and assigned the value of 715
                                int ColourGreyMetallicEClass = 895; // An integer (ColourGreyMetallicEClass) has been created and assigned the value of 895
                                int ColourRoseGoldMetallic = 625; // An integer (ColourRoseGoldMetallic) has been created and assigned the value of 625
                                Console.WriteLine("These are the colours you can choose from:");
                                foreach (string a in MercedesColours) { Console.WriteLine(a); } // Using a foreach loop to display all of the elements in the array to the user (to show all of the available colours)
                                Boolean MercedesCompatibleCombinationLoop = false; // A loop to make sure the colour and model combination matches. Set to false by default
                                while (!MercedesCompatibleCombinationLoop) // The while loop to the check the combination
                                {
                                    Console.WriteLine("\nNote 1: Some colours will cost extra if chosen, or might not be avaliable, depending on the model selected!"); // Message to the user about extra cost for certain colours
                                    Console.WriteLine("Note 2: Please enter the chosen colour EXACTLY as it is shown to you, otherwise, the program will not accept it. This is due to a coding fault, but could be fixed in the future!\n");// Another message to the user regarding exact spelling of the words
                                    Console.WriteLine("Please choose a colour: ");
                                    string ChosenMercedesColour = Console.ReadLine(); // A local variable called 'ChosenBMWColour' is created and whatever the user types in is set to that variable
                                    int MercedesColourIndex = Array.BinarySearch(MercedesColours, ChosenMercedesColour); // Searches the entire array (BMWColours) and sees if the colours that is input by the user matches
                                    if (MercedesColourIndex >= 0) // If the colour chosen is greater-than or equal to the first index in the array AND matches, output the colour and the position in the array
                                    {
                                        Console.WriteLine(ChosenMercedesColour + " is found at " + MercedesColourIndex.ToString() + " position!");
                                            if (ChosenMercedesColour == "White") // Nested if statements that will go through all of the colours to inform the user about availability per model
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour is the standard colour, so will not cost any additional money!");
                                                string[] MercedesModelsColourWhite = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourWhite)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the A-Class Compact Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the B-Class Tourer, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the C-Class Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the E-Class Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Red – metallic")
                                            {
                                                Console.WriteLine("This colour is available on the A-Class Compact Saloon, the C-Class Saloon and the E-Class Saloon!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The cost of the colour on the A-Class Compact Saloon will be an extra £831!\nThe cost of the colour on the C-Class Saloon will be an extra £925!\nHowever, it will cost the most expensive on the E-Class Saloon (£1,095 extra)!");
                                                        string[] MercedesModelsColourRed = new[] { "1 - A-Class Compact Saloon", "2 - C-Class Saloon", "3 - E-Class Saloon" }; // An array of all the Mercedes models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourRed)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £831."); } } // If the user chose the A-Class Compact Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £925."); } } // If the user chose the C-Class Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £1,095."); } } // If the user chose the E-Class Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallicAClass); BudgetTotal = Budget - ColourRedMetallicAClass; } } // If the user chose the A-Class Compact Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallic_C_Class); BudgetTotal = Budget - ColourRedMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallicEClass); BudgetTotal = Budget - ColourRedMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenMercedesColour == "White – metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the A-Class Compact Saloon!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will cost an extra £625!");
                                                        string MercedesModelColourWhiteMetallic = "A-Class Compact Saloon"; // A string of the Mercedes model that the colour applies to
                                                        Console.WriteLine("The " + MercedesModelColourWhiteMetallic + "is the model that supports this colour and it will cost an extra £625!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenMercedesColour == "White – metallic") { sw.WriteLine("The colour you've chosen is White - metallic. This colour will cost an extra £625."); sw.Close(); } } // If the user chose the A-Class Compact Saloon and the colour white - metallic, this will write to the 'CarDetails' file is this colour is chosen
                                                        // If the user chose the A-Class Compact Saloon, and the colour white - metallic, this will write the price of the colour to the 'UserBudget' file
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenMercedesColour == "White - metallic") { sw.WriteLine("The colour you've chosen, (White - metallic), will cost" + ColourWhiteMetallic); BudgetTotal = Budget - ColourWhiteMetallic; sw.Close(); } } 
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenMercedesColour == "Black – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourBlack = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourBlack)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the B-Class Tourer, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic_C_Class); BudgetTotal = Budget - ColourBlackMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallicEClass); BudgetTotal = Budget - ColourBlackMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Blue – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourBlue = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourBlue)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the B-Class Tourer, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic_C_Class); BudgetTotal = Budget - ColourBlueMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallicEClass); BudgetTotal = Budget - ColourBlueMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Silver – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourSilver = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourSilver)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic); BudgetTotal = Budget - ColourSilverMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic); BudgetTotal = Budget - ColourSilverMetallic; } } // If the user chose the B-Class Tourer, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic_C_Class); BudgetTotal = Budget - ColourSilverMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallicEClass); BudgetTotal = Budget - ColourSilverMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Grey – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourGrey = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourGrey)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the B-Class Tourer, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic_C_Class); BudgetTotal = Budget - ColourGreyMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallicEClass); BudgetTotal = Budget - ColourGreyMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Rose gold – metallic")
                                            {
                                                Console.WriteLine("This colour only applies to the A-Class Compact Saloon and the B-Class Tourer!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will cost an extra £625 for both models!");
                                                        string[] MercedesModelsColourRoseGold = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer" }; // An array of all the Mercedes models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourRoseGold)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Rose gold - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour rose gold - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Rose gold - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour rose gold - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Rose gold - metallic), will cost " + ColourRoseGoldMetallic); BudgetTotal = Budget - ColourRoseGoldMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour rose gold - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Rose gold - metallic), will cost " + ColourRoseGoldMetallic); BudgetTotal = Budget - ColourRoseGoldMetallic; } } // If the user chose the B-Class Tourer, and the colour rose gold - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("The colour you have picked is not available"); } // If the colour doesn't match, then that colour is not available and a message is displayed to the user
                                }
                                Console.WriteLine("The " + MercedesModel + "only have one set of wheels, the 45.7cm (18-inch) multi-spoke light-alloy wheels. Though, they are standard on this mode, so don't cost anything.");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only wheels for this model are the 45.7cm (18-inch) multi-spoke light-alloy wheels. These don't cost anything extra and are standard with the car."); sw.Close(); } // If the user chooses this model, these are the only wheels available - so this will be written to the 'cardetails' file
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only tyres that come available with the models are ones that come with the standard wheels."); sw.Close(); } // If the user chooses this model, these are the only wheels available - so this will be written to the 'cardetails' file
                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.");
                                Console.WriteLine("Note: This model has no additional extras available to choose from.");
                                Console.WriteLine("You have now completed building your car!");
                                Console.WriteLine("Note: There is no way of checking that you can afford it or not as that system caused problems so was not implemented.");
                                Boolean DepositConfirmationLoop = false; // A loop to make sure the deposit is paid. Set to false by default
                                while (!DepositConfirmationLoop) // A while loop to confirm if it has been paid
                                {
                                    Console.WriteLine("Before you can purchase it, have you paid your deposit and has it cleared? (Y or N):");
                                    string DepositConfirmation = Console.ReadLine().ToUpper();
                                    switch (DepositConfirmation)
                                    {
                                        case "Y": // If the user has paid their deposit, break out of the loop
                                            Console.WriteLine("You may now confirm your payment!"); DepositConfirmationLoop = true; break;
                                        default: Console.WriteLine("Please make it has been paid before you continue!"); break; // If the user still needs to pay the deposit, go back and ask again
                                    }
                                }
                                Boolean PurchaseConfirmationLoop = false; // A loop ot make sure the purchase confirmation is complete. Set to false by default
                                while (!PurchaseConfirmationLoop)
                                {
                                    Console.WriteLine("Before you confirm your purchase, please note that once you do, you cannot change your mind! Are you happy with your purchase? (Y or N):");
                                    string PurchaseConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (PurchaseConfirmation)
                                    {
                                        case "Y": // If the user is happy with their purchase
                                            Console.WriteLine("You can now pay for your car and confirm your purchase!");
                                            Console.WriteLine("Thank you for using the Car Builder App!"); PurchaseConfirmationLoop = true; break;
                                        default: Console.WriteLine("You can start the program again and build a new car!"); System.Environment.Exit(0); break; // If the user still isn't sure, they can quit the program and start again
                                    }
                                }
                            }
                            else if (ChosenMercedesModel == "C-Class Saloon" || ChosenMercedesModel == "c-class saloon" || ChosenMercedesModel == "C-CLASS SALOON") // Allows all types to be entered by the user
                            {
                                Console.WriteLine("You have chosen the C-Class Saloon!"); MercedesModelLoop = true; // The loop is true, as the string matched
                                string MercedesModel = "C-Class Saloon"; // A string for the model
                                string MercedesEngine = "C 200 AMG Line Saloon"; // A string for the engine for this model
                                int EnginePrice = 41240; // Integer called 'EnginePrice' that has been created and assigned the value of 41240
                                Console.WriteLine("The " + MercedesModel + "only have one engine, the " + MercedesEngine + ", which will cost £41,240");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only engine available for this model, the " + MercedesEngine + ", will cost £41,240"); sw.Close(); } // If the user chooses this model, this is the only available engine - so this will be written to the 'cardetails' file
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The only engine for this model, the " + MercedesEngine + ", will cost " + EnginePrice); BudgetTotal = Budget - EnginePrice; sw.Close(); } // If the user chooses this model, this is the only available engine - so this will be written to the 'userbudget' file
                                string[] MercedesColours = new[] { "White", "Red – metallic", "White – metallic", "Black – metallic", "Blue – metallic", "Silver – metallic", "Grey – metallic", "Rose gold – metallic" }; // Array of all colours for all Mercedes models
                                Array.Sort(MercedesColours); // The array will be sorted
                                int ColourRedMetallicAClass = 831; // An integer (ColourRedMetallicAClass) has been created and assigned the value of 831
                                int ColourRedMetallic_C_Class = 925; // An integer (ColourRedMetallic_C_Class) has been created and assigned the value of 925
                                int ColourRedMetallicEClass = 1095; // An integer (ColourRedMetallicEClass) has been created and assigned the value of 1095
                                int ColourWhiteMetallic = 625; // An integer (ColourWhiteMetallic) has been created and assigned the value of 625
                                int ColourBlackMetallic = 625; // An integer (ColourBlackMetallic) has been created and assigned the value of 625
                                int ColourBlackMetallic_C_Class = 715; // An integer (ColourBlackMetallic_C_Class) has been created and assigned the value of 715
                                int ColourBlackMetallicEClass = 895; // An integer (ColourBlackMetallicEClass) has been created and assigned the value of 895
                                int ColourBlueMetallic = 625; // An integer (ColourBlueMetallic) has been created and assigned the value of 625
                                int ColourBlueMetallic_C_Class = 715; // An integer (ColourBlueMetallic_C_Class) has been created and assigned the value of 715
                                int ColourBlueMetallicEClass = 895; // An integer (ColourBlueMetallicEClass) has been created and assigned the value of 895
                                int ColourSilverMetallic = 625; // An integer (ColourSilverMetallic) has been created and assigned the value of 625
                                int ColourSilverMetallic_C_Class = 715; // An integer (ColourSilverMetallic_C_Class) has been created and assigned the value of 715
                                int ColourSilverMetallicEClass = 895; // An integer (ColourSilverMetallicEClass) has been created and assigned the value of 895
                                int ColourGreyMetallic = 625; // An integer (ColourGreyMetallic) has been created and assigned the value of 625
                                int ColourGreyMetallic_C_Class = 715; // An integer (ColourGreyMetallic_C_Class) has been created and assigned the value of 715
                                int ColourGreyMetallicEClass = 895; // An integer (ColourGreyMetallicEClass) has been created and assigned the value of 895
                                int ColourRoseGoldMetallic = 625; // An integer (ColourRoseGoldMetallic) has been created and assigned the value of 625
                                Console.WriteLine("These are the colours you can choose from:");
                                foreach (string a in MercedesColours) { Console.WriteLine(a); } // Using a foreach loop to display all of the elements in the array to the user (to show all of the available colours)
                                Boolean MercedesCompatibleCombinationLoop = false; // A loop to make sure the colour and model combination matches. Set to false by default
                                while (!MercedesCompatibleCombinationLoop) // The while loop to the check the combination
                                {
                                    Console.WriteLine("\nNote 1: Some colours will cost extra if chosen, or might not be avaliable, depending on the model selected!"); // Message to the user about extra cost for certain colours
                                    Console.WriteLine("Note 2: Please enter the chosen colour EXACTLY as it is shown to you, otherwise, the program will not accept it. This is due to a coding fault, but could be fixed in the future!\n");// Another message to the user regarding exact spelling of the words
                                    Console.WriteLine("Please choose a colour: ");
                                    string ChosenMercedesColour = Console.ReadLine(); // A local variable called 'ChosenBMWColour' is created and whatever the user types in is set to that variable
                                    int MercedesColourIndex = Array.BinarySearch(MercedesColours, ChosenMercedesColour); // Searches the entire array (BMWColours) and sees if the colours that is input by the user matches
                                    if (MercedesColourIndex >= 0) // If the colour chosen is greater-than or equal to the first index in the array AND matches, output the colour and the position in the array
                                    {
                                        Console.WriteLine(ChosenMercedesColour + " is found at " + MercedesColourIndex.ToString() + " position!");
                                            if (ChosenMercedesColour == "White") // Nested if statements that will go through all of the colours to inform the user about availability per model
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour is the standard colour, so will not cost any additional money!");
                                                string[] MercedesModelsColourWhite = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourWhite)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the A-Class Compact Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the B-Class Tourer, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the C-Class Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the E-Class Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Red – metallic")
                                            {
                                                Console.WriteLine("This colour is available on the A-Class Compact Saloon, the C-Class Saloon and the E-Class Saloon!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The cost of the colour on the A-Class Compact Saloon will be an extra £831!\nThe cost of the colour on the C-Class Saloon will be an extra £925!\nHowever, it will cost the most expensive on the E-Class Saloon (£1,095 extra)!");
                                                        string[] MercedesModelsColourRed = new[] { "1 - A-Class Compact Saloon", "2 - C-Class Saloon", "3 - E-Class Saloon" }; // An array of all the Mercedes models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourRed)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £831."); } } // If the user chose the A-Class Compact Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £925."); } } // If the user chose the C-Class Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £1,095."); } } // If the user chose the E-Class Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallicAClass); BudgetTotal = Budget - ColourRedMetallicAClass; } } // If the user chose the A-Class Compact Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallic_C_Class); BudgetTotal = Budget - ColourRedMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallicEClass); BudgetTotal = Budget - ColourRedMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenMercedesColour == "White – metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the A-Class Compact Saloon!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will cost an extra £625!");
                                                        string MercedesModelColourWhiteMetallic = "A-Class Compact Saloon"; // A string of the Mercedes model that the colour applies to
                                                        Console.WriteLine("The " + MercedesModelColourWhiteMetallic + "is the model that supports this colour and it will cost an extra £625!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenMercedesColour == "White – metallic") { sw.WriteLine("The colour you've chosen is White - metallic. This colour will cost an extra £625."); sw.Close(); } } // If the user chose the A-Class Compact Saloon and the colour white - metallic, this will write to the 'CarDetails' file is this colour is chosen
                                                        // If the user chose the A-Class Compact Saloon, and the colour white - metallic, this will write the price of the colour to the 'UserBudget' file
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenMercedesColour == "White - metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you've chosen, (White - metallic), will cost" + ColourWhiteMetallic); BudgetTotal = Budget - ColourWhiteMetallic; sw.Close(); } } 
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenMercedesColour == "Black – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourBlack = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourBlack)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the B-Class Tourer, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic_C_Class); BudgetTotal = Budget - ColourBlackMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallicEClass); BudgetTotal = Budget - ColourBlackMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Blue – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourBlue = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourBlue)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the B-Class Tourer, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic_C_Class); BudgetTotal = Budget - ColourBlueMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallicEClass); BudgetTotal = Budget - ColourBlueMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Silver – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourSilver = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourSilver)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic); BudgetTotal = Budget - ColourSilverMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic); BudgetTotal = Budget - ColourSilverMetallic; } } // If the user chose the B-Class Tourer, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic_C_Class); BudgetTotal = Budget - ColourSilverMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallicEClass); BudgetTotal = Budget - ColourSilverMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Grey – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourGrey = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourGrey)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the B-Class Tourer, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic_C_Class); BudgetTotal = Budget - ColourGreyMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallicEClass); BudgetTotal = Budget - ColourGreyMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Rose gold – metallic")
                                            {
                                                Console.WriteLine("This colour only applies to the A-Class Compact Saloon and the B-Class Tourer!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will cost an extra £625 for both models!");
                                                        string[] MercedesModelsColourRoseGold = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer" }; // An array of all the Mercedes models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourRoseGold)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Rose gold - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour rose gold - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Rose gold - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour rose gold - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Rose gold - metallic), will cost " + ColourRoseGoldMetallic); BudgetTotal = Budget - ColourRoseGoldMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour rose gold - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Rose gold - metallic), will cost " + ColourRoseGoldMetallic); BudgetTotal = Budget - ColourRoseGoldMetallic; } } // If the user chose the B-Class Tourer, and the colour rose gold - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("The colour you have picked is not available"); } // If the colour doesn't match, then that colour is not available and a message is displayed to the user
                                }
                                Console.WriteLine("The " + MercedesModel + "only have one set of wheels, the 45.7cm (18-inch) AMG 5-spoke light-alloy wheels. Though, they are standard on this mode, so don't cost anything.");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only wheels for this model are the 45.7cm (18-inch) AMG 5-spoke light-alloy wheels. These don't cost anything extra and are standard with the car."); sw.Close(); } // If the user chooses this model, these are the only wheels available - so this will be written to the 'cardetails' file
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only tyres that come available with the models are ones that come with the standard wheels."); sw.Close(); } // If the user chooses this model, these are the only wheels available - so this will be written to the 'cardetails' file
                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.");
                                Console.WriteLine("Note: This model has no additional extras available to choose from.");
                                Console.WriteLine("You have now completed building your car!");
                                Console.WriteLine("Note: There is no way of checking that you can afford it or not as that system caused problems so was not implemented.");
                                Boolean DepositConfirmationLoop = false; // A loop to make sure the deposit is paid. Set to false by default
                                while (!DepositConfirmationLoop) // A while loop to confirm if it has been paid
                                {
                                    Console.WriteLine("Before you can purchase it, have you paid your deposit and has it cleared? (Y or N):");
                                    string DepositConfirmation = Console.ReadLine().ToUpper();
                                    switch (DepositConfirmation)
                                    {
                                        case "Y": // If the user has paid their deposit, break out of the loop
                                            Console.WriteLine("You may now confirm your payment!"); DepositConfirmationLoop = true; break;
                                        default: Console.WriteLine("Please make it has been paid before you continue!"); break; // If the user still needs to pay the deposit, go back and ask again
                                    }
                                }
                                Boolean PurchaseConfirmationLoop = false; // A loop ot make sure the purchase confirmation is complete. Set to false by default
                                while (!PurchaseConfirmationLoop)
                                {
                                    Console.WriteLine("Before you confirm your purchase, please note that once you do, you cannot change your mind! Are you happy with your purchase? (Y or N):");
                                    string PurchaseConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (PurchaseConfirmation)
                                    {
                                        case "Y": // If the user is happy with their purchase
                                            Console.WriteLine("You can now pay for your car and confirm your purchase!");
                                            Console.WriteLine("Thank you for using the Car Builder App!"); PurchaseConfirmationLoop = true; break;
                                        default: Console.WriteLine("You can start the program again and build a new car!"); System.Environment.Exit(0); break; // If the user still isn't sure, they can quit the program and start again
                                    }
                                }
                            }
                            else if (ChosenMercedesModel == "E-Class Saloon" || ChosenMercedesModel == "e-class saloon" || ChosenMercedesModel == "E-CLASS SALOON") // Allows both types to be entered by the user
                            {
                                Console.WriteLine("You have chosen the E-Class Saloon!"); MercedesModelLoop = true; // The loop is true, as the string matched
                                string MercedesModel = "E-Class Saloon"; // A string for the model
                                string MercedesEngine = "E 220 d Sport Saloon"; // A string for the engine for this model
                                int EnginePrice = 42135; // Integer called 'EnginePrice' that has been created and assigned the value of 42135
                                Console.WriteLine("The " + MercedesModel + "only have one engine, the " + MercedesEngine + ", which will cost £42,135");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only engine available for this model, the " + MercedesEngine + ", will cost £42,135"); sw.Close(); } // If the user chooses this model, this is the only available engine - so this will be written to the 'cardetails' file
                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The only engine for this model, the " + MercedesEngine + ", will cost " + EnginePrice); BudgetTotal = Budget - EnginePrice; sw.Close(); } // If the user chooses this model, this is the only available engine - so this will be written to the 'userbudget' file
                                string[] MercedesColours = new[] { "White", "Red – metallic", "White – metallic", "Black – metallic", "Blue – metallic", "Silver – metallic", "Grey – metallic", "Rose gold – metallic" }; // Array of all colours for all Mercedes models
                                Array.Sort(MercedesColours); // The array will be sorted
                                int ColourRedMetallicAClass = 831; // An integer (ColourRedMetallicAClass) has been created and assigned the value of 831
                                int ColourRedMetallic_C_Class = 925; // An integer (ColourRedMetallic_C_Class) has been created and assigned the value of 925
                                int ColourRedMetallicEClass = 1095; // An integer (ColourRedMetallicEClass) has been created and assigned the value of 1095
                                int ColourWhiteMetallic = 625; // An integer (ColourWhiteMetallic) has been created and assigned the value of 625
                                int ColourBlackMetallic = 625; // An integer (ColourBlackMetallic) has been created and assigned the value of 625
                                int ColourBlackMetallic_C_Class = 715; // An integer (ColourBlackMetallic_C_Class) has been created and assigned the value of 715
                                int ColourBlackMetallicEClass = 895; // An integer (ColourBlackMetallicEClass) has been created and assigned the value of 895
                                int ColourBlueMetallic = 625; // An integer (ColourBlueMetallic) has been created and assigned the value of 625
                                int ColourBlueMetallic_C_Class = 715; // An integer (ColourBlueMetallic_C_Class) has been created and assigned the value of 715
                                int ColourBlueMetallicEClass = 895; // An integer (ColourBlueMetallicEClass) has been created and assigned the value of 895
                                int ColourSilverMetallic = 625; // An integer (ColourSilverMetallic) has been created and assigned the value of 625
                                int ColourSilverMetallic_C_Class = 715; // An integer (ColourSilverMetallic_C_Class) has been created and assigned the value of 715
                                int ColourSilverMetallicEClass = 895; // An integer (ColourSilverMetallicEClass) has been created and assigned the value of 895
                                int ColourGreyMetallic = 625; // An integer (ColourGreyMetallic) has been created and assigned the value of 625
                                int ColourGreyMetallic_C_Class = 715; // An integer (ColourGreyMetallic_C_Class) has been created and assigned the value of 715
                                int ColourGreyMetallicEClass = 895; // An integer (ColourGreyMetallicEClass) has been created and assigned the value of 895
                                int ColourRoseGoldMetallic = 625; // An integer (ColourRoseGoldMetallic) has been created and assigned the value of 625
                                Console.WriteLine("These are the colours you can choose from:");
                                foreach (string a in MercedesColours) { Console.WriteLine(a); } // Using a foreach loop to display all of the elements in the array to the user (to show all of the available colours)
                                Boolean MercedesCompatibleCombinationLoop = false; // A loop to make sure the colour and model combination matches. Set to false by default
                                while (!MercedesCompatibleCombinationLoop) // The while loop to the check the combination
                                {
                                    Console.WriteLine("\nNote 1: Some colours will cost extra if chosen, or might not be avaliable, depending on the model selected!"); // Message to the user about extra cost for certain colours
                                    Console.WriteLine("Note 2: Please enter the chosen colour EXACTLY as it is shown to you, otherwise, the program will not accept it. This is due to a coding fault, but could be fixed in the future!\n");// Another message to the user regarding exact spelling of the words
                                    Console.WriteLine("Please choose a colour: ");
                                    string ChosenMercedesColour = Console.ReadLine(); // A local variable called 'ChosenBMWColour' is created and whatever the user types in is set to that variable
                                    int MercedesColourIndex = Array.BinarySearch(MercedesColours, ChosenMercedesColour); // Searches the entire array (BMWColours) and sees if the colours that is input by the user matches
                                    if (MercedesColourIndex >= 0) // If the colour chosen is greater-than or equal to the first index in the array AND matches, output the colour and the position in the array
                                    {
                                        Console.WriteLine(ChosenMercedesColour + " is found at " + MercedesColourIndex.ToString() + " position!");
                                            if (ChosenMercedesColour == "White") // Nested if statements that will go through all of the colours to inform the user about availability per model
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour is the standard colour, so will not cost any additional money!");
                                                string[] MercedesModelsColourWhite = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourWhite)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "White") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the A-Class Compact Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the B-Class Tourer, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the C-Class Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "White") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen is White, but it is the standard colour and will not cost any extra money."); } } // If the user chose the E-Class Saloon, and the colour white, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Red – metallic")
                                            {
                                                Console.WriteLine("This colour is available on the A-Class Compact Saloon, the C-Class Saloon and the E-Class Saloon!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will be priced different depending on the model:");
                                                        Console.WriteLine("The cost of the colour on the A-Class Compact Saloon will be an extra £831!\nThe cost of the colour on the C-Class Saloon will be an extra £925!\nHowever, it will cost the most expensive on the E-Class Saloon (£1,095 extra)!");
                                                        string[] MercedesModelsColourRed = new[] { "1 - A-Class Compact Saloon", "2 - C-Class Saloon", "3 - E-Class Saloon" }; // An array of all the Mercedes models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourRed)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £831."); } } // If the user chose the A-Class Compact Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £925."); } } // If the user chose the C-Class Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Red – metallic. This colour will cost an extra £1,095."); } } // If the user chose the E-Class Saloon, and the colour red - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallicAClass); BudgetTotal = Budget - ColourRedMetallicAClass; } } // If the user chose the A-Class Compact Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallic_C_Class); BudgetTotal = Budget - ColourRedMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Red – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Red – metallic), will cost " + ColourRedMetallicEClass); BudgetTotal = Budget - ColourRedMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour red - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenMercedesColour == "White – metallic")
                                            {
                                                Console.WriteLine("This colour is only available on the A-Class Compact Saloon!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will cost an extra £625!");
                                                        string MercedesModelColourWhiteMetallic = "A-Class Compact Saloon"; // A string of the Mercedes model that the colour applies to
                                                        Console.WriteLine("The " + MercedesModelColourWhiteMetallic + "is the model that supports this colour and it will cost an extra £625!");
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) { if (ChosenMercedesColour == "White – metallic") { sw.WriteLine("The colour you've chosen is White - metallic. This colour will cost an extra £625."); sw.Close(); } } // If the user chose the A-Class Compact Saloon and the colour white - metallic, this will write to the 'CarDetails' file is this colour is chosen
                                                        // If the user chose the A-Class Compact Saloon, and the colour white - metallic, this will write the price of the colour to the 'UserBudget' file
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) { if (ChosenMercedesColour == "White - metallic") { sw.WriteLine("Your current budget is: " + Budget); sw.WriteLine("The colour you've chosen, (White - metallic), will cost" + ColourWhiteMetallic); BudgetTotal = Budget - ColourWhiteMetallic; sw.Close(); } } 
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                            if (ChosenMercedesColour == "Black – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourBlack = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourBlack)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen is Black - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour black - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic); BudgetTotal = Budget - ColourBlackMetallic; } } // If the user chose the B-Class Tourer, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallic_C_Class); BudgetTotal = Budget - ColourBlackMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Black – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Black - metallic), will cost " + ColourBlackMetallicEClass); BudgetTotal = Budget - ColourBlackMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour black - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Blue – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourBlue = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourBlue)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Blue - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour blue - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic); BudgetTotal = Budget - ColourBlueMetallic; } } // If the user chose the B-Class Tourer, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallic_C_Class); BudgetTotal = Budget - ColourBlueMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Blue – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Blue - metallic), will cost " + ColourBlueMetallicEClass); BudgetTotal = Budget - ColourBlueMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour blue - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Silver – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourSilver = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourSilver)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Silver - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour silver - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic); BudgetTotal = Budget - ColourSilverMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic); BudgetTotal = Budget - ColourSilverMetallic; } } // If the user chose the B-Class Tourer, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallic_C_Class); BudgetTotal = Budget - ColourSilverMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Silver – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Silver - metallic), will cost " + ColourSilverMetallicEClass); BudgetTotal = Budget - ColourSilverMetallicEClass; } } // If the user chose the E-Class Saloon, and the colour silver - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Grey – metallic")
                                            {
                                                Console.WriteLine("This colour is available on all Mercedes models!");
                                                Console.WriteLine("The colour will cost an extra £625 to be applied to the A-Class Compact Saloon or the B-Class Tourer!\nIf the colour is going to be applied to the C-Class Saloon, it will cost an extra £715!\nHowever, if this colour is going to be applied to the E-Class Saloon, it will cost the most (£895 extra)!");
                                                string[] MercedesModelsColourGrey = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer", "3 - C-Class Saloon", "4 - E-Class Saloon" }; // An array of all the Mercedes models
                                                Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourGrey)); // All of the models are displayed from the array, line by line
                                                Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                {
                                                    if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £715."); } } // If the user chose the C-Class Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen is Grey - metallic. This colour will cost an extra £895."); } } // If the user chose the E-Class Saloon, and the colour grey - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                {
                                                    sw.WriteLine("Your current budget is: " + Budget);
                                                    if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic); BudgetTotal = Budget - ColourGreyMetallic; } } // If the user chose the B-Class Tourer, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 3) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallic_C_Class); BudgetTotal = Budget - ColourGreyMetallic_C_Class; } } // If the user chose the C-Class Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    else if (ChosenMercedesColour == "Grey – metallic") { if (ChosenModel == 4) { sw.WriteLine("The colour you've chosen, (Grey - metallic), will cost " + ColourGreyMetallicEClass); BudgetTotal = Budget - ColourGreyMetallicEClass; ; } } // If the user chose the E-Class Saloon, and the colour grey - metallic, this will write the price of the colour to the 'UserBudget' file
                                                    sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                }
                                                Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); break;
                                            }
                                            if (ChosenMercedesColour == "Rose gold – metallic")
                                            {
                                                Console.WriteLine("This colour only applies to the A-Class Compact Saloon and the B-Class Tourer!");
                                                Console.WriteLine("Is your selected model compatible with this colour? (Y or N):");
                                                string CompatibleCombination = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user, and will allow either upper or lower case
                                                switch (CompatibleCombination)
                                                {
                                                    case "Y": // If the user says that their colour and model are compatible, a message will be displayed to the user
                                                        Console.WriteLine("This colour will cost an extra £625 for both models!");
                                                        string[] MercedesModelsColourRoseGold = new[] { "1 - A-Class Compact Saloon", "2 - B-Class Tourer" }; // An array of all the Mercedes models that this colour is applicable to
                                                        Console.WriteLine(string.Join(Environment.NewLine, MercedesModelsColourRoseGold)); // All of the models are displayed from the array, line by line
                                                        Console.WriteLine("Which model did you select? Please enter the corresponding number to the model:");
                                                        int ChosenModel = Convert.ToInt32(Console.ReadLine()); // The chosen model is converted to a 32-bit integer
                                                        using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                                        {
                                                            if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen is Rose gold - metallic. This colour will cost an extra £625."); } } // If the user chose the A-Class Compact Saloon, and the colour rose gold - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            else if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen is Rose gold - metallic. This colour will cost an extra £625."); } } // If the user chose the B-Class Tourer, and the colour rose gold - metallic, this will write to the 'CarDetails' file if this colour is chosen
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        using (StreamWriter sw = File.AppendText(path: @"\userbudget.txt")) // The 'userbudget' file will be used here to save any details to be view after
                                                        {
                                                            sw.WriteLine("Your current budget is: " + Budget);
                                                            if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 1) { sw.WriteLine("The colour you've chosen, (Rose gold - metallic), will cost " + ColourRoseGoldMetallic); BudgetTotal = Budget - ColourRoseGoldMetallic; } } // If the user chose the A-Class Compact Saloon, and the colour rose gold - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            else if (ChosenMercedesColour == "Rose gold – metallic") { if (ChosenModel == 2) { sw.WriteLine("The colour you've chosen, (Rose gold - metallic), will cost " + ColourRoseGoldMetallic); BudgetTotal = Budget - ColourRoseGoldMetallic; } } // If the user chose the B-Class Tourer, and the colour rose gold - metallic, this will write the price of the colour to the 'UserBudget' file
                                                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                                                        }
                                                        Console.WriteLine("The breakdown of your budget has been saved to a file called 'userbudget'. You can view it if you wish.");
                                                        Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.\n"); MercedesCompatibleCombinationLoop = true; break;
                                                    default: Console.WriteLine("This colour is not compatible! Please select a different colour!\n"); break; // The default will assume the colour and model are not compatible
                                                }
                                            }
                                    }
                                    else { Console.WriteLine("The colour you have picked is not available"); } // If the colour doesn't match, then that colour is not available and a message is displayed to the user
                                }
                                Console.WriteLine("The " + MercedesModel + "only have one set of wheels, the 17” alloy wheels 5-twin-spoke design. Though, they are standard on this mode, so don't cost anything.");
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only wheels for this model are the 17” alloy wheels 5-twin-spoke design. These don't cost anything extra and are standard with the car."); sw.Close(); } // If the user chooses this model, these are the only wheels available - so this will be written to the 'cardetails' file
                                using (StreamWriter sw = File.AppendText(path: @"\cardetails.txt")) // The 'cardetails' file will be used here to save any details to be viewed after
                                { sw.WriteLine("The only tyres that come available with the models are ones that come with the standard wheels."); sw.Close(); } // If the user chooses this model, these are the only wheels available - so this will be written to the 'cardetails' file
                                Console.WriteLine("Your current car configuration has been saved to a file called 'cardetails'. You can view it if you wish.");
                                Console.WriteLine("Note: This model has no additional extras available to choose from.");
                                Console.WriteLine("You have now completed building your car!");
                                Console.WriteLine("Note: There is no way of checking that you can afford it or not as that system caused problems so was not implemented.");
                                Boolean DepositConfirmationLoop = false; // A loop to make sure the deposit is paid. Set to false by default
                                while (!DepositConfirmationLoop) // A while loop to confirm if it has been paid
                                {
                                    Console.WriteLine("Before you can purchase it, have you paid your deposit and has it cleared? (Y or N):");
                                    string DepositConfirmation = Console.ReadLine().ToUpper();
                                    switch (DepositConfirmation)
                                    {
                                        case "Y": // If the user has paid their deposit, break out of the loop
                                            Console.WriteLine("You may now confirm your payment!"); DepositConfirmationLoop = true; break;
                                        default: Console.WriteLine("Please make it has been paid before you continue!"); break; // If the user still needs to pay the deposit, go back and ask again
                                    }
                                }
                                Boolean PurchaseConfirmationLoop = false; // A loop ot make sure the purchase confirmation is complete. Set to false by default
                                while (!PurchaseConfirmationLoop)
                                {
                                    Console.WriteLine("Before you confirm your purchase, please note that once you do, you cannot change your mind! Are you happy with your purchase? (Y or N):");
                                    string PurchaseConfirmation = Console.ReadLine().ToUpper(); // Either 'Y' or 'N' is entered by the user and also allows caps and lower cases
                                    switch (PurchaseConfirmation)
                                    {
                                        case "Y": // If the user is happy with their purchase
                                            Console.WriteLine("You can now pay for your car and confirm your purchase!");
                                            Console.WriteLine("Thank you for using the Car Builder App!"); PurchaseConfirmationLoop = true; break;
                                        default: Console.WriteLine("You can start the program again and build a new car!"); System.Environment.Exit(0); break; // If the user still isn't sure, they can quit the program and start again
                                    }
                                }
                            }
                            else { Console.WriteLine("Please try again!"); } // ...otherwise, this message will appear and it will loop back round to ask the user to select a model again
                        }
                        break;
                    default: Console.WriteLine("Error! Please enter a number between 1 and 3!"); break;
                }
            }
            catch (FormatException) { Console.WriteLine("The input you have entered is invalid! Please try again!"); } // If the input entered is not valid (integers only), this error message will appear and the program will stop
            catch (OverflowException) { Console.WriteLine("This number is out of range for an integer!"); } // If the integer entered by the user is too big or too small, this error will appear
        }
        #endregion
        static void Main(string[] args)
        {
            Console.Title = "Car Builder"; // The name of the console which appears when the program is running
            BackgroundSelection(); // The BackgroundSelection() method is called here
            int LoginSelection = Login(); // The Login() method is called and applied to the LoginSelection in the main program
            string username; // A string for the username has been created
            string password; // A string for the password has been created
            Boolean success = false; // A loop to check if the login was successful will be set to false by default
            while (!success) // A while loop to check to see if any credentals entered are true (based on input from LoginSelection)
            {
                switch (LoginSelection) // A switch statement will be used, depending on which option the user has picked from the LoginSelection
                {
                    case 1: // If the user chooses to login using existing credentials
                        Console.WriteLine("Please enter your username: ");
                        username = Console.ReadLine(); // The username will be whatever the user types in
                        if (string.IsNullOrWhiteSpace(username)) { Console.WriteLine("You haven't entered a username!"); } // If the user has entered white space or nothing at all, this message will display
                        Console.WriteLine("Please enter your password: ");
                        password = Console.ReadLine(); // The password will be whatever the user types in
                        if (string.IsNullOrWhiteSpace(password)) { Console.WriteLine("You haven't entered a password!"); } // If the user has entered white space or nothing at all, this message will display
                        // If the credentials match, the user will be allowed to continue...
                        if (username == "vanessa" && password == "vanessa") { Console.WriteLine("\nWelcome, Vanessa!\n"); success = true; } // The loop is now set to true, as the login was successful
                        else if (username == "client" && password == "newcustomer") { Console.WriteLine("\nWelcome!\n"); success = true; } // The loop is now set to true, as the login was successful
                        else { Console.WriteLine("\nYour login has failed!\n"); } // ...but if not, this error message will appear
                        break;
                    case 2: // If the user chooses to register as a new user
                        string NewUsername; // A string for a new username (for a new user) has been created
                        string NewPassword; // A string for a new password (for a new user) has been created
                        Console.WriteLine("Please note that whatever you register with, this CANNOT be used to log back in - even though those credientials will be saved to a file. This is due to there having been no way to link the saved credientials to the login system!"); // A note to user about this option for the login system
                        Console.WriteLine("If you would like to register, please follow the steps below!\n");
                        Console.WriteLine("Please enter a username: ");
                        NewUsername = Console.ReadLine(); // The username will be whatever the user types in
                        if (string.IsNullOrWhiteSpace(NewUsername)) { Console.WriteLine("You haven't entered a username!"); } // If the user has entered white space or nothing at all, this message will display
                        Console.WriteLine("\nPlease enter a password: ");
                        NewPassword = Console.ReadLine(); // The password will be whatever the user types in
                        if (string.IsNullOrWhiteSpace(NewPassword)) { Console.WriteLine("You haven't entered a password!"); } // If the user has entered white space or nothing at all, this message will display
                        string NewUser = @"\newdetails.txt"; // A file has been created
                        StreamWriter stwr = File.CreateText(@"\newdetails.txt"); // StreamWriter object declared and any data will write to specified file
                        stwr.Flush();
                        stwr.Close(); // Closes the StreamWriter object and the stream buffer
                        using (StreamWriter sw = File.AppendText(NewUser))
                        {
                            sw.WriteLine(NewUsername); // The username that the user enters should write to the file
                            sw.WriteLine(NewPassword);  // The password that the user enters should write to the file
                            sw.Close(); // Closes the StreamWriter object and the stream buffer
                        }
                        success = true; break; // The loop is now set to true, as the login was successful
                    case 3: // If the user chooses to continue as a guest
                        Console.WriteLine("Please enter your username: ");
                        username = Console.ReadLine(); // The username will be whatever the user types in
                        if (string.IsNullOrWhiteSpace(username)) { Console.WriteLine("You haven't entered a username!"); } // If the user has entered white space or nothing at all, this message will display
                        Console.WriteLine("Please enter your password: ");
                        password = Console.ReadLine(); // The password will be whatever the user types in
                        if (string.IsNullOrWhiteSpace(password)) { Console.WriteLine("You haven't entered a password!"); } // If the user has entered white space or nothing at all, this message will display
                        if (username == "guest" && password == "guest") { Console.WriteLine("\nWelcome, guest!\n"); success = true; } // If the username and password are correct, the guest user will be welcomed
                        else { Console.WriteLine("\nYour login has failed!\n"); } // If the credientials are incorrect, the following message will be displayed to the user
                        break;
                    case 4: // The user decides to quit the program
                        System.Environment.Exit(0); break;
                }
            }
            CarBrands(); // CarBrands method is called here
            Console.ReadKey();
        }
    }
}