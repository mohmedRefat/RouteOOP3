using System;
using RouteOOP3.Structs;

namespace RouteOOP3.Classes
{
    public class ExpressShipment : Shipment
    {
        // Extra Fee

        private decimal extraFee;


        // Extra Fee property

        public decimal ExtraFee
        {
            get { return extraFee; }

            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }


        // Constructor

        public ExpressShipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            if (extraFee >= 0)
            {
                ExtraFee = extraFee;
            }
        }


        // Override EstimatedCost

        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + ExtraFee;
            }
        }


        // Override PrintShipment

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");

            base.PrintShipment();

            Console.WriteLine(
                $"Extra Fee : {ExtraFee} EGP"
            );
        }
    }
}