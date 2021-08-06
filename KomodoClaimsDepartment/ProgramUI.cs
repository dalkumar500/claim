using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDepartment
{
    class ProgramUI
    {
        private readonly ClaimRepository _claimRepo = new ClaimRepository();


        //Method that Runs/Start the Application
        public void Run()
        {
            SeedItemsList();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                //Display our option to the user
                Console.WriteLine("Select a menu option:\n" +
                   "1. See All claims\n" +
                   "2. Take care of next claims\n" +
                   "3. Enter a new claim\n" +
                   "4.Exit");
                //Get the user's input
                string input = Console.ReadLine();

                //Evaluate the user's input and act acoordingly


                switch (input)
                {
                    case "1":
                        //See All Claims
                        ReadAllClaims();
                        break;
                    case "2":
                        //Take care of next claims
                        DeleteAClaim();
                        break;

                    case "3":
                        //Enter a new claim
                        CreateAllclaims();
                        break;


                    case "4":
                        //Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("please enter a valid number");
                        break;
                }
                Console.WriteLine("please press any key to continue..");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Enter A new Claim
        private void CreateAllclaims()
        {

            Console.Clear();

            Claim show = new Claim();
            //Claim ID
            Console.WriteLine("Enter the ClaimID:");
            string claimIDASSting = Console.ReadLine();
            show.ClaimID = int.Parse(claimIDASSting);

            //ClaimType
            Console.WriteLine("Enter the CliamType:");
            show.ClaimType = Console.ReadLine();


            //Description
            Console.WriteLine("Enter the description here:");
            show.Description = Console.ReadLine();

            //Claim Amount
            Console.WriteLine("Enter the  ClaimAmount:");
            string claimAmountASString = Console.ReadLine();
            show.ClaimAmount = int.Parse(claimAmountASString);

            //Date of Incident
            Console.WriteLine("Enter the Date of DateofIncident :");
            string dateofIncidentASString = Console.ReadLine();
            show.DateOfIncident = DateTime.Parse(dateofIncidentASString);

            //DateOfClaim
            Console.WriteLine("Enter the Date of DateOfClaim :");
            string dateofClaimASString = Console.ReadLine();
            show.DateOfIncident = DateTime.Parse(dateofClaimASString);

            _claimRepo.CreateAClaim(show);
        }

        //view Current MenuConten that is saved
        private void ReadAllClaims()
        {
            Console.Clear();
            Queue<Claim> readClaim = _claimRepo.GetClaimIDList();
            foreach (Claim see in readClaim)
            {
                Console.WriteLine($" Number:{see.ClaimID}\n" +
                    $"Claim ID:{see.ClaimID}\n");
            }


        }

        //delete the claims

        private void DeleteAClaim()
        {
            // Deleate Exiciting Meal
            Queue<Claim> currentClaim = _claimRepo.GetClaimIDList();



            if (currentClaim.Count > 0)
            {
                
                Claim peek = currentClaim.Peek();
                
                Console.WriteLine($"{peek.ClaimID}");
                Console.WriteLine($"{peek.ClaimType}");
                Console.WriteLine($"{peek.Description}");
                Console.WriteLine($"{peek.ClaimAmount}");
                Console.WriteLine($"{peek.DateOfIncident}");
                Console.WriteLine($"{peek.DateOfClaim}");
                Console.WriteLine($"{peek.IsValid}");
                Console.WriteLine("Do you want with this claim now (y/n)");
                string use = Console.ReadLine();
                switch (use)
                {
                    case "y":
                        currentClaim.Dequeue();
                        break;
                    case "n":
                        break;
                }

            }
            else
            {
                Console.WriteLine("the claim Could not be delated.");

            }

        }
        private void SeedItemsList()
        {
            Claim claim1 = new Claim(1, "Car", "Crashed car on 465",5000,new DateTime(2021,1,20), new DateTime(2021,1,23), true);
            Claim claim2 = new Claim(2, "Car", "Accident", 15000, new DateTime(2021, 2, 10), new DateTime(2021, 2, 13), true);
            Claim claim3 = new Claim(3, "Home", "fire", 5000, new DateTime(2021, 4, 15), new DateTime(2021, 4, 18), true);
            Claim claim4 = new Claim(4, "Theft", "stolen clothes", 10000, new DateTime(2021, 7, 20), new DateTime(2020, 12, 21), false);

            _claimRepo.CreateAClaim(claim1);
            _claimRepo.CreateAClaim(claim2);
            _claimRepo.CreateAClaim(claim3);
            _claimRepo.CreateAClaim(claim4);
        }
    }







} 





