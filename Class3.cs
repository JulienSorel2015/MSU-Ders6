using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;

//using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
//using Autodesk.Revit.DB.ExtensibleStorage;
using Autodesk.Revit.UI.Selection;

namespace FirstPlugin
{
    class Class3
    {
        
    }
    public class ModelLineSelectionFilter : ISelectionFilter
    {
        
        public bool AllowElement(Element element)
        {
            if ((element.Category.Name == "Lines"))
            {
                return true;
            }
            return false;
        }
        public bool AllowReference(Reference refer, XYZ point)
        {
            return false;
        }
    }
    public class WallSelectionFilter : ISelectionFilter
    {

        public bool AllowElement(Element element)
        {
            //ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Walls);

            //// Apply the filter to the elements in the active document,
            //// Use shortcut WhereElementIsNotElementType() to find wall instances only
            //FilteredElementCollector collector = new FilteredElementCollector(document);
            //IList<Element> walls = collector.WherePasses(filter).WhereElementIsNotElementType().ToElements();

            BuiltInCategory wallCategory = BuiltInCategory.OST_Walls;
           
            if ((element.Category.Name == "Walls"))
            {
                return true;
            }
            return false;
        }
        public bool AllowReference(Reference refer, XYZ point)
        {
            return false;
        }
    }
}
