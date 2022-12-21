using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Interfaces
{
	public interface IGamesDAL
	{
		Game GetByPlayerId(int playerID);
		void WriteGameToBD(Game game);
	}
}
