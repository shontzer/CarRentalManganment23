namespace CarRentalManganment23.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string MakesEndpoint = $"{Prefix}/makes";
        public static readonly string ModelEndpoint = $"{Prefix}/models";
        public static readonly string ColourEndpoint = $"{Prefix}/colour";
        public static readonly string vehiclesEndpoint = $"{Prefix}/vehicles";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
    }
}
