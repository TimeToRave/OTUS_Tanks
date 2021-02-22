using Tanks.Interfaces;

namespace Tanks.Classes.Commands
{
	class Move : ICommand 
	{
		IMovable MovableEntity { get; set; }
		IGameMaster GameMaster { get; set; }
		public Move(IMovable movableEntity, IGameMaster gameMaster)
		{
			MovableEntity = movableEntity;
			GameMaster = gameMaster;
		}

		public bool Execute ()
		{
			Point newPosition = MovableEntity.Position + MovableEntity.Velocity;

			bool isInField = (
				(GameMaster.FieldSize.LeftBottom.X <= newPosition.X) &&
				(GameMaster.FieldSize.RightTop.X >= newPosition.X) &&
				(GameMaster.FieldSize.LeftBottom.Y <= newPosition.Y) &&
				(GameMaster.FieldSize.RightTop.Y >= newPosition.Y)
			);

			if (isInField)
			{
				MovableEntity.Position = newPosition;
			}
			return true;
		}
	}
}
