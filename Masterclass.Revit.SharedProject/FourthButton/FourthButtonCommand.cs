using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Masterclass.Revit.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Masterclass.Revit.FourthButton
{
    public class FourthButtonCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                var app = commandData.Application;
                DockablePanelUtil.ShowDockablePanel(app);

            }
            catch (Exception)
            {

                return Result.Failed;
            }
            return Result.Succeeded;

        }

        public static void CreateButton(RibbonPanel panel)
        {
            var assem = Assembly.GetExecutingAssembly();
            panel.AddItem(
                new PushButtonData(
                    MethodBase.GetCurrentMethod()?.DeclaringType?.Name,
                    "Fourth" + Environment.NewLine + "Button",
                    assem.Location, 
                    MethodBase.GetCurrentMethod()?.DeclaringType?.FullName)
                {
                     ToolTip = "Fourth button tooltip",
                      LargeImage = ImageUtils.LoadImage(assem, "_32x32.secondButton.png")
                });

        }
    }
}
