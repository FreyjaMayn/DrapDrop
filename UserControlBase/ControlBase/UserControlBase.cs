using AssmblyControl;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UserControlBase
{
    [ToolboxItem(false)]
    public class UserControlBase : UserControl
    {
        [Browsable(false)]
        public string ToolName { get; set; } = string.Empty;

        [Browsable(false)]
        public int Index {  get; set; }

        protected PanelBase panelBase { get; set; }

        public UserControlBase()
        {

        }

        public UserControlBase(PanelBase _panel)
        {
           this.AllowDrop= true;
        }


        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);
            if (panelBase == null | !drgevent.Data.GetDataPresent(typeof(string)))
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
            var toolType = General.Instance.ToolTypes.First(t => t.Name == toolName);
            if (toolType != null)
            {
                object[] param = new object[] { panelBase };
                UserControlBase control = Activator.CreateInstance(toolType, param) as UserControlBase;
                control.Index = this.Index + 1;
                ReSetIndexOfAll(control.Index);
                panelBase.ControlList.Insert(control.Index,control);                
                panelBase.UpDatePanel();
            }
        }

        /// <summary>
        /// 添加控件后，重新设置新控件之后的Index
        /// </summary>
        /// <param name="index"></param>
        public void ReSetIndexOfAll(int index)
        {
            for (int i = index; i < panelBase.ControlList.Count; i++)
            {
                panelBase.ControlList[i].Index= i + 1;
            }
        }
    }
}