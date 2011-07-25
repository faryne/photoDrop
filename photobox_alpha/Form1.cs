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
      // 檢查使用者的相本主頁
      if (Properties.Settings.Default.MainPage == "")
      {
        Guid guid = Guid.NewGuid();
        string uuid = guid.ToString();
        
        Properties.Settings.Default.MainPage = uuid;
        Properties.Settings.Default.Save();
      }
      // 設定使用者的相本主頁
      linkLabel2.Text = Properties.Settings.Default.MainSiteUrl + Properties.Settings.Default.MainPage;
    }

    // 讓使用者選擇要監視的目錄，若目錄路徑不存在或是空白時，則無效
    private int _choose_times = 0;
    private void button2_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog dialog = new FolderBrowserDialog();
      dialog.Description = "請選擇要監視的目錄";
      dialog.ShowDialog();
      if (dialog.SelectedPath == "" || !Directory.Exists(dialog.SelectedPath))
      {
        if (this._choose_times > 3)
        {
          MessageBox.Show("取消選擇目錄");
          return;
        }
        button2_Click(sender, e); // 重跑一次選擇
        this._choose_times++;
        return;
      }
      textBox1.Text = dialog.SelectedPath;
    }

    // 儲存使用者所決定好的設定內容
    private void button3_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.Save();
      MessageBox.Show("設定已儲存");
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(Properties.Settings.Default.MainSiteUrl + Properties.Settings.Default.MainPage);
    }

  }
}
