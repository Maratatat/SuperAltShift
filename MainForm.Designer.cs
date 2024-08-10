namespace SuperAltShift
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            Title = new Label();
            Close_button = new Button();
            Description_Label = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            autostartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            Sorce_Code_Button = new Button();
            Key_Label = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(132, 9);
            Title.Margin = new Padding(0);
            Title.Name = "Title";
            Title.RightToLeft = RightToLeft.No;
            Title.Size = new Size(267, 50);
            Title.TabIndex = 0;
            Title.Text = "Super Alt Shift";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Close_button
            // 
            Close_button.BackColor = Color.FromArgb(45, 45, 45);
            Close_button.FlatAppearance.BorderSize = 0;
            Close_button.FlatStyle = FlatStyle.Flat;
            Close_button.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_button.ForeColor = Color.White;
            Close_button.Location = new Point(485, 0);
            Close_button.Margin = new Padding(0);
            Close_button.Name = "Close_button";
            Close_button.Size = new Size(45, 30);
            Close_button.TabIndex = 1;
            Close_button.TabStop = false;
            Close_button.Text = "X";
            Close_button.UseVisualStyleBackColor = true;
            Close_button.Click += Close_button_Click;
            Close_button.MouseEnter += Close_button_MouseEnter;
            Close_button.MouseLeave += Close_button_MouseLeave;
            // 
            // Description_Label
            // 
            Description_Label.AutoSize = true;
            Description_Label.BackColor = Color.FromArgb(45, 45, 45);
            Description_Label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Description_Label.Location = new Point(31, 121);
            Description_Label.Name = "Description_Label";
            Description_Label.Size = new Size(459, 42);
            Description_Label.TabIndex = 2;
            Description_Label.Text = "Just select the text and replace it with the language you need \r\nby pressing";
            Description_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem, autostartToolStripMenuItem, exitToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(124, 70);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(123, 22);
            exitToolStripMenuItem.Text = "Open";
            // 
            // autostartToolStripMenuItem
            // 
            autostartToolStripMenuItem.Checked = true;
            autostartToolStripMenuItem.CheckState = CheckState.Checked;
            autostartToolStripMenuItem.Name = "autostartToolStripMenuItem";
            autostartToolStripMenuItem.Size = new Size(123, 22);
            autostartToolStripMenuItem.Text = "Autostart";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(123, 22);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // Sorce_Code_Button
            // 
            Sorce_Code_Button.FlatAppearance.BorderSize = 0;
            Sorce_Code_Button.FlatStyle = FlatStyle.Flat;
            Sorce_Code_Button.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sorce_Code_Button.ForeColor = Color.FromArgb(122, 174, 222);
            Sorce_Code_Button.Location = new Point(206, 236);
            Sorce_Code_Button.Name = "Sorce_Code_Button";
            Sorce_Code_Button.Size = new Size(118, 36);
            Sorce_Code_Button.TabIndex = 5;
            Sorce_Code_Button.Tag = "https://github.com/Maratatat/SuperAltShift";
            Sorce_Code_Button.Text = "Source Code";
            Sorce_Code_Button.UseVisualStyleBackColor = true;
            Sorce_Code_Button.Click += Sorce_Code_Button_Click;
            // 
            // Key_Label
            // 
            Key_Label.AutoSize = true;
            Key_Label.BackColor = Color.FromArgb(66, 69, 72);
            Key_Label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Key_Label.Location = new Point(171, 172);
            Key_Label.Name = "Key_Label";
            Key_Label.Size = new Size(189, 25);
            Key_Label.TabIndex = 3;
            Key_Label.Text = "CTRL + ALT + SHIFT";
            Key_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(530, 320);
            Controls.Add(Sorce_Code_Button);
            Controls.Add(Key_Label);
            Controls.Add(Description_Label);
            Controls.Add(Close_button);
            Controls.Add(Title);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuperAltShift";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button Close_button;
        private Label Description_Label;
        private Label label2;
        private Panel panel1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem autostartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Button Sorce_Code_Button;
        private Label Key_Label;
    }
}
