using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsTest
{
    [TestClass]
  public  class ClaimRepositoryTest
    {
            private ClaimRepository _repo;
            private Claim _content;

            [TestInitialize]
            public void Arrange()
            {
                _repo = new ClaimRepository();
                _content = new Claim();
                _repo.CreateAClaim(_content);
            }
        //Add Method

        [TestMethod]
        public void CreateAClaim()
            {
                //Arrange---Setting up the playing field
                Claim content = new Claim();
                content.ClaimID = 1;
                ClaimRepository repository = new ClaimRepository();

                //Act---Get/run the code we want to test
               bool addResult = repository.CreateAClaim(content);

                //Assert--- Use the assert class to verify 
                Assert.IsTrue(addResult);
            }

        

      
        [TestMethod]
        
        public void DeleteClaim_ShouldReturnTrue()
            {
            //Arrange
            _repo = new ClaimRepository();
            _content = new Claim(1, "Car", "Ran into a pole", 5000,new DateTime(2020,01,12),new DateTime(2020,05,12),true);
            _repo.CreateAClaim(_content);   
            //Act
             bool deleteResult = _repo.DeleteAClaim();
             //Assert
            Assert.IsTrue(deleteResult);
            
            }
        
        
        }



    }



