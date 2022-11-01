using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;


// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Masterclass.Revit.FourthButton
{
    public sealed partial class DockablePanel : IDockablePaneProvider
    {
        public DockablePanel()
        {
            this.InitializeComponent();
        }

        public void SetupDockablePane(DockablePaneProviderData data)
        {
            data.FrameworkElement = this;
            data.InitialState = new DockablePaneState()
            {
                DockPosition = DockPosition.Tabbed,
                TabBehind = DockablePanes.BuiltInDockablePanes.ProjectBrowser
            };
        }
    }
}
