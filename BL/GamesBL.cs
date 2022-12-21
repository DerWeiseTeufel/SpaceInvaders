using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace BL
{
	internal class GamesBL : IGamesBL
	{
		private IGamesDAL _dal;

		public GamesBL(IGamesDAL dal)
		{
			_dal = dal;
		}

		public Game GetByPlayerId(int PlayerId)
		{
			return _dal.GetByPlayerId(PlayerId);
		}

		public void WriteGameToBD(Game play)
		{
			_dal.WriteGameToBD(play);
		}
	}
}
