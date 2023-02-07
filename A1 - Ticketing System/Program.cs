namespace A1___Ticketing_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assuming the file name is the same as example.
            string fileName = "tickets.csv";
            string userInput;

            //We can use a Do-while here asking for input.
            do
            {
                Console.WriteLine("Please choose an option.");
                Console.WriteLine("1 - Read data from file.");
                Console.WriteLine("2 - Create file from data.");
                Console.WriteLine("Input anything else to exit the program.");
                
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    //Reference the class code for this. 
                    //Logic to read.
                    //Still a little fuzzy, re-watch recording later.
                    // 1:17:00 For this in recording.
                    StreamReader sr = new StreamReader(fileName);

                    sr.ReadLine();
                    //Above means read header. then discard.
                    while(!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        string[] arr = line.Split('|');
                        
                        Console.WriteLine($"{arr[0]}");
                    }
                  
                    sr.Close(); //CLOSE THIS

                }
                else if (userInput == "2")
                {
                    //Logic to write here
                    StreamWriter sw = new StreamWriter(fileName, true);

                    Console.WriteLine("Create new ticket? (Y/n)");
                    string response = Console.ReadLine().ToUpper();
                    if (response != "Y") { break; }

                    //TicketID
                    Console.WriteLine("Enter Ticket ID Number: ");
                    string ID = Console.ReadLine();

                    //Ticket Summary
                    Console.WriteLine("Please enter summary of the ticket: ");
                    string Summary = Console.ReadLine();

                    //Ticket Status
                    Console.WriteLine("What is the ticket status?: ");
                    string Status = Console.ReadLine();

                    //Ticket Priority
                    Console.WriteLine("What priority is the ticket?: ");
                    string Priority = Console.ReadLine();

                    //Ticket Submitter
                    Console.WriteLine("Who is submitting this ticket?: ");
                    string Submitter = Console.ReadLine();

                    //Ticket Assigned
                    Console.WriteLine("Who is assigned to this ticket?: ");
                    string Assigned = Console.ReadLine();

                    //Ticket Watchers
                    Console.WriteLine("Who is watching this ticket?: ");
                    string Watchers = Console.ReadLine();

                    //Ask if they want more watchers.
                    Console.WriteLine("Add a new watcher? (Y/n)");
                    string newWatch = Console.ReadLine().ToUpper();
                    while (newWatch == "Y")
                    {

                        //+++++ TODO +++++
                        //Need to figure out a way to make a list of watchers
                        //And output that list as well...
                        Console.WriteLine("Enter new watcher: ");
                        Watchers = Console.ReadLine();

                        Console.WriteLine("Add another? (Y/n)");
                        newWatch = Console.ReadLine().ToUpper();
                    }

                    
                    sw.WriteLine($"{ID}, {Summary}, {Status}, {Priority}, {Submitter}, {Assigned}, {Watchers}");



                    sw.Close(); //CLOSE THIS TOO
                }

            } while (userInput == "1" || userInput == "2");
            //Personal reminder || = OR
           
        }
    }
}