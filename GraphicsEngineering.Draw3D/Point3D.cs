namespace GraphicsEngineering.Draw3D
{
	public class Point3D
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }

		public Point3D()
		{
			X = 0;
			Y = 0;
			Z = 0;
		}
		public Point3D(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public override string ToString()
		{
			return "{X = " + X + ", Y = " + Y + ", Z = " + Z + "}";
		}
	}
}
