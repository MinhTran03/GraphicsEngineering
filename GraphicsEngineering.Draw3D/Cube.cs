using GraphicsEngineering.DataAccess.Common;
using GraphicsEngineering.DataAccess.Models;
using System.Collections.Generic;
using System.Drawing;

namespace GraphicsEngineering.Draw3D
{
    public class Cube
    {
		public Point3D Kernel { get; set; }
		public int Length { get; set; }
		public Graphics Graphics { get; set; }
		private List<Line> lines { get; set; }
		private List<Line> linesHide { get; set; }

		public Cube(Point3D kernel, int length)
		{
			Kernel = kernel;
			Length = length;

			lines = new List<Line>();
			linesHide = new List<Line>();
			var points = new Point[8];

			int halfLength = Length / 2;
			int x = Kernel.X;
			int y = Kernel.Y;
			int z = Kernel.Z;

			points[0] = new Point3D(x - halfLength, y - halfLength, z + halfLength).To2DCoordinates();
			points[1] = new Point3D(x + halfLength, y - halfLength, z + halfLength).To2DCoordinates();
			points[2] = new Point3D(x + halfLength, y + halfLength, z + halfLength).To2DCoordinates();
			points[3] = new Point3D(x - halfLength, y + halfLength, z + halfLength).To2DCoordinates();

			points[4] = new Point3D(x - halfLength, y - halfLength, z - halfLength).To2DCoordinates();
			points[5] = new Point3D(x + halfLength, y - halfLength, z - halfLength).To2DCoordinates();
			points[6] = new Point3D(x + halfLength, y + halfLength, z - halfLength).To2DCoordinates();
			points[7] = new Point3D(x - halfLength, y + halfLength, z - halfLength).To2DCoordinates();

			lines.Add(new Line(points[0], points[1]));
			lines.Add(new Line(points[0], points[3]));
			lines.Add(new Line(points[2], points[1]));
			lines.Add(new Line(points[2], points[3]));

			linesHide.Add(new Line(points[4], points[5]));
			linesHide.Add(new Line(points[4], points[7]));
			lines.Add(new Line(points[6], points[5]));
			lines.Add(new Line(points[6], points[7]));

			linesHide.Add(new Line(points[0], points[4]));
			lines.Add(new Line(points[3], points[7]));
			lines.Add(new Line(points[1], points[5]));
			lines.Add(new Line(points[2], points[6]));
		}

		public void Draw(Graphics graphics, Color color)
		{
			foreach (var line in lines)
			{
				line.Color = color;
				line.Draw(graphics, Dashes.Solid);
			}
			foreach (var line in linesHide)
			{
				line.Color = color;
				line.Draw(graphics, Dashes.Dash);
			}
		}
		public void Draw(Graphics graphics) => Draw(graphics, Color.Black);

		public override string ToString()
		{
			return $">Cube: \n" +
				$"\t + Kernel: {Kernel.ToString()} \n" +
				$"\t + Length: {Length} \n";
		}
	}
}
