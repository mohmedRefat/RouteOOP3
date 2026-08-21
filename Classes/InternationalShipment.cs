using System;
using RouteOOP3.Structs;

namespace RouteOOP3.Classes
{
    public class InternationalShipment : Shipment
    {

        private string destinationCountry;
        private decimal customsFee;



        public string DestinationCountry
        {
            get { return destinationCountry; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }


        // Customs Fee

        public decimal CustomsFee
        {
            get { return customsFee; }

            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }


        // Constructor

        public InternationalShipment(
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
                destination)
        {
            if (!string.IsNullOrWhiteSpace(destinationCountry))
            {
                DestinationCountry = destinationCountry;
            }
            else
            {
                DestinationCountry = "Unknown";
            }


            if (customsFee >= 0)
            {
                CustomsFee = customsFee;
            }
        }


        // Override EstimatedCost

        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + CustomsFee;
            }
        }


        // Virtual method  will be sealed  in priotyshipment

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine(
                $"Customs Report : {DestinationCountry}"
            );

            Console.WriteLine(
                $"Customs Fee : {CustomsFee} EGP"
            );
        }


        // Override PrintShipment

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");

            base.PrintShipment();

            Console.WriteLine(
                $"Destination Country : {DestinationCountry}"
            );

            Console.WriteLine(
                $"Customs Fee : {CustomsFee} EGP"
            );
        }
    }
}