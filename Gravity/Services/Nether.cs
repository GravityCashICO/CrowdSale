using Gravity.Models;
using Nethereum.StandardTokenEIP20.ContractDefinition;
using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Gravity.Services
{
	public static class Nether
	{
		public static Web3 web3 = new Web3(Admin.InfuraUrl);
		public static Nethereum.Contracts.ContractHandlers.ContractHandler handler = web3.Eth.GetContractHandler(Admin.ContractAddress);
		public static async Task<decimal> GetBalance(string pubKey)
		{
			var balanceMessage = new BalanceOfFunction() { Owner = pubKey };
			var balance = await handler.QueryAsync<BalanceOfFunction, BigInteger>(balanceMessage);
			var value = Web3.Convert.FromWeiToBigDecimal(balance);

			var total = Convert.ToDecimal(value.ToString());

			return total;
		}
		}
}
