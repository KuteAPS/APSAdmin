using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ManagementCore
{
   public class ControllerActions
    {
        public String GetControllerActions(Controller controller)
        {
            Type t = controller.GetType();
            System.Reflection.MethodInfo[] ControllerMethods = t.GetMethods();
            StringBuilder methodsNameAppend = new StringBuilder();
            for (int i = 0; i < ControllerMethods.Length; i++)
            {
                methodsNameAppend.Append(ControllerMethods[i].Name + ";");

            }

            return methodsNameAppend.ToString();
        }
    }
}
