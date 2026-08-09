
﻿using System;
using System.Collections.Generic;
using System.Text;


namespace OOP03.Classes
{
    internal class ExpressShipment : Shipment
    {

        #region Attribute
        private decimal extrafee;
        #endregion
        #region Property
        public decimal ExtraFee
        {
            get
            {
                return extrafee;

            }
            set
            {
                if (value >= 0)
                {
                    extrafee = value;
                }
            }

        }
        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + ExtraFee; }
        }

        #endregion

        #region constructors
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extrafeee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extrafeee;
        }
        #endregion
        #region methods
        public override void PrintShipment()
        {
            
          
            Console.WriteLine("Express Shipment\n");
            base.PrintShipment();
            Console.WriteLine($"Extra fee:{ExtraFee}");


        }
        #endregion
    }
}