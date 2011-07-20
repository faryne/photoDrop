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

    }

  }
}
