using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMDal
{
    public class OrmPlayersDal : IPlayersDAL
    {
        public Entities.Player GetByLogin(string login)
        {
            
            
        }

        public Entities.Player GetById(int id)
        {
           

        }

        public void WritePlayerToBD(Entities.Player Player)
        {
            //future logic

        }
    }
}
