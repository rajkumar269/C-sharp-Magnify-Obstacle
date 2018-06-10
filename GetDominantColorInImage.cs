private Color GetDominantColor(Bitmap bmp, bool includeAlpha)
{
	
	BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
								   ImageLockMode.ReadWrite,
								   PixelFormat.Format32bppArgb);

	int stride = bmData.Stride;
	IntPtr Scan0 = bmData.Scan0;

	int r = 0;
	int g = 0;
	int b = 0;
	int a = 0;
	int total = 0;

	unsafe
	{
		byte* p = (byte*)(void*)Scan0;

		int nOffset = stride - bmp.Width * 4;
		int nWidth = bmp.Width;

		for (int y = 0; y < bmp.Height; y++)
		{
			for (int x = 0; x < nWidth; x++)
			{
				r += p[0];
				g += p[1];
				b += p[2];
				a += p[3];

				total++;

				p += 4;
			}
			p += nOffset;
		}
	}

	bmp.UnlockBits(bmData);

	r /= total;
	g /= total;
	b /= total;
	a /= total;

	if (includeAlpha)
		return Color.FromArgb(a, r, g, b);
	else
		return Color.FromArgb(r, g, b);
}