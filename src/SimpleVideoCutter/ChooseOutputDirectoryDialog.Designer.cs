namespace SimpleVideoCutter
{
    partial class ChooseOutputDirectory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelDirectoryList = new System.Windows.Forms.FlowLayoutPanel();
            labelDialogExplanation = new System.Windows.Forms.Label();
            labelPath = new System.Windows.Forms.Label();
            toggleEditModeButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // panelDirectoryList
            // 
            panelDirectoryList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelDirectoryList.AutoSize = true;
            panelDirectoryList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            panelDirectoryList.Location = new System.Drawing.Point(0, 73);
            panelDirectoryList.MinimumSize = new System.Drawing.Size(100, 100);
            panelDirectoryList.Name = "panelDirectoryList";
            panelDirectoryList.Size = new System.Drawing.Size(745, 378);
            panelDirectoryList.TabIndex = 10;
            // 
            // labelDialogExplanation
            // 
            labelDialogExplanation.AutoSize = true;
            labelDialogExplanation.Dock = System.Windows.Forms.DockStyle.Left;
            labelDialogExplanation.Location = new System.Drawing.Point(0, 0);
            labelDialogExplanation.Name = "labelDialogExplanation";
            labelDialogExplanation.Size = new System.Drawing.Size(530, 20);
            labelDialogExplanation.TabIndex = 11;
            labelDialogExplanation.Text = "Press a number key to output the video into the corresponding subdirectory of ";
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new System.Drawing.Point(0, 20);
            labelPath.Name = "labelPath";
            labelPath.Size = new System.Drawing.Size(0, 20);
            labelPath.TabIndex = 12;
            // 
            // toggleEditModeButton
            // 
            toggleEditModeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            toggleEditModeButton.Location = new System.Drawing.Point(563, 0);
            toggleEditModeButton.Name = "toggleEditModeButton";
            toggleEditModeButton.Size = new System.Drawing.Size(182, 29);
            toggleEditModeButton.TabIndex = 13;
            toggleEditModeButton.Text = "Edit directories";
            toggleEditModeButton.UseVisualStyleBackColor = true;
            toggleEditModeButton.Click += toggleEditModeButton_Click;
            toggleEditModeButton.KeyPress += toggleEditModeButton_KeyPress;
            // 
            // ChooseOutputDirectory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(746, 450);
            Controls.Add(toggleEditModeButton);
            Controls.Add(labelPath);
            Controls.Add(panelDirectoryList);
            Controls.Add(labelDialogExplanation);
            Name = "ChooseOutputDirectory";
            ShowInTaskbar = false;
            Text = "Choose quick subdirectory";
            Load += ChooseOutputDirectory_Load;
            KeyPress += ChooseOutputDirectory_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelDirectoryList;
        private System.Windows.Forms.Label labelDialogExplanation;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button toggleEditModeButton;
    }
}