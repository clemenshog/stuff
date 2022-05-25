using System.Drawing;

using (Image image = Image.FromFile(@"sample.png"))
using (Image watermarkImage = Image.FromFile(@"watermark.png"))
using (Graphics imageGraphics = Graphics.FromImage(image))
using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
{
    int x = (image.Width - (watermarkImage.Width + 10));
    int y = (image.Height - (watermarkImage.Height + 10));
    watermarkBrush.TranslateTransform(x, y);
    imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));
    image.Save(@"myWatermark.png");
}