using Tanks.Classes;

namespace Tanks.Interfaces
{
	interface IShootable
	{
		/// <summary>
		/// Объект, который создается при выстреле
		/// </summary>
		IEntity Weapon { get; set; }
	}
}
