using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gravity.Models
{
    public class MineTransaction
    {
        public Guid Id { get; set; }
        public decimal GasFee { get; set; }
        public decimal TotalFee { get; set; }
        public decimal totalCoinFee { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastTransactinTime { get; set; }//where   transactins.datetime<=lastTransactinTime
        public string txHash { get; set; }
    }
}
