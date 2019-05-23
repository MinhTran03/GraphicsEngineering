using GraphicsEngineering.DataAccess.Models;
using System.Drawing;

namespace GraphicsEngineering.DataAccess.Common
{
	public enum OppositeType
	{
		VerticalAxis,
        HorizontalAxis,
		OriginCoordinates,
	}

	public enum Dashes
	{
		Solid,
		Dash
	}

	public class Cons
	{
		public static int WIDTH = 0;
		public static int HEIGHT = 0;

		public static int DISTANCE_THOR_MJOLNIR = 100;
		public static Size HUMAN_SIZE = new Size(30, 47);
		public static Point HUMAN_LOCATION = new Point(80, HUMAN_SIZE.Height);
		public static Size MJOLNIR_SIZE = new Size(10, 18);
		public static Point MJOLNIR_LOCATION = new Point(HUMAN_LOCATION.X - DISTANCE_THOR_MJOLNIR, MJOLNIR_SIZE.Height);
	}
}
