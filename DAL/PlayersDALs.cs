using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL
{
    public class PlayerDAL : IPlayersDAL
    {
        private List<Player> players = new List<Player>() {
            new Player() {Name = "n", Password = 0, Id = 0},
        };

        public Player GetById(int id)
        {
            return Players.FirstOrDefault(item => item.Id == id);
        }

        public Player GetByLogin(string login)
        {
            return Players.FirstOrDefault(item => item.Name == login);
        }

        public void WritePlayerToBD(Player Player)
        {
            Players.Add(Player);
        }

        
    }
}
