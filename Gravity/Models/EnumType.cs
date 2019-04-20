using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gravity.Models
{
    public class EnumType
    {
        public static string Pending = "Pending";//Transaction.Status
        public static string Success = "Success";//Transaction.Status
        public static string Failed = "Failed";//Transaction.Status

        public static string Processing = "Processing";

        
        public static string Buy = "Buy";//Transaction.StatusType
        public static string Transfer = "Transfer";//Transaction.StatusType
        //public static string Send = "Send";
        //public static string Receive = "Receive";

        
    }
}
