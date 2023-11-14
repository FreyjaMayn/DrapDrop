using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolSignLib
{
    public partial class ToolSign : UserControl
    {
        [Browsable(true)]
        [Description("工具图标"), Category("SetPic"), DefaultValue("")]
        public Image ToolPic
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {

                pictureBox1.Image = value;
            }
        }

        private string _toolName;

        private Rectangle _rect;

        public ToolSign()
        {
            InitializeComponent();
            //pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("减号");

        }

        public ToolSign(string imageName, string displayName)
        {
            InitializeComponent();
            this.pictureBox1.MouseDown += new MouseEventHandler((o, e) => { _MouseDown(e); });
            this.pictureBox1.MouseMove += new MouseEventHandler((o, e) => { _MouseMove(e); });
            this.pictureBox1.MouseUp += new MouseEventHandler((o, e) => { _MouseUp(e); });
            this.label1.MouseDown += new MouseEventHandler((o, e) => { _MouseDown(e); });
            this.label1.MouseMove += new MouseEventHandler((o, e) => { _MouseMove(e); });
            this.MouseDown += new MouseEventHandler((o, e) => { _MouseDown(e); });
            _toolName = imageName;
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            label1.Text = displayName;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _MouseDown(e);
           
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            _MouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _MouseUp(e);
        }

        private void _MouseDown(MouseEventArgs e)
        {
            _rect = new Rectangle(new Point(e.X - SystemInformation.DragSize.Width / 2, e.Y - SystemInformation.DragSize.Height / 2)
               , SystemInformation.DragSize);
        }

        private void _MouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_rect != Rectangle.Empty && !_rect.Contains(e.X, e.Y))
                {
                    var effect = DoDragDrop(_toolName, DragDropEffects.All | DragDropEffects.Link);
                }
            }
        }

        private void _MouseUp(MouseEventArgs e)
        {
            _rect = Rectangle.Empty;
        }
    }
}
