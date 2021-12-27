using System.Collections.Generic;

namespace VesperrBackHomePage.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public List<Social> Socials { get; set; }
    }
}
