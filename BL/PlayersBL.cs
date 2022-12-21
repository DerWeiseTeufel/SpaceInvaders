using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class PlayersBL : IPlayersBL
    {
        private IPlayersDal _dal;

        public PlayersBL(IPlayersDal dal)
        {
            _dal = dal;
        }

        public Player GetByLogin(string login) {
            return _dal.GetByLogin(login);
        }

        public Player GetById(int id)
        {
            return _dal.GetById(id);
        }

        public void WritePlayerToBD(Player Player)
        {
            _dal.WritePlayerToBD(Player);
        }

	}
}
