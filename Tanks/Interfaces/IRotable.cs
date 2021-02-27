using Tanks.Classes;

namespace Tanks.Interfaces
{
	/// <summary>
	/// Интерфейс, описывающий объект, который может поворачиваться
	/// </summary>
	interface IRotable
	{
		/// <summary>
		/// Текущее приращение скорости
		/// </summary>
		Point Velocity { get; set; }
	}
}
