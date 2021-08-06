using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System;

namespace KomodoClaimsTest
{
    [TestClass]
    public class ClaimTest
    {
        [TestMethod]
       
        public void SetTitle_ShouldSetCorrectString()
        {
            //Arrange
            Claim idnumber = new Claim();

            idnumber.ClaimID = 1;
           
            //Act
            
            int expected = 1;
            int actual = idnumber.ClaimID;
           
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}


