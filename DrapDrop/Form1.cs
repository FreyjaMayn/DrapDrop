using AssmblyControl;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using ToolSignLib;
using UserControlBase;

namespace DrapDrop
{
    public partial class Form1 : Form
    {
        private Rectangle _rect;



        public Form1()
        {
            InitializeComponent();
            LoadToolSign();

        }

        private void LoadToolSign()
        {
            FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();
            var toolTypes = General.Instance.ToolTypes;
            foreach (var toolType in toolTypes)
            {
                string displayName = toolType.Name;
                if (toolType.IsDefined(typeof(DisplayNameAttribute), true))
                {
                    displayName = toolType.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
                }
                var toolSign = new ToolSign(toolType.Name, displayName);
                flowLayoutPanel1.Controls.Add(toolSign);
            }
            flowLayoutPanel1.Dock = DockStyle.Fill;
            panel1.Controls.Add(flowLayoutPanel1);

        }
    }
}