
// LRT2 Management System Console App to demonstrate the Gang of 4 Patterns
// Chain of Responsibility is used on buying tickets-customer side
//Builder is used on 

using LRTConsoleUsingGangOf4Patterns;

//Set-up a railway dictionary which will be used for admin transactions
Dictionary<int, string> railwayDict = new Dictionary<int, string>()
    {
        {1, "LRT-1: Yellow Line" }, {2, "LRT-2: Purple Line"}, {3, "MRT-3: Blue Line"}
    };
bool endApp = false;

while (!endApp)
{
    Console.Clear();
    Console.WriteLine("=================================================================");
    Console.WriteLine("Welcome to LRT2 Management System!");
    Console.WriteLine("Press the corresponding digit depending on the type of user");
    Console.WriteLine("[1] => Customer: Buy Train Ticket");
    Console.WriteLine("[2] => Admin: Manage Trains and Station \n");

    int choice = 0;
    Console.Write("Pick between 1 and 2: ");
    var input = Console.ReadLine();

    while (!int.TryParse(input, out choice) || choice <= 0 || choice > 2)
    {
        Console.Write("This is not valid input. Please pick between 1 and 2: ");
        input = Console.ReadLine();
    }

    Console.Clear();

    switch (choice)
    {
        case 1:
            int origin, destination;
            Console.WriteLine("\n====================================================");
            Console.WriteLine("Welcome Customer");
            Console.WriteLine("Choose your origin and destination stations below.\n");

            Dictionary<int, string> stationPicker = new Dictionary<int, string>();
            stationPicker.Add(1, "Antipolo");
            stationPicker.Add(2, "Marikina");
            stationPicker.Add(3, "Santolan");
            stationPicker.Add(4, "Katipunan");
            stationPicker.Add(5, "Anonas");
            stationPicker.Add(6, "Cubao");
            stationPicker.Add(7, "Betty Go");
            stationPicker.Add(8, "Gilmore");
            stationPicker.Add(9, "J Ruiz");
            stationPicker.Add(10, "V Mapa");
            stationPicker.Add(11, "Pureza");
            stationPicker.Add(12, "Legarda");
            stationPicker.Add(13, "Recto");

            foreach (KeyValuePair<int, string> station in stationPicker)
            {
                Console.WriteLine("[{0}] => {1}", station.Key, station.Value);
            }

            Console.Write("\nEnter the digit for the Origin: ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out origin) || origin <= 0 || origin > 13)
            {
                Console.Write("This is not valid input. Please pick between 1 - 13: ");
                input = Console.ReadLine();
            }

            Console.Write("\nEnter the digit for the Destination: ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out destination) || destination <= 0 || destination > 13 || origin == destination)
            {
                if(origin == destination)
                {
                    Console.Write("Origin and destination cannot be the same. Pick new destination: ");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.Write("This is not valid input. Please pick between 1 - 13: ");
                    input = Console.ReadLine();
                }
            }

            Console.Clear();

            Console.WriteLine("Single Trip Fare Details");
            Console.WriteLine("Starting Station: " + stationPicker[origin]);
            Console.WriteLine("End Station: " + stationPicker[destination]);

            Chain antipoloChain = new Antipolo();
            Chain marikinaChain = new Marikina();
            Chain santolanChain = new Santolan();
            Chain katipunanChain = new Katipunan();
            Chain anonasChain = new Anonas();
            Chain cubaoChain = new Cubao();
            Chain bettyGoChain = new BettyGo();
            Chain gilmoreChain = new Gilmore();
            Chain jRuizChain = new JRuiz();
            Chain vMapaChain = new VMapa();
            Chain purezaChain = new Pureza();
            Chain legardaChain = new Legarda();
            Chain rectoChain = new Recto();

            antipoloChain.setNextChain(marikinaChain);
            marikinaChain.setNextChain(santolanChain);
            santolanChain.setNextChain(katipunanChain);
            katipunanChain.setNextChain(anonasChain);
            anonasChain.setNextChain(cubaoChain);
            cubaoChain.setNextChain(bettyGoChain);
            bettyGoChain.setNextChain(gilmoreChain);
            gilmoreChain.setNextChain(jRuizChain);
            jRuizChain.setNextChain(vMapaChain);
            vMapaChain.setNextChain(purezaChain);
            purezaChain.setNextChain(legardaChain);
            legardaChain.setNextChain(rectoChain);

            Itenerary journey = new Itenerary(stationPicker[origin], stationPicker[destination]);

            int fare = antipoloChain.calculateFare(journey);

            Console.WriteLine("Fare: " + fare);
            Console.Write("\nEnter Cash Amount: ");
            input = Console.ReadLine();

            double cashAmount;
            while (!double.TryParse(input, out cashAmount) || cashAmount < fare)
            {
                Console.Write("Amount not valid. Enter a sufficient amount: ");
                input = Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("\n\t++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("\t       LRT 2 - Purple Line          ");
            Console.WriteLine("\t         Official Receipt           ");
            Console.WriteLine("\t       " + DateTime.Now + "      \n" );
            Console.WriteLine("\t------------------------------------\n");
            Console.WriteLine("\tItinerary: " + stationPicker[origin] + " to " + stationPicker[destination]);
            Console.WriteLine("\tFare: " + fare);
            Console.WriteLine("\tCash Amount: " + cashAmount);
            Console.WriteLine("\tChange: " + (cashAmount-fare) + "\n");
            Console.WriteLine("\t------------------------------------\n");
            Console.WriteLine("\tThank you for riding in LRT Line 2!");
            Console.WriteLine("\tPlease Proceed to the Train Platform\n");
            Console.WriteLine("\t------------------------------------");

            break;

        case 2:
            Console.WriteLine("\n====================================================");
            Console.WriteLine("Welcome Admin");
            Console.WriteLine("Choose a transaction.\n");
            Console.WriteLine("[1] => Add New Station");
            Console.WriteLine("[2] => Build New Train\n");

            choice = 0;
            Console.Write("Pick between 1 and 2: ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out choice) || choice <= 0 || choice > 2)
            {
                Console.Write("This is not valid input. Please pick between 1 and 2: ");
                input = Console.ReadLine();
            }

            int railwayChoice = 0;

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    
                    railwayChoice = railwayPicker();
                    Console.Write("\nEnter the name of the new station: ");
                    input = Console.ReadLine();

                    Station newStation = new StationFactory().makeNewStation(railwayChoice, input);
                    Console.Clear();
                    Console.WriteLine("======================================");
                    Console.WriteLine("Station Successfully Created");
                    Console.WriteLine("Station Name: " + newStation.getStationName());
                    Console.WriteLine("Railway Type: " + newStation.getRailwayType());
                    Console.WriteLine("Date Created: " + newStation.getDateOfCreation());
                    newStation.displayStationSchedule();

                    break;

                case 2:
                    Console.Clear();
                    railwayChoice= railwayPicker();

                    int engineID=0, numTrainCoach=0;
                    Boolean airconChecker = false, adChecker = false;
                    
                    Console.Write("\nEnter the Engine ID of the new train: ");
                    input = Console.ReadLine();

                    while (!int.TryParse(input, out engineID))
                    {
                        Console.Write("This is not valid input. Enter numerical digits only: ");
                        input = Console.ReadLine();
                    }

                    Console.Write("\nHow many train coaches will be included? : ");
                    input = Console.ReadLine();

                    while (!int.TryParse(input, out numTrainCoach))
                    {
                        Console.Write("This is not valid input. Enter numerical digits only: ");
                        input = Console.ReadLine();
                    }

                    Console.Write("\nDoes the new train have air-conditoners? Y/N : ");
                    input = Console.ReadLine();

                    while (!input.ToLower().Contains("y") || !input.ToLower().Contains("n"))
                    {
                        if(input.ToLower().Contains("y")) { airconChecker = true; break; }
                        else if (input.ToLower().Contains("n")) { airconChecker = false; break; }
                        else
                        {
                            Console.Write("This is not valid input. Type 'Y' for Yes and 'N' for No: ");
                            input = Console.ReadLine();
                        }
                        
                    }

                    Console.Write("\nCan we put product ads on the train exterior? Y/N : ");
                    input = Console.ReadLine();

                    while (!input.ToLower().Contains("y") || !input.ToLower().Contains("n"))
                    {
                        if (input.ToLower().Contains("y")) { adChecker = true; break; }
                        else if (input.ToLower().Contains("n")) { adChecker = false; break; }
                        else
                        {
                            Console.Write("This is not valid input. Type 'Y' for Yes and 'N' for No: ");
                            input = Console.ReadLine();
                        }

                    }

                    Train train = new TrainBuilder(numTrainCoach, engineID, railwayDict[railwayChoice])
                        .setAirconEnabled(airconChecker)
                        .setAdCustomizable(adChecker)
                        .build();

                    Console.Clear();
                    Console.WriteLine("======================================");
                    Console.WriteLine("New Train Successfully Added");
                    Console.WriteLine("Train Engine ID  : " + train.getEngineID());
                    Console.WriteLine("Railway Type     : " + train.getRailwayType());
                    Console.WriteLine("Number of Coach  : " + train.getNumberOfTrainCoach());
                    Console.WriteLine("Aircon Enabled?  : " + train.getAirconType());
                    Console.WriteLine("Customizable Ads : " + train.getAdCustomizable());
                    break;

                default:
                    Console.WriteLine("Invalid Choice. Try Again.");
                    break;
            }

            break;

        default:
            Console.WriteLine("Invalid Choice. Try Again.");
            break;
    }

    // Wait for the user to respond before closing.
    Console.WriteLine("\nPress 'n' and Enter to close the app,");
    Console.Write("or press any other key and Enter to continue: ");
    if (Console.ReadLine() == "n") endApp = true;

    Console.WriteLine("\n"); // Friendly linespacing.
}

int railwayPicker()
{
    Console.WriteLine("=======================================");
    Console.WriteLine("Select the railway for the new train:");

    foreach (KeyValuePair<int, string> railway in railwayDict)
    {
        Console.WriteLine("[{0}] => {1}", railway.Key, railway.Value);
    }

    int choice = 0;
    Console.Write("\nEnter the digit of the selected railway: ");
    var input = Console.ReadLine();

    while (!int.TryParse(input, out choice) || choice <= 0 || choice > 3)
    {
        Console.Write("This is not valid input. Please pick between 1 - 3: ");
        input = Console.ReadLine();
    }
    return choice;
}


