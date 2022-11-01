using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Masterclass.Revit.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masterclass.Revit.FourthButton
{
    public class DockablePanelViewModel : ViewModelBase
    {
        public RelayCommand LoadRequirements { get; set; }

        public DockablePanelViewModel()
        {
            this.LoadRequirements = new RelayCommand(OnLoadRequirements);
        }

        private void OnLoadRequirements()
        {
            var filePath = DialogUtils.SelectFile();

        }
    }
}
