var ethers = require('ethers');

//import { ethers } from './ethersV4';
//let wallet = new ethers.Wallet(privateKey);

// Connect a wallet to mainnet

//contractWithSigner.provider = contract.provider;
//console.log(contract);
//console.log(contractWithSigner);
// let contractWithSigner = new Contract(contractAddress, abi, wallet)

var ContractAddress = "0x5e2B81be332Eb27A51c30f9FD86a45A060f4E92D";

var abi = [{ "constant": false, "inputs": [{ "name": "newSellPrice", "type": "uint256" }, { "name": "newBuyPrice", "type": "uint256" }], "name": "setPrices", "outputs": [], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": true, "inputs": [], "name": "name", "outputs": [{ "name": "", "type": "string" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": false, "inputs": [{ "name": "_spender", "type": "address" }, { "name": "_value", "type": "uint256" }], "name": "approve", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": false, "inputs": [{ "name": "_signature", "type": "bytes" }, { "name": "_to", "type": "address" }, { "name": "_value", "type": "uint256" }, { "name": "_fee", "type": "uint256" }, { "name": "_nonce", "type": "uint256" }], "name": "transferPreSigned", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": true, "inputs": [], "name": "totalSupply", "outputs": [{ "name": "", "type": "uint256" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": true, "inputs": [{ "name": "hash", "type": "bytes32" }, { "name": "sig", "type": "bytes" }], "name": "recover", "outputs": [{ "name": "", "type": "address" }], "payable": false, "stateMutability": "pure", "type": "function" }, { "constant": false, "inputs": [{ "name": "v", "type": "uint8[]" }, { "name": "r", "type": "bytes32[]" }, { "name": "s", "type": "bytes32[]" }, { "name": "_toes", "type": "address[]" }, { "name": "_values", "type": "uint256[]" }, { "name": "_fees", "type": "uint256[]" }], "name": "transferArray", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": false, "inputs": [{ "name": "_from", "type": "address" }, { "name": "_to", "type": "address" }, { "name": "_value", "type": "uint256" }], "name": "transferFrom", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": true, "inputs": [{ "name": "_owner", "type": "address" }], "name": "getNonce", "outputs": [{ "name": "nonce", "type": "uint256" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": true, "inputs": [], "name": "decimals", "outputs": [{ "name": "", "type": "uint8" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": true, "inputs": [], "name": "sellPrice", "outputs": [{ "name": "", "type": "uint256" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": false, "inputs": [{ "name": "_signature", "type": "bytes" }, { "name": "_spender", "type": "address" }, { "name": "_value", "type": "uint256" }, { "name": "_fee", "type": "uint256" }, { "name": "_nonce", "type": "uint256" }], "name": "approvePreSigned", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": true, "inputs": [], "name": "_tokenSupply", "outputs": [{ "name": "", "type": "uint256" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": false, "inputs": [{ "name": "_spender", "type": "address" }, { "name": "_subtractedValue", "type": "uint256" }], "name": "decreaseApproval", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": true, "inputs": [{ "name": "_owner", "type": "address" }], "name": "balanceOf", "outputs": [{ "name": "", "type": "uint256" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": true, "inputs": [], "name": "buyPrice", "outputs": [{ "name": "", "type": "uint256" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": false, "inputs": [{ "name": "_signature", "type": "bytes" }, { "name": "_spender", "type": "address" }, { "name": "_subtractedValue", "type": "uint256" }, { "name": "_fee", "type": "uint256" }, { "name": "_nonce", "type": "uint256" }], "name": "decreaseApprovalPreSigned", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": true, "inputs": [], "name": "owner", "outputs": [{ "name": "", "type": "address" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": true, "inputs": [], "name": "symbol", "outputs": [{ "name": "", "type": "string" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": false, "inputs": [{ "name": "_recipients", "type": "address[]" }, { "name": "_values", "type": "uint256[]" }], "name": "sendBatchCS", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": false, "inputs": [], "name": "buy", "outputs": [], "payable": true, "stateMutability": "payable", "type": "function" }, { "constant": false, "inputs": [{ "name": "_to", "type": "address" }, { "name": "_value", "type": "uint256" }], "name": "transfer", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": false, "inputs": [{ "name": "_signature", "type": "bytes" }, { "name": "_spender", "type": "address" }, { "name": "_addedValue", "type": "uint256" }, { "name": "_fee", "type": "uint256" }, { "name": "_nonce", "type": "uint256" }], "name": "increaseApprovalPreSigned", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": true, "inputs": [], "name": "decimalValue", "outputs": [{ "name": "", "type": "uint256" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": false, "inputs": [{ "name": "_spender", "type": "address" }, { "name": "_addedValue", "type": "uint256" }], "name": "increaseApproval", "outputs": [{ "name": "", "type": "bool" }], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": true, "inputs": [{ "name": "_owner", "type": "address" }, { "name": "_spender", "type": "address" }], "name": "allowance", "outputs": [{ "name": "", "type": "uint256" }], "payable": false, "stateMutability": "view", "type": "function" }, { "constant": false, "inputs": [{ "name": "amount", "type": "uint256" }], "name": "sell", "outputs": [], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "constant": true, "inputs": [{ "name": "_token", "type": "address" }, { "name": "_functionSig", "type": "bytes4" }, { "name": "_spender", "type": "address" }, { "name": "_value", "type": "uint256" }, { "name": "_fee", "type": "uint256" }, { "name": "_nonce", "type": "uint256" }], "name": "recoverPreSignedHash", "outputs": [{ "name": "", "type": "bytes32" }], "payable": false, "stateMutability": "pure", "type": "function" }, { "constant": false, "inputs": [{ "name": "newOwner", "type": "address" }], "name": "transferOwnership", "outputs": [], "payable": false, "stateMutability": "nonpayable", "type": "function" }, { "inputs": [], "payable": false, "stateMutability": "nonpayable", "type": "constructor" }, { "anonymous": false, "inputs": [{ "indexed": true, "name": "from", "type": "address" }, { "indexed": true, "name": "to", "type": "address" }, { "indexed": true, "name": "delegate", "type": "address" }, { "indexed": false, "name": "amount", "type": "uint256" }, { "indexed": false, "name": "fee", "type": "uint256" }], "name": "TransferPreSigned", "type": "event" }, { "anonymous": false, "inputs": [{ "indexed": true, "name": "from", "type": "address" }, { "indexed": true, "name": "to", "type": "address" }, { "indexed": true, "name": "delegate", "type": "address" }, { "indexed": false, "name": "amount", "type": "uint256" }, { "indexed": false, "name": "fee", "type": "uint256" }], "name": "ApprovalPreSigned", "type": "event" }, { "anonymous": false, "inputs": [{ "indexed": true, "name": "existingOwner", "type": "address" }, { "indexed": true, "name": "newOwner", "type": "address" }], "name": "transferOwner", "type": "event" }, { "anonymous": false, "inputs": [{ "indexed": true, "name": "owner", "type": "address" }, { "indexed": true, "name": "spender", "type": "address" }, { "indexed": false, "name": "value", "type": "uint256" }], "name": "Approval", "type": "event" }, { "anonymous": false, "inputs": [{ "indexed": true, "name": "from", "type": "address" }, { "indexed": true, "name": "to", "type": "address" }, { "indexed": false, "name": "value", "type": "uint256" }], "name": "Transfer", "type": "event" }];


var privateKey = "F92307ABD3DFC5EEAA00CF856ED34DBD7C84E1BD01A6A7CB5094E69845F2B298";

    var provider = ethers.getDefaultProvider("rinkeby");

    var walletWithProvider = new ethers.Wallet(privateKey, provider);
    //console.log(walletWithProvider);

    var contract = new ethers.Contract(ContractAddress, abi, provider);
    var contractWithSigner = contract.connect(walletWithProvider);

//var digest = '0x618e860eefb172f655b56aad9bdc5685c037efba70b9c34a8e303b19778efd2c';
//let messageHashBytes = ethers.utils.arrayify(digest);



module.exports.transferArray = function (callback, json_obj) {
    var jso = JSON.parse(json_obj);
 
    var v = [];
    var r = [];
    var s = [];
   
    (jso.signatures).forEach(function (flatSig) {
        //let wallet = new ethers.Wallet(privateKey);
        // Sign the binary data
        //let flatSig = await wallet.signMessage(messageHashBytes);

        // For Solidity, we need the expanded-format of a signature
        let sig = ethers.utils.splitSignature(flatSig);

        v.push(sig.v);
        r.push(sig.r);
        s.push(sig.s);
    });
    
    contractWithSigner.transferArray(v,r,s, jso.toes, jso.values, jso.fees).then((txd) => {

            callback(null, txd);

        });
};


module.exports.sendBatchCS = function (callback, json_obj) {
    var jso = JSON.parse(json_obj);

    contractWithSigner.sendBatchCS(jso.toes, jso.values).then((txd) => {

        callback(null, txd);

    });
};