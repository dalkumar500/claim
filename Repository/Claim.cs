using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    //plain Old c# Object---POCO
    public class Claim
    {
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }

        public string Description { get; set; }

        public int ClaimAmount { get; set; }

        public DateTime DateOfIncident { get; set; }

        public DateTime DateOfClaim { get; set; }

        public bool IsValid { get; set; }

        public Claim() { }

        public Claim(int claimid, string claimtype, string description, int claimamount, DateTime dateofincident, DateTime dateofclaim, bool isvalid)
        {
            ClaimID = claimid;
            ClaimType = claimtype;
            Description = description;
            ClaimAmount = claimamount;
            DateOfIncident = dateofincident;
            DateOfClaim = dateofclaim;
            IsValid = isvalid;







        }
    }
}
