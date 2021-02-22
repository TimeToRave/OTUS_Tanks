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

		/// <summary>
		/// Моментальная угловая скорость
		/// </summary>
		//int AngularVelocity { get; set; }
	}
}
