using System;
using RouteOOP3.Structs;

namespace RouteOOP3.Classes
{
    public class PriorityInternationalShipment
        : InternationalShipment
    {

        public PriorityInternationalShipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination,
                destinationCountry,
                customsFee)
        {
        }


        // Override GenerateCustomsRepor   sealed which  cannot override it again

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine(
                "Priority Customs Report"
            );

            base.GenerateCustomsReport();
        }


        // Override PrintShipment

        public override void PrintShipment()
        {
            Console.WriteLine(
                "Priority International Shipment"
            );

            base.PrintShipment();
        }
    }
}