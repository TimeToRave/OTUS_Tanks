using Tanks.Interfaces;

namespace Tanks.Classes.Commands
{
	class RotateLeft : ICommand
	{
		IRotable RotableEntity { get; set; }

		public RotateLeft(IRotable rotableEntity)
		{
			RotableEntity = rotableEntity;
		}

		public bool Execute()
		{
			RotableEntity.Velocity.Swap();
			RotableEntity.Velocity.Y *= -1;
			return true;
		}
	}
}
