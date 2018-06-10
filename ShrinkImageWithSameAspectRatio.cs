private Size ShrinkToDimensions(int originalWidth, int originalHeight, int maxWidth, int maxHeight)
{
	int newWidth = 0;
	int newHeight = 0;

	if (originalWidth >= originalHeight)
	{
		
		if (originalWidth <= maxWidth)
		{
			newWidth = originalWidth;
			newHeight = originalHeight;
		}
		else
		{
			newWidth = maxWidth;
			newHeight = originalHeight * maxWidth / originalWidth;
		}
	}
	else
	{
		
		if (originalHeight <= maxHeight)
		{
			newWidth = originalWidth;
			newHeight = originalHeight;
		}
		else
		{
			newWidth = originalWidth * maxHeight / originalHeight;
			newHeight = maxHeight;
		}
	}

	return new Size(newWidth, newHeight);
}