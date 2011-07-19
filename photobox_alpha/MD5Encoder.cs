using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;
using System.IO;

namespace photobox_alpha
{
  class MD5Encoder
  {
    public static string encodeString (string s) 
    {
      string output = "";
      MD5 md5 = new MD5CryptoServiceProvider();
      byte[] input = Encoding.ASCII.GetBytes(s);
      byte[] a = md5.ComputeHash(input);
      for (int i = 0; i < a.Length; i++ )
      {
        output += a[i].ToString("X");
      }
      return output.ToLower();
    }

    public static string encodeFile(string filePath)
    {

      if (!File.Exists(filePath))
      {
        throw new Exception("檔案：" + filePath + "不存在");
      }
      MD5 md5 = new MD5CryptoServiceProvider();
      FileStream stream = new FileStream(filePath, FileMode.Open);
      byte[] input = md5.ComputeHash(stream);
      string output = "";
      for (int i = 0; i < input.Length; i++)
      {
        output += input[i].ToString("X");
      }
      return output.ToLower();
    }

  }
}
