using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gravity.Models
{
    public class Referral
	{
		[Key]
        public string Email { get; set; }
		public DateTime CreationDate { get; set; } = DateTime.UtcNow;
		public string Status { get; set; }//Unverified,Active
		public string Bonus { get; set; }//Pending,Success

		public string Invitation { get; set; }//Sent,Verified,resend

		[Required]
		public string UserId { get; set; }

		public ApplicationUser User { get; set; }
	}
}
