using System;
using RouteOOP3.Structs;

namespace RouteOOP3.Classes
{
    public class Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;


        // Destination property
        // public read and write

        public DeliveryAddress Destination { get; set; }


        // TrackingCode
        // read only from outside

        public string TrackingCode
        {
            get { return trackingCode; }
        }


        // Description
        // read and write validation

        public string Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }


        // Weight read and write and greater than 0

        public double Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }


        // DeliveryFee
        // public getter and private setter  greater than 0

        public decimal DeliveryFee
        {
            get { return deliveryFee; }

            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }


        // EstimatedCost
        // calculated property we us virtual to ovrride

        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5);
            }
        }


        // Constructor 1

        public Shipment(string trackingCode)
        {
            this.trackingCode = "Unknown";
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;

            Destination = new DeliveryAddress(
                "Unknown",
                "Unknown",
                1
            );


            // validate tracking code

            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                this.trackingCode = trackingCode;
            }
        }


        // Constructor 2

        public Shipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            this.trackingCode = "Unknown";
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;

            Destination = destination;


            // validate tracking code

            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                this.trackingCode = trackingCode;
            }


            // validate description

            if (!string.IsNullOrWhiteSpace(description))
            {
                this.description = description;
            }


            // validate weight

            if (weight > 0)
            {
                this.weight = weight;
            }


            // validate delivery fee

            if (deliveryFee > 0)
            {
                this.deliveryFee = deliveryFee;
            }
        }




        //    *******************************************
        //         Update weight method overloading 

        //    *******************************************


        // version  update weight directly

        public void UpdateWeight(double newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }
        // version 2  update weight after adding extra packing weight

        public void UpdateWeight(double newWeight, double packingWeight)
        {
            double totalWeight = newWeight + packingWeight;

            if (totalWeight > 0)
            {
                Weight = totalWeight;
            }
        }


        // Update Delivery Fee

        public void UpdateDeliveryFee(decimal newDeliveryFee)
        {
            if (newDeliveryFee > 0)
            {
                deliveryFee = newDeliveryFee;
            }
        }





        // Print Shipment virtual method to ovrride 

        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Weight : {Weight} KG");
            Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
            Console.WriteLine(
                $"Estimated Cost : {EstimatedCost} EGP"
            );
        }

    }
}