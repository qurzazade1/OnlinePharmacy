using OnlinePharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.WebShopUtility
{
    public static class SD
    {
        public const string DefaultMedicineImage = ".png";

        public const string ManagerUser = "Manager";
        public const string PharmacistUser = "Pharmacist";
        public const string PostmanUser = "Postman";
        public const string CustomerEndUser = "Customer";
        public const string ssCustomerShoppingCartCount = "ssCartCount";
        
        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusRejected = "Rejected";
        public const string ssDiscountCodeString = "ssDiscountCodeString";

        public const string StatusReady = "Ready for Pickup";
        public const string StatusCompleted = "Completed";
        public const string StatusCancelled = "Cancelled";


        public const string StatusSubmitted = "Submitted";
        public const string StatusInProcess = "Being Prepared";
        
        





        public static string ConvertToRawHtml(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }
        public static double DiscountedPrice(DiscountCode discountCodeFromDb, double OriginalOrderTotal)
        {
            if (discountCodeFromDb == null)
            {
                return OriginalOrderTotal;
            }
            else
            {
                if (discountCodeFromDb.MinimumAmount < OriginalOrderTotal)
                {

                    if (Convert.ToInt32(discountCodeFromDb.DiscountCodeType) == (int)DiscountCode.EDiscountCodeType.Percent)
                    {
                        return Math.Round(OriginalOrderTotal - (OriginalOrderTotal * discountCodeFromDb.DiscountAmount / 100), 2);
                    }



                    if (Convert.ToInt32(discountCodeFromDb.DiscountCodeType) == (int)DiscountCode.EDiscountCodeType.Dollar)
                    {

                        return Math.Round(OriginalOrderTotal - discountCodeFromDb.DiscountAmount, 2);
                    }
                  
                   
                }
                else
                {
                    return OriginalOrderTotal;
                }







            }
            return OriginalOrderTotal;
        }







    }
}
