using System;
using System.Collections.Generic;

namespace BusSimulator
{
    public class Passenger
    {
        public string Name { get; set; }
        public string BoardingStop { get; set; }
        public string Destination { get; set; }
        public decimal TicketPrice { get; set; }

        public Passenger(string name, string boardingStop, string destination, decimal ticketPrice)
        {
            Name = name;
            BoardingStop = boardingStop;
            Destination = destination;
            TicketPrice = ticketPrice;
        }

        public override string ToString()
        {
            return $"Passenger: {Name}\nBoarding Stop: {BoardingStop}\nDestination: {Destination}\nTicket Price: {TicketPrice:C}";
        }
    }
}