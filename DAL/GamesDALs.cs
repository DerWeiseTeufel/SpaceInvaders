using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Entities;
using System.Linq;

namespace DAL
{
	internal class GamesDals : IGamesDAL
	{
		private List<Game> game = new List<Game>();

		public Game GetByPlayerId(int PlayerId)
		{
			return game.FirstOrDefault(x => x.PlayerId == PlayerId);
		}

		public Game GetById(int id)
		{
			return game.FirstOrDefault(x => x.Id == id);
		}

		public void WriteGameToBD(Game play)
		{
			game.Add(play);
		}
	}
}
