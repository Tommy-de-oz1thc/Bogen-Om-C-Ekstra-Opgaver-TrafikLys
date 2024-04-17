using System;
using System.Collections.Generic;
using System.Threading;

namespace cs
{
    public class TrafficLight
    {
        // Opret en liste over tilstande for trafiklyset
        List<string> trafficStates = new List<string> { "Red", "RedYellow", "Green", "Yellow" };
        private string state = "";
        private int trafficnum = 0;

        // Default constructor
        public TrafficLight()
        {
            // Her kan du evt. initialisere trafiklyset til en bestemt starttilstand
            state = trafficStates[trafficnum];


        }

        public void ChangeState()
        {
            // Kontroller, om trafiknum er større end længden af trafiklysets tilstande minus 1
            if (trafficnum >= trafficStates.Count - 1)
            {
                // Hvis trafiknum er uden for gyldige indeks, så nulstil det
                trafficnum = 0;
            }
            else
            {
                // Ellers, øg trafiknum for at skifte til næste tilstand
                trafficnum++;
            }

            // Skift tilstanden baseret på trafiknum
            switch (trafficnum)
            {
                case 0:
                    // Skift tilstand fra Yellow til Red
                    Thread.Sleep(2000); // Venter i 2 sekunder
                    break;
                case 1:
                    // Skift tilstand fra Red til RedYellow
                    Thread.Sleep(5000); // Venter i 5 sekunder
                    break;
                case 2:
                    // Skift tilstand fra RedYellow til Green
                    Thread.Sleep(2000); // Venter i 2 sekunder
                    break;
                case 3:
                    // Skift tilstand fra Green til Yellow
                    Thread.Sleep(5000); // Venter i 5 sekunder
                    break;
            }

            // Opdater tilstand
            state = trafficStates[trafficnum];
        }

        public string GetState()
        {
            return state;
        }
    }
}
