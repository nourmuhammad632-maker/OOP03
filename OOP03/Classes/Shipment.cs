
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03.Classes
{
    internal class Shipment
    {
        #region Attributes

        private string? trackingcode;
        private string? description;
        private decimal weight;
        private decimal deliveryfree;
        private DeliveryAddress destination;



        #endregion

        #region Properties
        //property only read for tracking

        public string? TrackingCode
        {
            get { return trackingcode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingcode = value;
            }
        }
        //read/write property with validation
        public string? Description
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
        //read/write property with validation.
        public decimal Weight
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
        //public getter and private setter.
        public decimal Deliveryfree
        {
            get { return deliveryfree; }
            private set
            {
                if (value > 0)
                {
                    deliveryfree = value;
                }
            }
        }
        //public read/write property
        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }



        public virtual decimal EstimatedCost
        {
            get
            {
                return deliveryfree + weight * 5;
            }
        }



        #endregion
        #region Constructors




        //The first constructor receives only trackingCode.
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            Deliveryfree = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        //The second constructor receives trackingCode, description, weight, deliveryFee, and destination.
        //Each constructor must initialize the object with valid data.
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryfree, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            Deliveryfree = deliveryfree;
            Destination = destination;
        }
        #endregion
        #region Methods
        public void UpdateDeliveryFree(decimal newFee)
        {
            if (newFee > 0)
                Deliveryfree = newFee;
        }
        public  virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {Deliveryfree} EGP");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        public void UpdateWeight(decimal weight)
        {
            if( weight > 0)
            {
                Weight = weight;
        
            }

        }
        public void UpdateWeight(decimal weight,decimal packingweight)
        {
            if (weight > 0 && packingweight >= 0)
            {
                Weight = weight + packingweight;
            }
            }


        #endregion

    }


}



