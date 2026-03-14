namespace SecondApp
{
    public class Ticket
    {
        private static int ticketCounter = 0;
        public static int GetTotalTicketsSold() => ticketCounter;

        private int _ticketId;
        private string _movieName;
        private TicketType _type;
        private SeatLocation _seat;
        private double _price;

        public int TicketId => _ticketId; //read-only
        public string MovieName
        {
            get => _movieName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _movieName = value;
            }
        }
        public TicketType Type
        {
            get => _type;
            set => _type = value;
        }

        public SeatLocation Seat
        {
            get => _seat;
            set => _seat = value;
        }

        public double Price
        {
            get => _price;
            set { if (value > 0) _price = value; }
        }
        //returns the price with 14% tax included(calculated, not stored).
        public double PriceAfterTax => _price * 1.14;

        public Ticket(string movieName, TicketType type,
                 SeatLocation seat, double price)
        {
            ticketCounter++;            // increment shared counter
            _ticketId = ticketCounter; // assign unique ID

            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public void PrintTicket()
        {
            Console.WriteLine($"  ID         : {TicketId}");
            Console.WriteLine($"  Movie      : {MovieName}");
            Console.WriteLine($"  Type       : {Type}");
            Console.WriteLine($"  Seat       : {Seat}");
            Console.WriteLine($"  Price      : {Price:F2} EGP");
            Console.WriteLine($"  Price+Tax  : {PriceAfterTax:F2} EGP");
        }
    }
}

