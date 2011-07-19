using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace photobox_alpha
{
  class FileWatcher
  {
    public void FileWatcher(string dirPath)
    {
      FileSystemWatcher fw = new FileSystemWatcher();
      fw.Changed += new FileSystemEventHandler(_file_watcher_Changed);
      fw.Deleted += new FileSystemEventHandler(_file_watcher_Deleted);
      fw.Created += new FileSystemEventHandler(_file_watcher_Created);
      fw.Renamed += new RenamedEventHandler(_file_watcher_Renamed);
    }

    void _file_watcher_Renamed(object sender, RenamedEventArgs e)
    {
      throw new NotImplementedException();
    }

    void _file_watcher_Created(object sender, FileSystemEventArgs e)
    {
      throw new NotImplementedException();
    }

    void _file_watcher_Deleted(object sender, FileSystemEventArgs e)
    {
      throw new NotImplementedException();
    }

    void _file_watcher_Changed(object sender, FileSystemEventArgs e)
    {
      throw new NotImplementedException();
    }

    public void startMonitor()
    {
    }

    
  }
}
