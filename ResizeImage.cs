private Image ResizeImage(Image input, Size newSize, InterpolationMode interpolation)
{
	Bitmap newImg = new Bitmap(newSize.Width, newSize.Height);

	using (Graphics g = Graphics.FromImage(newImg))
	{

		input.RotateFlip(RotateFlipType.Rotate180FlipNone);
		input.RotateFlip(RotateFlipType.Rotate180FlipNone);


		g.InterpolationMode = interpolation;


		g.DrawImage(input, 0, 0, newSize.Width, newSize.Height);
	}

	return (Image)newImg;
}