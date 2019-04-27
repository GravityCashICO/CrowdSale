using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gravity.Models
{
    public class Package
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public int PriceInUSD { get; set; }
        public int ExtraCoinPercentage { get; set; }
		//public decimal TotalCoin { get; set; }
		public DateTime? CreationDate { get; set; }
		//public double CoinPriceInUSD { get; set; }//1gch/1usd

	}
}
