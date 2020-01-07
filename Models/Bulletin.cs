using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulletinAPI.Models
{
    public class Bulletin
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Votes { get; set; }
    }
}
