using System;
using RouteOOP3.Structs;

namespace RouteOOP3.Classes
{
    public class StandardShipment : Shipment
    {
            //* no need to override estimated costed cuz we will use it as it exist in parent
        public StandardShipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
        }


        // Override PrintShipment every child class will override it

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");

            base.PrintShipment();
        }
    }
}