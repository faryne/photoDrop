using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.IO;
using System.Configuration;


namespace photobox_alpha
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // 檢查是否已有設定監視目錄
      string watchDir = Properties.Settings.Default.WatchDirectory;
      if (watchDir != "" && Directory.Exists(watchDir))
      {
        label3.Text = "您已經設定監視此目錄";
        label3.Visible = true;
        // 重新索引整個目錄將（上一次離開程式時）有變更的檔案上傳
        // 啟動監視器
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog dialog = new FolderBrowserDialog();
      dialog.Description = "請選擇要監視的目錄";
      dialog.ShowDialog();
      textBox1.Text = dialog.SelectedPath;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (textBox1.Text == "")
      {
        MessageBox.Show("沒有選擇預設要監視的目錄");
        return;
      }
      Properties.Settings.Default.Save();
    }
  }
}
