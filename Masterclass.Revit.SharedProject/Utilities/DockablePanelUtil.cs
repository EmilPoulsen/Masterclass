using Autodesk.Revit.UI;
using Masterclass.Revit.FourthButton;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace Masterclass.Revit.Utilities
{
    public static class DockablePanelUtil
    {
        public static void RegisterDockablePanel(UIControlledApplication a)
        {
            var vm = new DockablePanelViewModel();
            var v = new DockablePanelPage()
            {
                DataContext = vm
            };
            var panelId = new DockablePaneId(new Guid("16a7f098-59be-4d50-b6fd-8c3d40a27c34"));

            a.RegisterDockablePane(panelId, "MasterClass", v);
        }

        public static void ShowDockablePanel(UIApplication app)
        {
            var panelId = new DockablePaneId(new Guid("16a7f098-59be-4d50-b6fd-8c3d40a27c34"));
            var dp = app.GetDockablePane(panelId);
            if(dp != null && !dp.IsShown())
            {
                dp.Show(); 
            }
        }
    }
}