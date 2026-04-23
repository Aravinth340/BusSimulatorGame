using System;
using System.Collections.Generic;

namespace BusSimulator
{
    public class PassengerSystem
    {
        private int totalPassengers;
        private double totalRevenue;
        private bool isDoorOpen;

        public PassengerSystem()
        {
            totalPassengers = 0;
            totalRevenue = 0.0;
            isDoorOpen = false;
        }

        public void BoardPassenger(double fare)
        {
            if (isDoorOpen)
            {
                totalPassengers++;
                totalRevenue += fare;
                Console.WriteLine("Passenger boarded. Total passengers: " + totalPassengers);
            }
            else
            {
                Console.WriteLine("Cannot board - the door is closed.");
            }
        }

        public void OpenDoor()
        {
            isDoorOpen = true;
            Console.WriteLine("Door opened.");
        }

        public void CloseDoor()
        {
            isDoorOpen = false;
            Console.WriteLine("Door closed.");
        }

        public double GetTotalRevenue()
        {
            return totalRevenue;
        }

        public int GetTotalPassengers()
        {
            return totalPassengers;
        }
    }
}