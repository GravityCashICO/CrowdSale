using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gravity.Models
{
    public class Payment
    {
        public string Id  { get; set; }//txn_id
        public string Ipn_id { get; set; }//ipn_id
        public string CurrencyCode { get; set; }
        public string Received_amount { get; set; }//received_amount
        public string Fee { get; set; }//fee
        public string NetValue { get; set; }//net    actual val
        public int Status { get; set; }
        public string AddressToSendCoin { get; set; }//parameter
        public decimal CoinAmount { get; set; }//parameter

        //call transactions  make it successful
    }
}
