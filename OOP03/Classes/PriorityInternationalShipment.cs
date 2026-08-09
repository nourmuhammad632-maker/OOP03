using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03.Classes
{
    internal class PriorityInternationalShipment:InternationalShipment
    {
     public  PriorityInternationalShipment(string trackingCode
         , string description,
         decimal weight, decimal deliveryFee
         , DeliveryAddress destination, string? destinationcountry, decimal customsfee) :base(trackingCode, description, weight, deliveryFee, destination,destinationcountry,customsfee)
        {

        }
        public sealed override void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
            Console.WriteLine("Priority");

        }
    }
}
