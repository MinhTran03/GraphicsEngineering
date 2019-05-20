using GraphicsEngineering.DataAccess.Models;
using GraphicsEngineering.DataAccess.Common;
using System.Collections.Generic;
using System.Drawing;

namespace GraphicsEngineering.Draw3D
{
	public class SquarePyramid
	{
		public Point3D SquareKernel { get; set; }
		public int Height { get; set; }
		public int BaseEdge { get; set; }
		private List<Line> Lines { get; set; }
		private List<Line> LinesHide { get; set; }

		public SquarePyramid(Point3D squareKernel, int height, int baseEdge)
		{
			SquareKernel = squareKernel;
			Height = height;
			BaseEdge = baseEdge;

			int x = SquareKernel.X;
			int y = SquareKernel.Y;
			int z = SquareKernel.Z;
			int halfBottomEdge = BaseEdge / 2;

			var points = new Point[5];
			points[0] = new Point3D(x, y, z + Height).To2DCoordinates();
			points[1] = new Point3D(x - halfBottomEdge, y - halfBottomEdge, z).To2DCoordinates();
			points[2] = new Point3D(x + halfBottomEdge, y - halfBottomEdge, z).To2DCoordinates();
			points[3] = new Point3D(x + halfBottomEdge, y + halfBottomEdge, z).To2DCoordinates();
			points[4] = new Point3D(x - halfBottomEdge, y + halfBottomEdge, z).To2DCoordinates();

			Lines = new List<Line>();
			LinesHide = new List<Line>();
			LinesHide.Add(new Line(points[1], points[2]));
			LinesHide.Add(new Line(points[1], points[4]));
			Lines.Add(new Line(points[3], points[2]));
			Lines.Add(new Line(points[3], points[4]));

			LinesHide.Add(new Line(points[0], points[1]));
			Lines.Add(new Line(points[0], points[2]));
			Lines.Add(new Line(points[0], points[3]));
			Lines.Add(new Line(points[0], points[4]));
		}

		public void Draw(Graphics graphics, Color color)
		{
			foreach (var line in Lines)
			{
				line.Color = color;
				line.Draw(graphics, Dashes.Solid);
			}
			foreach (var line in LinesHide)
			{
				line.Color = color;
				line.Draw(graphics, Dashes.Dash);
			}
		}
		public void Draw(Graphics graphics) => Draw(graphics, Color.Black);

		public override string ToString()
		{
			return $" > Square Pyramid: \n" +
				$"\t + Square Kernel: {SquareKernel.ToString()} \n" +
				$"\t + Height: {Height.ToString()} \n" +
				$"\t + Base Edge: {BaseEdge.ToString()} \n";
		}
	}
}
