using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gravity.Models
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public decimal TotalCoin { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
