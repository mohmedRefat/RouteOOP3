

using RouteOOP3.Classes;
using RouteOOP3.Structs;

/*Part 1
Q1 


                            A
Method overloading : Define multiple method with the same name but different parameters (different type,different number ,order) does not require inheritance  Static Poly
Method Overrding : Redifne  in child class is already defined in parent class , must be the same parmeters require inheritance  Dynamic poly                                    

                            B
Staic binding : it happens at compile time  faster becasue no run time checks driven by method overloading

Dynamic binding : it happens at run time based on object that are created in memory  driven by method ovrride

   Part 2

                                       A 
puropose of sealed class : prevent other classes from inheriting from it stop using it as parent class 
Also protect code from being manipulated  and secure our code

                                    B

Sealed class : apply to eniter class  , blocks inheritance of the entire class ,the class can not have any child classes
Sealed Method : Specific method inside a child class , block ovrride of that method , child class can still inherit but they can not override that method

                                c
by making method as sealed  tells  compiler to lock the implemetion of the code  any try to ovrride that method  it will make compile time error



*/



class Program
{
    static void Main(string[] args)
    {
        // Create Driver

        Driver driver = new Driver(
            "D001",
            "Mohamed Refat",
            "01000000000"
        );


        // Create Delivery Center

        DeliveryCenter deliveryCenter =
            new DeliveryCenter();



        deliveryCenter.Driver = driver;


        // Create Standard Shipment

        DeliveryAddress standardAddress =
            new DeliveryAddress(
                "Street One",
                "Damitte",
                10
            );


        StandardShipment standardShipment =
            new StandardShipment(
                "SH001",
                "Laptop",
                3,
                80,
                standardAddress
            );


        // Create Express Shipment

        DeliveryAddress expressAddress =
            new DeliveryAddress(
                "Street Two",
                "Cairo",
                20
            );


        ExpressShipment expressShipment =
            new ExpressShipment(
                "SH002",
                "Mobile Phone",
                2,
                60,
                expressAddress,
                30
            );


        // Create International Shipment

        DeliveryAddress internationalAddress =
            new DeliveryAddress(
                "Street Three",
                "Cairo",
                30
            );


        InternationalShipment internationalShipment =
            new InternationalShipment(
                "SH003",
                "Television",
                8,
                120,
                internationalAddress,
                "Germany",
                100
            );


        // Add Shipments

        deliveryCenter.AddShipment(
            standardShipment
        );

        deliveryCenter.AddShipment(
            expressShipment
        );

        deliveryCenter.AddShipment(
            internationalShipment
        );


        // Print Delivery Center

        Console.WriteLine(
            "**********************************************="
        );

        Console.WriteLine(
            "Delivery Center"
        );

        Console.WriteLine(
            "**********************************************="
        );

        Console.WriteLine(
            $"Driver : {deliveryCenter.Driver.FullName}"
        );

        Console.WriteLine(
            "------------------------------------------"
        );


        // Print All Shipments
        // Dynamic Binding

        deliveryCenter.PrintAllShipments();


        // Delivery Helper

        Console.WriteLine(
            "**********************************************="
        );

        Console.WriteLine(
            "Printing Using DeliveryHelper..."
        );

        Console.WriteLine(
            "**********************************************="
        );


        DeliveryHelper.PrintShipmentDetails(
            standardShipment
        );

        Console.WriteLine(
            "Standard Shipment Printed Successfully."
        );


        DeliveryHelper.PrintShipmentDetails(
            expressShipment
        );

        Console.WriteLine(
            "Express Shipment Printed Successfully."
        );


        DeliveryHelper.PrintShipmentDetails(
            internationalShipment
        );

        Console.WriteLine(
            "International Shipment Printed Successfully."
        );


        // Method Overloading
        // Update Weight

        Console.WriteLine(
            "**********************************************="
        );

        Console.WriteLine(
            "Updating Weight..."
        );

        Console.WriteLine(
            $"Original Weight : {standardShipment.Weight} KG"
        );


        // First version

        standardShipment.UpdateWeight(5);

        Console.WriteLine(
            $"Updated Weight : {standardShipment.Weight} KG"
        );


        // Second version
        // Weight + Packing Weight

        standardShipment.UpdateWeight(5, 0.5);

        Console.WriteLine(
            $"Updated Weight After Packing : " +
            $"{standardShipment.Weight} KG"
        );


        // Shipment arr mix types

        Console.WriteLine(
            "**********************************************="
        );

        Console.WriteLine(
            "Printing Using Shipment[]..."
        );

        Console.WriteLine(
            "**********************************************="
        );


        Shipment[] shipments =
        {
            standardShipment,
            expressShipment,
            internationalShipment
        };


        // Dynamic binding

        for (int i = 0;
             i < shipments.Length;
             i++)
        {
            shipments[i].PrintShipment();

            Console.WriteLine(
                "------------------------------------------"
            );
        }


        // Sealed Class

        CompletedShipment completedShipment =
            new CompletedShipment(
                "SH004",
                "Computer",
                4,
                100,
                standardAddress
            );


        completedShipment.PrintShipment();


        /*
        CompletedShipment is a sealed class.
     So we cannot create another class that can inherits ffrom completed class it will gives compile err
        
        */


        // Sealed Method

        PriorityInternationalShipment priorityShipment =
            new PriorityInternationalShipment(
                "SH005",
                "Camera",
                5,
                150,
                internationalAddress,
                "France",
                120
            );


        priorityShipment.GenerateCustomsReport();

        /*
        GenerateCustomsReport is declared as virtual in InternationalShipment, and override in PriorityInternationalShipment as a sealed override.

        which means the class itself can still be inherited by another classes ,
         but this method  can not be overridden by any child class and it will give compile error 

        */


        Console.WriteLine(
            "**********************************************="
        );
    }
}
