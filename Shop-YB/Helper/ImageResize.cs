using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace ShopYB.Helper
{
    public class ImageResize
    {
        private void imageResize(string inputPath,string outputPath,int newWidth)
        {
            const long quality = 50L;

            Bitmap sourceBp = new Bitmap(inputPath);

            double dblWidthOrginal = sourceBp.Width;
            double dblHeightOrginal = sourceBp.Height;
            double relationHieghtWidth = dblHeightOrginal / dblWidthOrginal;
            int newHeight = (int)(newWidth*relationHieghtWidth);


            //create Empty DrawArea
            var newDrawArea = new Bitmap(newWidth, newHeight);

            using (var graphic = Graphics.FromImage(newDrawArea))
            {
                graphic.CompositingQuality = CompositingQuality.HighSpeed;
                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphic.CompositingMode = CompositingMode.SourceCopy;


                graphic.DrawImage(sourceBp, 0, 0, newWidth, newHeight);

                using (var output=System.IO.File.Open(outputPath,FileMode.Create))
                {
                    var qualityParamId = Encoder.Quality;
                    var encoderParameter = new EncoderParameters(1);
                    encoderParameter.Param[0] = new EncoderParameter(qualityParamId, quality);

                    var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);
                    newDrawArea.Save(output, codec, encoderParameter);
                    output.Close();
                }

                graphic.Dispose();
            }
            sourceBp.Dispose();


        }
    }
}
