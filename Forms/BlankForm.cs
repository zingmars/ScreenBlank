using System.Drawing;
using System.Windows.Forms;

namespace ScreenBlank.Forms
{
    public partial class BlankForm : Form
    {
        public BlankForm(Screen screen)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(screen.Bounds.X, screen.Bounds.Y);

            InitializeComponent();

            this.Size = new Size(screen.Bounds.Width, screen.Bounds.Height);
        }
    }
}
