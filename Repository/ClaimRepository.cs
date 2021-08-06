using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClaimRepository
    {
        public Queue<Claim> _claims = new Queue<Claim>();
        //create
        public bool CreateAClaim(Claim claim)
        {
            int claimLength = _claims.Count();
            _claims.Enqueue(claim);
            bool wasAdded = claimLength + 1 == _claims.Count();
            return wasAdded;
        }
           
        //read

        public Queue<Claim> GetClaimIDList()
        {
            return  _claims;

        }


        //Delete
        public bool DeleteAClaim()
        {
            int claimLength = _claims.Count();
            _claims.Dequeue();
            bool wasDeleted = claimLength -1 == _claims.Count();
            return wasDeleted;
        }

    }

}
