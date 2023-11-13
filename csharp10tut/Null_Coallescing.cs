public class Program1
{
    static void main()
    {
        int AvailableTIckets;

        int? TicketsOnSale = null;

        // if (TicketsOnSale == null)
        // {
        //     AvailableTIckets = 0;
        // }
        // else
        // {
        //     AvailableTIckets = (int)TicketsOnSale;
        // }

        AvailableTIckets = TicketsOnSale ?? 0;

        System.Console.WriteLine("Available Tickets : {0}", AvailableTIckets);
    }
}
