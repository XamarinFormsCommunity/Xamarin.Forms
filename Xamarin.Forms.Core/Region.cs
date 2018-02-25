using System.Collections.Generic;

namespace Xamarin.Forms
{
	public struct Region
	{
		
		// While Regions are currently rectangular, they could in the future be transformed into any shape.
		// As such the internals of how it keeps shapes is hidden, so that future internal changes can occur to support shapes
		// such as circles if required, without affecting anything else.

		IList<Rectangle> Regions { get; set; }

		public static Region FromLines(double[] lineHeights, double maxWidth, double startX, double endX, double startY)
		{
			var positions = new List<Rectangle>();
			var endLine = lineHeights.Length - 1;
			var lineHeightTotal = startY;

			for (var i = 0; i <= endLine; i++)
				if (endLine != 0) // MultiLine
				{
					if (i == 0) // First Line
						positions.Add(new Rectangle(startX, lineHeightTotal, maxWidth - startX, lineHeights[i]));

					else if (i != endLine) // Middle Line
						positions.Add(new Rectangle(0, lineHeightTotal, maxWidth, lineHeights[i]));

					else // End Line
						positions.Add(new Rectangle(0, lineHeightTotal, endX, lineHeights[i]));

					lineHeightTotal += lineHeights[i];
				}
				else // SingleLine
					positions.Add(new Rectangle(startX, lineHeightTotal, endX - startX, lineHeights[i]));

			return new Region() { Regions = positions };
		}

		public bool Contains(Point pt)
		{
			return Contains(pt.X, pt.Y);
		}

		public bool Contains(double x, double y)
		{
			if (Regions == null)
				return false;

			for (int i = 0; i < Regions.Count; i++)
				if (Regions[i].Contains(x, y))
					return true;

			return false;
		}

		public Region Inflate(double size)
		{
			return Inflate(size, size, size, size);
		}

		public Region Inflate(double left, double top, double right, double bottom)
		{
			if (Regions == null)
				return this;

			for (int i = 0; i < Regions.Count; i++)
			{
				var region = Regions[i];

				if (i == 0) // this is the first line
					region.Top -= top;

				region.Left -= left;
				region.Right += right;

				if (i == Regions.Count - 1) // This is the last line
					region.Bottom += bottom;

				Regions[i] = region;
			}

			return this;
		}
	}
}