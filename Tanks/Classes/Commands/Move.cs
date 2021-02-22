using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Interfaces;
using Tanks.Classes;

namespace Tanks.Classes.Commands
{
	class Move : ICommand 
	{
		IMovable MovableEntity { get; set; }

		public Move(IMovable movableEntity)
		{
			MovableEntity = movableEntity;
		}

		public bool Execute ()
		{
			MovableEntity.Position = MovableEntity.Position + MovableEntity.Velocity;
			return true;
		}
	}
}
