using Entities;
using System;

namespace Interfaces
{
    public interface IPlayersDAL
    {
        Player GetById(int id);
        Player GetByLogin(string login);
		void WritePlayerToBD(Player player);
	}
}
