﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gravity.Models
{
	public class Admin
	{
		public static string etherscan = "https://etherscan.io/";
		public static string txUrl = etherscan + "tx/";//txhashh //https://rinkeby.etherscan.io/tx/0xf905bcc738960a3240921745387fa1a76a889bacbd096be25eaea8f8f9bbac8a
		public static string tokenAddressUrl = etherscan + "token/"+ContractAddress+"?a=";//address //https://rinkeby.etherscan.io/token/0x5e2b81be332eb27a51c30f9fd86a45a060f4e92d?a=0xa6b70392346be7fbfc33d2d098529efc2459b62d
		public static string tokenUrl = etherscan + "token/"+ContractAddress;//https://rinkeby.etherscan.io/token/0x5e2b81be332eb27a51c30f9fd86a45a060f4e92d
		//more/ https://rinkeby.etherscan.io/block/4287809

		//public static string Receiver = "0x45BD27bB68B07FE9541B26955d880b70df34B960";

		public static double CoinPrice = 0.001;//eth
		public static double CoinPriceUSD = 0.15;//eth
		public static string CoinUit = "ETH";

		public static string PublicKey = "";//"0xA6b70392346bE7fBFC33d2d098529efC2459b62D";
		public static string PrivateKey = "";//"F92307ABD3DFC5EEAA00CF856ED34DBD7C84E1BD01A6A7CB5094E69845F2B298";
		public static decimal CoinFee = 0;

		public static string ContractAddress = "0x663F515A41619b8fa4B16dc152484D02A46815A9";//"0x5e2B81be332Eb27A51c30f9FD86a45A060f4E92D";
		public static string abi = @"[{""constant"":false,""inputs"":[{""name"":""newSellPrice"",""type"":""uint256""},{""name"":""newBuyPrice"",""type"":""uint256""}],""name"":""setPrices"",""outputs"":[],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""name"",""outputs"":[{""name"":"""",""type"":""string""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""_spender"",""type"":""address""},{""name"":""_value"",""type"":""uint256""}],""name"":""approve"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""_signature"",""type"":""bytes""},{""name"":""_to"",""type"":""address""},{""name"":""_value"",""type"":""uint256""},{""name"":""_fee"",""type"":""uint256""},{""name"":""_nonce"",""type"":""uint256""}],""name"":""transferPreSigned"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""totalSupply"",""outputs"":[{""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[{""name"":""hash"",""type"":""bytes32""},{""name"":""sig"",""type"":""bytes""}],""name"":""recover"",""outputs"":[{""name"":"""",""type"":""address""}],""payable"":false,""stateMutability"":""pure"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""v"",""type"":""uint8[]""},{""name"":""r"",""type"":""bytes32[]""},{""name"":""s"",""type"":""bytes32[]""},{""name"":""_toes"",""type"":""address[]""},{""name"":""_values"",""type"":""uint256[]""},{""name"":""_fees"",""type"":""uint256[]""}],""name"":""transferArray"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""_from"",""type"":""address""},{""name"":""_to"",""type"":""address""},{""name"":""_value"",""type"":""uint256""}],""name"":""transferFrom"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[{""name"":""_owner"",""type"":""address""}],""name"":""getNonce"",""outputs"":[{""name"":""nonce"",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""decimals"",""outputs"":[{""name"":"""",""type"":""uint8""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""sellPrice"",""outputs"":[{""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""_signature"",""type"":""bytes""},{""name"":""_spender"",""type"":""address""},{""name"":""_value"",""type"":""uint256""},{""name"":""_fee"",""type"":""uint256""},{""name"":""_nonce"",""type"":""uint256""}],""name"":""approvePreSigned"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""_tokenSupply"",""outputs"":[{""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""_spender"",""type"":""address""},{""name"":""_subtractedValue"",""type"":""uint256""}],""name"":""decreaseApproval"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[{""name"":""_owner"",""type"":""address""}],""name"":""balanceOf"",""outputs"":[{""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""buyPrice"",""outputs"":[{""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""_signature"",""type"":""bytes""},{""name"":""_spender"",""type"":""address""},{""name"":""_subtractedValue"",""type"":""uint256""},{""name"":""_fee"",""type"":""uint256""},{""name"":""_nonce"",""type"":""uint256""}],""name"":""decreaseApprovalPreSigned"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""owner"",""outputs"":[{""name"":"""",""type"":""address""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""symbol"",""outputs"":[{""name"":"""",""type"":""string""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""_recipients"",""type"":""address[]""},{""name"":""_values"",""type"":""uint256[]""}],""name"":""sendBatchCS"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":false,""inputs"":[],""name"":""buy"",""outputs"":[],""payable"":true,""stateMutability"":""payable"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""_to"",""type"":""address""},{""name"":""_value"",""type"":""uint256""}],""name"":""transfer"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""_signature"",""type"":""bytes""},{""name"":""_spender"",""type"":""address""},{""name"":""_addedValue"",""type"":""uint256""},{""name"":""_fee"",""type"":""uint256""},{""name"":""_nonce"",""type"":""uint256""}],""name"":""increaseApprovalPreSigned"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""decimalValue"",""outputs"":[{""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""_spender"",""type"":""address""},{""name"":""_addedValue"",""type"":""uint256""}],""name"":""increaseApproval"",""outputs"":[{""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[{""name"":""_owner"",""type"":""address""},{""name"":""_spender"",""type"":""address""}],""name"":""allowance"",""outputs"":[{""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""amount"",""type"":""uint256""}],""name"":""sell"",""outputs"":[],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[{""name"":""_token"",""type"":""address""},{""name"":""_functionSig"",""type"":""bytes4""},{""name"":""_spender"",""type"":""address""},{""name"":""_value"",""type"":""uint256""},{""name"":""_fee"",""type"":""uint256""},{""name"":""_nonce"",""type"":""uint256""}],""name"":""recoverPreSignedHash"",""outputs"":[{""name"":"""",""type"":""bytes32""}],""payable"":false,""stateMutability"":""pure"",""type"":""function""},{""constant"":false,""inputs"":[{""name"":""newOwner"",""type"":""address""}],""name"":""transferOwnership"",""outputs"":[],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""inputs"":[],""payable"":false,""stateMutability"":""nonpayable"",""type"":""constructor""},{""anonymous"":false,""inputs"":[{""indexed"":true,""name"":""from"",""type"":""address""},{""indexed"":true,""name"":""to"",""type"":""address""},{""indexed"":true,""name"":""delegate"",""type"":""address""},{""indexed"":false,""name"":""amount"",""type"":""uint256""},{""indexed"":false,""name"":""fee"",""type"":""uint256""}],""name"":""TransferPreSigned"",""type"":""event""},{""anonymous"":false,""inputs"":[{""indexed"":true,""name"":""from"",""type"":""address""},{""indexed"":true,""name"":""to"",""type"":""address""},{""indexed"":true,""name"":""delegate"",""type"":""address""},{""indexed"":false,""name"":""amount"",""type"":""uint256""},{""indexed"":false,""name"":""fee"",""type"":""uint256""}],""name"":""ApprovalPreSigned"",""type"":""event""},{""anonymous"":false,""inputs"":[{""indexed"":true,""name"":""existingOwner"",""type"":""address""},{""indexed"":true,""name"":""newOwner"",""type"":""address""}],""name"":""transferOwner"",""type"":""event""},{""anonymous"":false,""inputs"":[{""indexed"":true,""name"":""owner"",""type"":""address""},{""indexed"":true,""name"":""spender"",""type"":""address""},{""indexed"":false,""name"":""value"",""type"":""uint256""}],""name"":""Approval"",""type"":""event""},{""anonymous"":false,""inputs"":[{""indexed"":true,""name"":""from"",""type"":""address""},{""indexed"":true,""name"":""to"",""type"":""address""},{""indexed"":false,""name"":""value"",""type"":""uint256""}],""name"":""Transfer"",""type"":""event""}]";

		public static string InfuraUrl = "https://mainnet.infura.io/v3/f165b595cd184b2a848716830f9804b0";//"https://rinkeby.infura.io/v3/f165b595cd184b2a848716830f9804b0";//rinkeby

		public static int decimalNumber = 18;

		public static double feis = .0001;//fee in %


		public static bool IsQuartzDone { get; set; } = true; //quartz

		public static string PublicKeyCP = "";
		public static string PrivateKeyCP = "";

		public const string EmailNotice = ".You Will Receieve Email Exactly 1 Minute Later. Thanks For The Patient.";


		//rewards
		public static int signupReward = 5;
		public static int referralReward = 2;

		public static int fbShareReward = 5;
		public static int redditShareReward = 5;
		public static int twitterShareReward = 5;
		public static int instagramShareReward = 5;

		public static int teleramJoinReward = 5;
	}
}
