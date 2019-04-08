using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gravity.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string FromKey { get; set; }
        public string ToKey { get; set; }
        public decimal CoinAmount { get; set; }
        public string Status { get; set; }//pending success,failed
        public DateTime CreationDate { get; set; }
        public string StatusType { get; set; }//receive,send,(buy=cant fail)
        public string HashHex { get; set; }//btes32
        public string Signature { get; set; }//bytes
        public decimal FeeInCoinAmount { get; set; }
    }
}
