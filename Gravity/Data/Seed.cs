using Gravity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gravity.Data
{
	public static class Seed
	{
		public static void Initial(ApplicationDbContext _ctx)
		{
			var info = _ctx.Infoes.First();

			Admin.CoinPriceUSD = info.CoinPriceUSD;
			Admin.PublicKey = info.PublicKey;
			Admin.PrivateKey = info.PrivateKey;
			Admin.InfuraUrl = info.InfuraUrl;
			Admin.feis = info.Feis;
			Admin.PublicKeyCP = info.PublicKeyCP;
			Admin.PrivateKeyCP = info.PrivateKeyCP;


		}
	}
}
