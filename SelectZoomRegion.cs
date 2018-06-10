private Image MarkImage(Image input, Rectangle selectedArea, Color selectColor)
{
	Bitmap newImg = new Bitmap(input.Width, input.Height);

	using (Graphics g = Graphics.FromImage(newImg))
	{

		input.RotateFlip(RotateFlipType.Rotate180FlipNone);
		input.RotateFlip(RotateFlipType.Rotate180FlipNone);

		g.DrawImage(input, 0, 0);


		using (Pen p = new Pen(selectColor))
			g.DrawRectangle(p, selectedArea);
	}

	return (Image)newImg;
}