using Tanks.Classes;

namespace Tanks.Interfaces
{
	interface IGameMaster
	{
		(Point LeftBottom, Point RightTop) FieldSize { get; set; }
	}
}
