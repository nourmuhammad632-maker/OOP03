 using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03.Classes
{
    internal class InternationalShipment : Shipment
    {
        #region Attributes
        private string? destinationcountry;
        private decimal customsfee;

        #endregion



        #region propety
        public string? DestinationCountry
        {
            get { return destinationcountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationcountry = value;
                }
            }
        }
        public decimal Customsfee
        {
            get
            {
                return customsfee;
            }
            set
            {
                if (value >= 0)
                {
                    customsfee = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + Customsfee; }
        }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string? destinationcountry, decimal customsfee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationcountry;
            Customsfee = customsfee;
        }
    
   

        #endregion
    #region method
   public override void PrintShipment()
        {
            Console.WriteLine("\nInternational Shipment\n");
            base.PrintShipment();
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {Customsfee} EGP");
        }
        public virtual void GenerateCustomsReport()
        {
       


            Console.WriteLine($"Report : {DestinationCountry}");    

        }

        #endregion

    } }