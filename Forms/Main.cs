using ScreenBlank.Forms;
using System;
using System.Windows.Forms;

namespace ScreenBlank
{
    public partial class Main : Form
    {
        Screen[] screens = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.screens = Screen.AllScreens;

            foreach (var screen in screens)
            {
                string fullname = String.Format("{0}{1} - {2}x{3} at {4};{5}", screen.DeviceName, screen.Primary ? "(*)" : "", screen.Bounds.Width, screen.Bounds.Height, screen.Bounds.X, screen.Bounds.Y);
                ScreenList.Items.Add(fullname, CheckState.Unchecked);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BlankButton_Click(object sender, EventArgs e)
        {
            foreach (int checkedIndex in ScreenList.CheckedIndices)
            {
                BlankForm form = new BlankForm(screens[checkedIndex]);
                form.Show();
            }
            //BlankButton.Enabled = false;
        }
    }
}
