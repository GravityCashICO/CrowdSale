using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gravity.Models
{
	public class Info
	{
		public int Id { get; set; }
		public double CoinPriceUSD { get; set; }
		public string PublicKey { get; set; }
		public string PrivateKey { get; set; }
		public string InfuraUrl { get; set; }

		public double Feis { get; set; }

		public DateTime CreationDate { get; set; } = DateTime.UtcNow;

		public string PublicKeyCP { get; set; }
		public string PrivateKeyCP { get; set; }
	}
}
