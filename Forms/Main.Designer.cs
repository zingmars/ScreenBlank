
namespace ScreenBlank
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScreenList = new System.Windows.Forms.CheckedListBox();
            this.BlankButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScreenList
            // 
            this.ScreenList.FormattingEnabled = true;
            this.ScreenList.Location = new System.Drawing.Point(12, 12);
            this.ScreenList.Name = "ScreenList";
            this.ScreenList.Size = new System.Drawing.Size(256, 148);
            this.ScreenList.TabIndex = 0;
            // 
            // BlankButton
            // 
            this.BlankButton.Location = new System.Drawing.Point(11, 178);
            this.BlankButton.Name = "BlankButton";
            this.BlankButton.Size = new System.Drawing.Size(257, 23);
            this.BlankButton.TabIndex = 1;
            this.BlankButton.Text = "Blank";
            this.BlankButton.UseVisualStyleBackColor = true;
            this.BlankButton.Click += new System.EventHandler(this.BlankButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(11, 207);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(257, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 242);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BlankButton);
            this.Controls.Add(this.ScreenList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Screen blanker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ScreenList;
        private System.Windows.Forms.Button BlankButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

