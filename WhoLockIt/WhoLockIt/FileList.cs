using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Mvvm;

namespace WhoLockIt
{
    public class FileList : BindableBase
    {

        #region FileProcesses変更通知プロパティ

        private ObservableCollection<FileProcess> _FileProcesses;
        public ObservableCollection<FileProcess> FileProcesses
        {
            get { return _FileProcesses; }
            set { SetProperty(ref _FileProcesses, value); }
        }

        #endregion

        public FileList()
        {
            _FileProcesses = new ObservableCollection<FileProcess>();
        }
    }
}
