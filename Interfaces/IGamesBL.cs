using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
	public interface IGamesBL
	{
		Game GetByPlayerId(int playerID);
		void WriteGameToBD(Game game);
	}
}
