using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssmblyControl;

namespace UserControlBase
{
    public partial class PanelBase : Panel
    {
       


        public List<UserControlBase> ControlList = new List<UserControlBase>();

        public PanelBase()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.UserPaint| ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);
            if ((!drgevent.Data.GetDataPresent(typeof(string)) | ControlList.Count==1))
            {
                drgevent.Effect = DragDropEffects.None;
            }
            else
            {
                drgevent.Effect = DragDropEffects.All | DragDropEffects.Link;
            }
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            base.OnDragDrop(drgevent);
            string toolName = drgevent.Data.GetData(typeof(string)) as string;
            var toolType = General.Instance.ToolTypes.First(t=>t.Name == toolName);
            if (toolType != null)
            {
                object[] param = new object[] { this };
                UserControlBase control = Activator.CreateInstance(toolType, param) as UserControlBase;
                control.Index = 0;
                this.ControlList.Add(control);
                UpDatePanel();
            }
           
        }

        public void UpDatePanel()
        {
            this.Controls.Clear();
            int height = 0;
            for (int i = 0; i < ControlList.Count; i++)
            {
                var control = ControlList[i];
                control.Location = new Point(0, height);
                height += control.Height+2;
                this.Controls.Add(control);
            }
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
            
        //    UpDatePanel();
        //}


    }
}
