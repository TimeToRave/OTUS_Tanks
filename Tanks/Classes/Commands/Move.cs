using Tanks.Interfaces;

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
