using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlBase
{
    [DisplayName("加法工具")]
    [ToolboxItem(true)]
    public partial class ADDTool : UserControlBase
    {
   

        public ADDTool(PanelBase _panel):base(_panel)
        {
            InitializeComponent();
            panelBase = _panel;
            
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tb_Num1.Text, out double num1))
            {
                MessageBox.Show("Num1 Foramt Error!");
                return;
            }

            if (!double.TryParse(tb_Num2.Text, out double num2))
            {
                MessageBox.Show("Num2 Foramt Error!");
                return;
            }

            tb_Total.Text = (num1 + num2).ToString();
        }
    }
}
