using BulletinAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BulletinAPI.Controllers.Bulletins
{ 
    [ApiController]
    [Route("/api/bulletins")]
    public class BulletinSearchController : ControllerBase
    {
        private readonly Bulletin[] _data = new Bulletin[]
        {
                new Bulletin
                {
                    Id = "c8aa708c-77c7-4423-873e-586729c6f61b",
                    Title = "Silver Selections",
                    Description = "Here to help with all your silver-fearing monster murders!",
                    Votes = 33
                },
                new Bulletin
                {
                    Id = "24eeab3a-0e01-448d-b9ab-00a322ee7503",
                    Title = "Fort Knights",
                    Description = "Actors to help with your Medival parties!",
                    Votes = 30
                },
                new Bulletin
                {
                    Id = "24eeab3a-0e01-448d-b9ab-00a322ee7503",
                    Title = "Drop Top Customs",
                    Description = "Turning your car from blah to bling!",
                    Votes = 25
                },
                new Bulletin
                {
                    Id = "b421819f-0763-4182-8ae4-51f2f0b183f9",
                    Title = "Tin Foil Hats",
                    Description = "Fashionable headwear for the consipiracy theorist in you!",
                    Votes = 22
                },
                new Bulletin
                {
                    Id = "ed52a79c-4a8e-4945-9d33-da74f769905d",
                    Title = "Gilded Rose Catering",
                    Description = "The best food in the kingdom, brought to your door!",
                    Votes = 21
                }
        };

        [HttpGet]
        public IEnumerable<Bulletin> GetBulletins()
        {
            return _data;
        }
    }
}
