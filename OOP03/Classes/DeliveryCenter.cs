using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03.Classes
{
    internal class DeliveryCenter

    {
        #region Attributes

        private Shipment?[] shipments;




        #endregion
        #region property
        public string CenterName { get; set; }
        public Driver Driver { get; set; }
        #endregion
        #region Constructor
        public DeliveryCenter(string centerName)
        {
            shipments = new Shipment?[20];
            CenterName = centerName;


        }



        #endregion
        
        #region indexer

        public Shipment? this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];

                }
                return default;
            }


            set
            {
                if (index >= 0 && index < shipments.Length)
                {

                    shipments[index] = value;
                }


            }
        }

        public Shipment? this[string trackingcode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {

                    if (shipments[i] != null && shipments[i].TrackingCode == trackingcode)
                    {
                        return shipments[i];
                    }
                }
                return default;
            }

        }
        #endregion
        #region methods



        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;

        }
        public bool RemoveShipment(string trackingcode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingcode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i]!.PrintShipment();
                    Console.WriteLine("-------------------");
                }
            }
        }


        #endregion




    }
}
