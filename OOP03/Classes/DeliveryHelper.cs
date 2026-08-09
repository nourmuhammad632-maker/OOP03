using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03.Classes
{
    internal class DeliveryHelper
    {
       public static void PrintShipmentDetails(Shipment shipment)
        {
            shipment.PrintShipment();
            if (shipment is StandardShipment)
                Console.WriteLine("Standard Shipment Printed Successfully.");

            else if (shipment is ExpressShipment)
                Console.WriteLine("Express Shipment Printed Successfully.");

            else if (shipment is InternationalShipment)
                Console.WriteLine("International Shipment Printed Successfully.");

        }
    }
}
