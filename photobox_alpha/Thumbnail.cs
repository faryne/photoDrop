using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Imaging;

using System.IO;

namespace photobox_alpha
{
  // 負責產生縮圖檔的類別
  class Thumbnail
  {
    private string filename;

    public Thumbnail(string filename)
    {
      FileInfo info = new FileInfo(filename);
      string ext = info.Extension.Replace(".", "");
      if (ext != "jpg" && ext != "gif" && ext != "png")
      {
        throw new Exception("檔案類型錯誤");
      }
      this.filename = filename;
    }

    public void create()
    {
      //FileInfo info = 
      Image img = Image.FromFile(@"C:\Users\Faryne\Downloads\moe 165261 fllay kousaka_kirino ore_no_imouto_ga_konnani_kawaii_wake_ga_nai pantsu thighhighs.jpg");
      ImageFormat imgformat = img.RawFormat;
      int fixWidth = 0, fixHeight = 0, maxPix = Convert.ToInt16(500);

      if (img.Width > maxPix || img.Height > maxPix)
      {
        if (img.Width > img.Height)
        {
          fixWidth = maxPix;
          fixHeight = Convert.ToInt32((Convert.ToDouble(fixWidth) / Convert.ToDouble(img.Width)) * Convert.ToDouble(img.Height));
        }
        else
        {
          fixHeight = maxPix;
          fixWidth = Convert.ToInt32((Convert.ToDouble(fixHeight) / Convert.ToDouble(img.Height)) * Convert.ToDouble(img.Width));
        }
      }
      else
      {
        fixHeight = img.Height;
        fixWidth  = img.Width;
      }

      Bitmap output = new Bitmap(img, fixWidth, fixHeight);
      string filename = @"C:\Users\Faryne\Downloads\test_thumbnail.jpg";
      output.Save(filename, imgformat);
      output.Dispose();
      img.Dispose();
    }

  }
}
