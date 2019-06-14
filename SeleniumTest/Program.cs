using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace NUnitTest
{
    class Test
    {

    }
    class Program
    {
        class PetOwner
        {
            public string Name { get; set; }
            public List<string> Pets { get; set; }
        }

        static void Main(string[] args)
        {
            PetOwner[] petOwners =
        { new PetOwner { Name="Higa",
              Pets = new List<string>{ "Scruffy", "Sam" } },
          new PetOwner { Name="Ashkenazi",
              Pets = new List<string>{ "Walker", "Sugar" } },
          new PetOwner { Name="Price",
              Pets = new List<string>{ "Scratches", "Diesel" } },
          new PetOwner { Name="Hines",
              Pets = new List<string>{ "Dusty" } } };

            var query = petOwners.SelectMany(petOwner => petOwner.Pets, (owner, pet) => new { petOwner = owner, pet = pet })
                .Select(ownerAndPet => new { owner = ownerAndPet.petOwner.Name, pet=ownerAndPet.pet })
                .ToList();
        }
    }
}
