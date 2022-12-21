using System;
using System.Collections.Generic;



namespace ORMDal
{
    public partial class Games
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int Punkte { get; set; }
        
        public DateTime DateofMatch { get; set; }

        public virtual Players Players { get; set; }
    }
}
