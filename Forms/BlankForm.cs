using System.Drawing;
using System.Windows.Forms;

namespace ScreenBlank.Forms
{
    public partial class BlankForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        public BlankForm(Screen screen)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(screen.Bounds.X, screen.Bounds.Y);

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.Size = new Size(screen.Bounds.Width, screen.Bounds.Height);
        }
    }
}
