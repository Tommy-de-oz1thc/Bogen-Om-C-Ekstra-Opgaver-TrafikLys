using System;

namespace cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a TrafficLight object
            TrafficLight trafficLight = new TrafficLight();
            int max_run = 10;
            Console.WriteLine($"The loop will run for {max_run} times");
            // Run state changes 10 times when creating the object
            for (int ac = 0; ac < max_run; ac++)
            {
                trafficLight.ChangeState(); // Call the ChangeState method on the created object

                // Clear the console screen
                Console.Clear();

                // Print the state using the GetState method
                //Console.WriteLine(trafficLight.GetState());

                // Display the traffic light image based on the state
                switch (trafficLight.GetState())
                {
                    case "Red":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(@"
                         ____
                        /    \
                       / Stop \
                      /________\
                      |        |
                      |  Red   |
                      |        |
                      \________/
");
                        break;
                    case "RedYellow":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
                         ____
                        /    \
                       / Stop \
                      /________\
                      |        |
                      |  Red   |
                      | Yellow |
                      \________/
                          
");
                        break;
                    case "Green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@"
                         ____
                        /    \
                       /  Go  \
                      /________\
                      |        |
                      |  Green |
                      |        |
                      \________/
");
                        break;
                    case "Yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"
                         ____
                        /    \
                       / Stop \
                      /________\
                      |        |
                      | Yellow |
                      |        |
                      \________/
");
                        break;
                    default:
                        Console.WriteLine("Invalid state!");
                        break;
                }

                // Wait for a moment before the next iteration
                System.Threading.Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
