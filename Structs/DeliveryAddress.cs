namespace RouteOOP3.Structs
{
    public struct DeliveryAddress
    {
        public string Street;
        public string City;
        public int BuildingNumber;

        // Constructor

        public DeliveryAddress(
            string street,
            string city,
            int buildingNumber)
        {
            Street = street;
            City = city;
            BuildingNumber = buildingNumber;
        }


        // Get Full Address

        public string GetFullAddress()
        {
            return $"Building {BuildingNumber}, {Street}, {City}";
        }
    }
}