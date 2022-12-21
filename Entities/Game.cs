using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
	public class Game
	{
		public int Id { get; set; }
		public int PlayerId { get; set; }
		public int Score { get; set; }
		public DateTime DofMatch { get; set; }
	}
}
