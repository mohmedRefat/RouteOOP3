using System;

namespace RouteOOP3.Classes
{
    public class DeliveryCenter
    {
        private Shipment[] shipmentsArr;


        // Driver can exist independantyl

        public Driver Driver { get; set; }


        // Constructor

        public DeliveryCenter()
        {
            shipmentsArr = new Shipment[10];
        }


        // Integer Indexer

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 &&
                    index < shipmentsArr.Length)
                {
                    return shipmentsArr[index];
                }

                return default;
            }

            set
            {
                if (index >= 0 &&
                    index < shipmentsArr.Length)
                {
                    shipmentsArr[index] = value;
                }
            }
        }


        // String Indexer

        public Shipment this[string trackingCodeParam]
        {
            get
            {
                for (int i = 0;
                     i < shipmentsArr.Length;
                     i++)
                {
                    if (shipmentsArr[i] != null &&
                        shipmentsArr[i].TrackingCode
                        == trackingCodeParam)
                    {
                        return shipmentsArr[i];
                    }
                }

                return default;
            }
        }


        // Add Shipment

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0;
                 i < shipmentsArr.Length;
                 i++)
            {
                if (shipmentsArr[i] == null)
                {
                    shipmentsArr[i] = shipment;

                    return true;
                }
            }

            return false;
        }


        // Remove Shipment

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0;
                 i < shipmentsArr.Length;
                 i++)
            {
                if (shipmentsArr[i] != null &&
                    shipmentsArr[i].TrackingCode
                    == trackingCode)
                {
                    shipmentsArr[i] = null;

                    return true;
                }
            }

            return false;
        }


        // Print All Shipments

        public void PrintAllShipments()
        {
            for (int i = 0;
                 i < shipmentsArr.Length;
                 i++)
            {
                if (shipmentsArr[i] != null)
                {
                    // Dynamic Binding

                    shipmentsArr[i].PrintShipment();

                    Console.WriteLine(
                        "**********************************************"
                    );
                }
            }
        }
    }
}