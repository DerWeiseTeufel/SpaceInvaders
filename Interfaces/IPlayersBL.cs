using Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Interfaces
{
    public interface IPlayerBL
    {
        Player GetById(int id);
        Player GetByLogin(string login);
        void WritePlayerToBD(Player player);
    }
}
