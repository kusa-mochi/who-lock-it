using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Mvvm;

namespace WhoLockItGUI
{
    public class MainWindowVM : BindableBase
    {
        #region FileProcessList変更通知プロパティ

        private ObservableCollection<FileProcess> _FileProcessList;
        public ObservableCollection<FileProcess> FileProcessList
        {
            get { return _FileProcessList; }
            set { SetProperty(ref _FileProcessList, value); }
        }

        #endregion

        public MainWindowVM(List<FileProcess> fileList)
        {
#if DEBUG
            MyDebugger.DumpList(fileList);
#endif

            _FileProcessList = new ObservableCollection<FileProcess>(fileList);
        }
    }
}
