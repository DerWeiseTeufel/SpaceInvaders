using System;

namespace Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Password { get; set; }
        public DateTime Regdate { set; get; }
    }
}
