using System;
using RouteOOP3.Structs;

namespace RouteOOP3.Classes
{   
    //* inherits from shipment sealed which means can not be ovrride it
    public sealed class CompletedShipment : Shipment
    {

        public CompletedShipment(
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


        // Override PrintShipment

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment");

            base.PrintShipment();
        }
    }
}