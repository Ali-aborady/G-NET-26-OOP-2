namespace SecondApp
{
    public static class BookingHelper
    {
        private static int _refCounter = 0;

        // 5+ tickets -> 10% discount, otherwise full price
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;
            return numberOfTickets >= 5 ? total * 0.90 : total;
        }

        public static string GenerateBookingReference()
        {
            _refCounter++;
            return $"BK-{_refCounter}";
        }
    }
}

