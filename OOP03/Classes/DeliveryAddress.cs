using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03.Classes
{
    internal class DeliveryAddress
    {
        #region Attributes
        public string? city;
        public string? street;
        public int buildingnumber;
#endregion
        #region Constructors
        public DeliveryAddress(string? City, string? Street, int Buildingnumber)
        {
            city = City;
            street = Street;
            buildingnumber = Buildingnumber;
        }
        #endregion
        #region methods
        public string GetFullAddress()
        {
            return $"City:{city}, Street:{street}, Building:{buildingnumber}";
        }
        public override string ToString()
        {
            return GetFullAddress();
        }
        #endregion


    }
}

