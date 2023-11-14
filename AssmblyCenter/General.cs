using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssmblyControl
{
    public class General
    {
        public  Assembly ToolAssmbly;

        public  List<string> ToolNames;

        public  List<Type> ToolTypes;

        private General()
        {
            ToolAssmbly = Assembly.Load("ToolLib");
            ToolTypes = ToolAssmbly.GetTypes().Where(x=>x.IsPublic).ToList();
            ToolNames = ToolAssmbly.GetTypes().Select(x => x.FullName).ToList();

        }

        public static General Instance=>new General();
    }
}
