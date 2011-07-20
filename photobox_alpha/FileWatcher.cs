using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace photobox_alpha
{
  // 負責監視指定目錄的類別
  class FileWatcher
  {
    private FileSystemWatcher fw1 = new FileSystemWatcher();
    private FileSystemWatcher fw2 = new FileSystemWatcher();
    private FileSystemWatcher fw3 = new FileSystemWatcher();
    private static bool _isUpdated     = false;
    
    public void setWatcher (string dirPath)
    {
      fw1.Changed += new FileSystemEventHandler(_file_watcher_Changed);
      fw1.Deleted += new FileSystemEventHandler(_file_watcher_Deleted);
      fw1.Created += new FileSystemEventHandler(_file_watcher_Created);
      fw1.Renamed += new RenamedEventHandler(_file_watcher_Renamed);
      fw1.Filter = "*.png";
      
      fw2.Changed += new FileSystemEventHandler(_file_watcher_Changed);
      fw2.Deleted += new FileSystemEventHandler(_file_watcher_Deleted);
      fw2.Created += new FileSystemEventHandler(_file_watcher_Created);
      fw2.Renamed += new RenamedEventHandler(_file_watcher_Renamed);
      fw2.Filter = "*.jpg";
      
      fw3.Changed += new FileSystemEventHandler(_file_watcher_Changed);
      fw3.Deleted += new FileSystemEventHandler(_file_watcher_Deleted);
      fw3.Created += new FileSystemEventHandler(_file_watcher_Created);
      fw3.Renamed += new RenamedEventHandler(_file_watcher_Renamed);
      fw3.Filter = "*.gif";
    }

    private void _file_watcher_Renamed(object sender, RenamedEventArgs e)
    {
      throw new NotImplementedException();
    }

    private void _file_watcher_Created(object sender, FileSystemEventArgs e)
    {
      throw new NotImplementedException();
    }

    private void _file_watcher_Deleted(object sender, FileSystemEventArgs e)
    {
      throw new NotImplementedException();
    }

    private void _file_watcher_Changed(object sender, FileSystemEventArgs e)
    {
      throw new NotImplementedException();
    }


    // 開始監視
    public void startMonitor()
    {
      fw1.EnableRaisingEvents = true;
      fw2.EnableRaisingEvents = true;
      fw3.EnableRaisingEvents = true;
    }
    
    // （靜態方法）第一次使用時，要將所有檔案與目錄掃進資料庫。
    public static bool firstIndex (string rootPathName) {
      DirectoryInfo info = new DirectoryInfo(rootPathName);
      //string[] allDirectories = info.listAll();
      //for (int i = 0; i < allDirectories.Length; i++) {
        // some code here
      //}
      return true;
    }
    
  }
}
