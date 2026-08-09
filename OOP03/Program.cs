using OOP03.Classes;

namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            ////Part 01 — Theoretical Questions
            //// a) What is the difference between Method Overloading and Method Overriding?
            ////overloading :is the same method with the same logic diferrence is type and order and count of parameter 
            ////overriding :redefining an inherited method in the child class with a new implementation

            ////==============================================
            ////b) What is the difference between Static Binding and Dynamic Binding?
            ////static binding:"compile time polymorhism "is in method overloading
            ////dynamic binding :"run time polymorphism "method overriding

            ////====================================================
            ////Q2 Sealed Classes and Methods
            ////a) What is the purpose of the sealed keyword when applied to a class?
            ////prevent ihertance

            ////=================================================

            ////b) What is the difference between a sealed class and a sealed method?
            ////sealed class prevent ihertance from it
            ////selaed method prevent override about it

            ////========================================

            ////c) Can a sealed method be overridden? Why?
            ////no,sealed class prevented the overriden

            #endregion

            #region Question2
            //Driver driver = new Driver()
            //{
            //    DriverId = 2,
            //    FullName="Nour",
            //    PhoneNumber=123456
            //};
            //DeliveryCenter deliveryCenter = new DeliveryCenter("Zagazig");
            //deliveryCenter.Driver=driver;
            //Console.WriteLine("=====================================");
            //Console.WriteLine("Delivery Center");
            //Console.WriteLine("=====================================\n");
            //Console.WriteLine($"Driver : {driver.FullName}");
            //Console.WriteLine("\n-----------------------------------\n");
            




            


            //StandardShipment standardShipment=new StandardShipment("SH001","Laptop",3,80,new DeliveryAddress("Zagazig","tolba ouida",19));
            ////standardShipment.PrintShipment();
           
            //ExpressShipment expressShipment = new ExpressShipment("Nn01", "Mobile Phone", 2, 100, new DeliveryAddress("Cairo", "Nasr city", 10),30);
            ////expressShipment.PrintShipment();
            //InternationalShipment internationalShipment = new InternationalShipment("SH003", "Television", 8, 120, new DeliveryAddress("munich", "kaufingerstrabe", 11), "Germany", 100);
            //deliveryCenter.AddShipment(standardShipment);
            //deliveryCenter.AddShipment(expressShipment);
            //deliveryCenter.AddShipment(internationalShipment);
            //deliveryCenter.PrintAllShipments();
            //Console.WriteLine("\n=====================================\n");

            //Console.WriteLine("Printing Using DeliveryHelper...\n");
            //DeliveryHelper.PrintShipmentDetails(standardShipment);
            //DeliveryHelper.PrintShipmentDetails(expressShipment);
            //DeliveryHelper.PrintShipmentDetails(internationalShipment);
            //Console.WriteLine("\n=====================================\n");
            //Console.WriteLine("\nUpdating Weight...");

            //Console.WriteLine($"\nOriginal Weight : {standardShipment.Weight} KG");

            //standardShipment.UpdateWeight(5);

            //Console.WriteLine($"\nUpdated Weight : {standardShipment.Weight} KG");

            //standardShipment.UpdateWeight(5, 0.5m);

            //Console.WriteLine($"\nUpdated Weight After Packing : {standardShipment.Weight} KG");

            //// k. Shipment[] mixed types
            //Console.WriteLine("\n==========================================\n");
            //Console.WriteLine("\nPrinting Using Shipment[]...\n");



            //Shipment[] shipments =
            //{
            //    standardShipment,
            //    expressShipment,
            //    internationalShipment


            //};
            //foreach (Shipment s in shipments)
            //{
            //    s.PrintShipment();
            //    Console.WriteLine("------------------------------");
            //}
            ////sealed class
            //CompletedShipment completedShipment = new CompletedShipment( "SH04", "PC", 4, 222, new DeliveryAddress("alex", "meami", 3));
            ////sealed method
            //internationalShipment.GenerateCustomsReport();

            #endregion






        }
    }
}
