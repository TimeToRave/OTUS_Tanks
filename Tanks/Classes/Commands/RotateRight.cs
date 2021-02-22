using Tanks.Interfaces;

namespace Tanks.Classes.Commands
{
	class RotateRight : ICommand
	{
		IRotable RotableEntity { get; set; }

		public RotateRight (IRotable rotableEntity)
		{
			RotableEntity = rotableEntity;
		}

		public bool Execute ()
		{
			RotableEntity.Velocity.X *= -1;
			RotableEntity.Velocity.Swap();
			return true;
		}
	}
}
