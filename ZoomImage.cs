private Image ZoomImage(Image input, Rectangle zoomArea, Rectangle sourceArea)
{
	Bitmap newBmp = new Bitmap(sourceArea.Width, sourceArea.Height);

	using (Graphics g = Graphics.FromImage(newBmp))
	{
		
		g.InterpolationMode = InterpolationMode.HighQualityBicubic;

		g.DrawImage(input, sourceArea, zoomArea, GraphicsUnit.Pixel);
	}

	return newBmp;
}