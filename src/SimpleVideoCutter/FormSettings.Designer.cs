namespace SimpleVideoCutter
{
    partial class FormSettings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            textBoxOutputFilePattern = new System.Windows.Forms.TextBox();
            comboBoxDefaultDirectory = new System.Windows.Forms.ComboBox();
            textBoxFFmpegPath = new System.Windows.Forms.TextBox();
            textBoxVideoFileExtensions = new System.Windows.Forms.TextBox();
            comboBoxOutputDirectory = new System.Windows.Forms.ComboBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonCancel = new System.Windows.Forms.Button();
            buttonOK = new System.Windows.Forms.Button();
            tabControlSettings = new System.Windows.Forms.TabControl();
            tabFileSystem = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            buttonFFmpegPath = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            buttonDefaultDirectory = new System.Windows.Forms.Button();
            buttonOutputDirectory = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tabWorkflow = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupOriginalFileActions = new System.Windows.Forms.GroupBox();
            buttonOriginalFileTargetDirectory = new System.Windows.Forms.Button();
            textBoxOriginalFileAfterCutAbsoluteTargetDirectory = new System.Windows.Forms.TextBox();
            comboBoxOriginalFileAfterCutRelativeTargetDirectory = new System.Windows.Forms.ComboBox();
            radioMoveOriginalFileToDirectory = new System.Windows.Forms.RadioButton();
            radioMoveOriginalFileToRelativeDirectory = new System.Windows.Forms.RadioButton();
            radioDeleteOriginalFile = new System.Windows.Forms.RadioButton();
            radioKeepOriginalFile = new System.Windows.Forms.RadioButton();
            checkBoxShowQuickSubDirectoryDialog = new System.Windows.Forms.CheckBox();
            tabOther = new System.Windows.Forms.TabPage();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            comboBoxPreviewSize = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            flowLayoutPanel1.SuspendLayout();
            tabControlSettings.SuspendLayout();
            tabFileSystem.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabWorkflow.SuspendLayout();
            groupBox1.SuspendLayout();
            groupOriginalFileActions.SuspendLayout();
            tabOther.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // textBoxOutputFilePattern
            // 
            resources.ApplyResources(textBoxOutputFilePattern, "textBoxOutputFilePattern");
            textBoxOutputFilePattern.Name = "textBoxOutputFilePattern";
            toolTip1.SetToolTip(textBoxOutputFilePattern, resources.GetString("textBoxOutputFilePattern.ToolTip"));
            // 
            // comboBoxDefaultDirectory
            // 
            resources.ApplyResources(comboBoxDefaultDirectory, "comboBoxDefaultDirectory");
            comboBoxDefaultDirectory.FormattingEnabled = true;
            comboBoxDefaultDirectory.Items.AddRange(new object[] { resources.GetString("comboBoxDefaultDirectory.Items"), resources.GetString("comboBoxDefaultDirectory.Items1"), resources.GetString("comboBoxDefaultDirectory.Items2") });
            comboBoxDefaultDirectory.Name = "comboBoxDefaultDirectory";
            toolTip1.SetToolTip(comboBoxDefaultDirectory, resources.GetString("comboBoxDefaultDirectory.ToolTip"));
            // 
            // textBoxFFmpegPath
            // 
            resources.ApplyResources(textBoxFFmpegPath, "textBoxFFmpegPath");
            textBoxFFmpegPath.Name = "textBoxFFmpegPath";
            toolTip1.SetToolTip(textBoxFFmpegPath, resources.GetString("textBoxFFmpegPath.ToolTip"));
            textBoxFFmpegPath.TextChanged += textBoxFFmpegPath_TextChanged;
            // 
            // textBoxVideoFileExtensions
            // 
            resources.ApplyResources(textBoxVideoFileExtensions, "textBoxVideoFileExtensions");
            textBoxVideoFileExtensions.Name = "textBoxVideoFileExtensions";
            textBoxVideoFileExtensions.ReadOnly = true;
            toolTip1.SetToolTip(textBoxVideoFileExtensions, resources.GetString("textBoxVideoFileExtensions.ToolTip"));
            // 
            // comboBoxOutputDirectory
            // 
            resources.ApplyResources(comboBoxOutputDirectory, "comboBoxOutputDirectory");
            comboBoxOutputDirectory.FormattingEnabled = true;
            comboBoxOutputDirectory.Items.AddRange(new object[] { resources.GetString("comboBoxOutputDirectory.Items"), resources.GetString("comboBoxOutputDirectory.Items1"), resources.GetString("comboBoxOutputDirectory.Items2"), resources.GetString("comboBoxOutputDirectory.Items3") });
            comboBoxOutputDirectory.Name = "comboBoxOutputDirectory";
            toolTip1.SetToolTip(comboBoxOutputDirectory, resources.GetString("comboBoxOutputDirectory.ToolTip"));
            comboBoxOutputDirectory.TextChanged += comboBoxOutputDirectory_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Controls.Add(buttonOK);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(buttonCancel, "buttonCancel");
            buttonCancel.Name = "buttonCancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            resources.ApplyResources(buttonOK, "buttonOK");
            buttonOK.Name = "buttonOK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // tabControlSettings
            // 
            tabControlSettings.Controls.Add(tabFileSystem);
            tabControlSettings.Controls.Add(tabWorkflow);
            tabControlSettings.Controls.Add(tabOther);
            resources.ApplyResources(tabControlSettings, "tabControlSettings");
            tabControlSettings.Name = "tabControlSettings";
            tabControlSettings.SelectedIndex = 0;
            // 
            // tabFileSystem
            // 
            tabFileSystem.Controls.Add(tableLayoutPanel1);
            resources.ApplyResources(tabFileSystem, "tabFileSystem");
            tabFileSystem.Name = "tabFileSystem";
            tabFileSystem.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(comboBoxOutputDirectory, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxVideoFileExtensions, 1, 6);
            tableLayoutPanel1.Controls.Add(buttonFFmpegPath, 2, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(buttonDefaultDirectory, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonOutputDirectory, 2, 1);
            tableLayoutPanel1.Controls.Add(textBoxFFmpegPath, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBoxDefaultDirectory, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxOutputFilePattern, 1, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // buttonFFmpegPath
            // 
            resources.ApplyResources(buttonFFmpegPath, "buttonFFmpegPath");
            buttonFFmpegPath.Name = "buttonFFmpegPath";
            buttonFFmpegPath.UseVisualStyleBackColor = true;
            buttonFFmpegPath.Click += buttonFFmpegPath_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // buttonDefaultDirectory
            // 
            resources.ApplyResources(buttonDefaultDirectory, "buttonDefaultDirectory");
            buttonDefaultDirectory.Name = "buttonDefaultDirectory";
            buttonDefaultDirectory.UseVisualStyleBackColor = true;
            buttonDefaultDirectory.Click += buttonDefaultDirectory_Click;
            // 
            // buttonOutputDirectory
            // 
            resources.ApplyResources(buttonOutputDirectory, "buttonOutputDirectory");
            buttonOutputDirectory.Name = "buttonOutputDirectory";
            buttonOutputDirectory.UseVisualStyleBackColor = true;
            buttonOutputDirectory.Click += buttonOutputDirectory_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // tabWorkflow
            // 
            tabWorkflow.Controls.Add(groupBox1);
            resources.ApplyResources(tabWorkflow, "tabWorkflow");
            tabWorkflow.Name = "tabWorkflow";
            tabWorkflow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupOriginalFileActions);
            groupBox1.Controls.Add(checkBoxShowQuickSubDirectoryDialog);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupOriginalFileActions
            // 
            groupOriginalFileActions.Controls.Add(buttonOriginalFileTargetDirectory);
            groupOriginalFileActions.Controls.Add(textBoxOriginalFileAfterCutAbsoluteTargetDirectory);
            groupOriginalFileActions.Controls.Add(comboBoxOriginalFileAfterCutRelativeTargetDirectory);
            groupOriginalFileActions.Controls.Add(radioMoveOriginalFileToDirectory);
            groupOriginalFileActions.Controls.Add(radioMoveOriginalFileToRelativeDirectory);
            groupOriginalFileActions.Controls.Add(radioDeleteOriginalFile);
            groupOriginalFileActions.Controls.Add(radioKeepOriginalFile);
            resources.ApplyResources(groupOriginalFileActions, "groupOriginalFileActions");
            groupOriginalFileActions.Name = "groupOriginalFileActions";
            groupOriginalFileActions.TabStop = false;
            // 
            // buttonOriginalFileTargetDirectory
            // 
            resources.ApplyResources(buttonOriginalFileTargetDirectory, "buttonOriginalFileTargetDirectory");
            buttonOriginalFileTargetDirectory.Name = "buttonOriginalFileTargetDirectory";
            buttonOriginalFileTargetDirectory.UseVisualStyleBackColor = true;
            buttonOriginalFileTargetDirectory.Click += buttonOriginalFileTargetDirectory_Click;
            // 
            // textBoxOriginalFileAfterCutAbsoluteTargetDirectory
            // 
            resources.ApplyResources(textBoxOriginalFileAfterCutAbsoluteTargetDirectory, "textBoxOriginalFileAfterCutAbsoluteTargetDirectory");
            textBoxOriginalFileAfterCutAbsoluteTargetDirectory.Name = "textBoxOriginalFileAfterCutAbsoluteTargetDirectory";
            // 
            // comboBoxOriginalFileAfterCutRelativeTargetDirectory
            // 
            comboBoxOriginalFileAfterCutRelativeTargetDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBoxOriginalFileAfterCutRelativeTargetDirectory.FormattingEnabled = true;
            resources.ApplyResources(comboBoxOriginalFileAfterCutRelativeTargetDirectory, "comboBoxOriginalFileAfterCutRelativeTargetDirectory");
            comboBoxOriginalFileAfterCutRelativeTargetDirectory.Name = "comboBoxOriginalFileAfterCutRelativeTargetDirectory";
            // 
            // radioMoveOriginalFileToDirectory
            // 
            resources.ApplyResources(radioMoveOriginalFileToDirectory, "radioMoveOriginalFileToDirectory");
            radioMoveOriginalFileToDirectory.Name = "radioMoveOriginalFileToDirectory";
            radioMoveOriginalFileToDirectory.Tag = "move_original_file_to_directory";
            radioMoveOriginalFileToDirectory.UseVisualStyleBackColor = true;
            // 
            // radioMoveOriginalFileToRelativeDirectory
            // 
            resources.ApplyResources(radioMoveOriginalFileToRelativeDirectory, "radioMoveOriginalFileToRelativeDirectory");
            radioMoveOriginalFileToRelativeDirectory.Name = "radioMoveOriginalFileToRelativeDirectory";
            radioMoveOriginalFileToRelativeDirectory.Tag = "move_original_file_to_relative_directory";
            radioMoveOriginalFileToRelativeDirectory.UseVisualStyleBackColor = true;
            // 
            // radioDeleteOriginalFile
            // 
            resources.ApplyResources(radioDeleteOriginalFile, "radioDeleteOriginalFile");
            radioDeleteOriginalFile.Name = "radioDeleteOriginalFile";
            radioDeleteOriginalFile.Tag = "delete_original_file";
            radioDeleteOriginalFile.UseVisualStyleBackColor = true;
            // 
            // radioKeepOriginalFile
            // 
            resources.ApplyResources(radioKeepOriginalFile, "radioKeepOriginalFile");
            radioKeepOriginalFile.Checked = true;
            radioKeepOriginalFile.Name = "radioKeepOriginalFile";
            radioKeepOriginalFile.TabStop = true;
            radioKeepOriginalFile.Tag = "keep";
            radioKeepOriginalFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowQuickSubDirectoryDialog
            // 
            resources.ApplyResources(checkBoxShowQuickSubDirectoryDialog, "checkBoxShowQuickSubDirectoryDialog");
            checkBoxShowQuickSubDirectoryDialog.Name = "checkBoxShowQuickSubDirectoryDialog";
            checkBoxShowQuickSubDirectoryDialog.UseVisualStyleBackColor = true;
            // 
            // tabOther
            // 
            tabOther.Controls.Add(tableLayoutPanel2);
            resources.ApplyResources(tabOther, "tabOther");
            tabOther.Name = "tabOther";
            tabOther.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(comboBoxPreviewSize, 1, 0);
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // comboBoxPreviewSize
            // 
            resources.ApplyResources(comboBoxPreviewSize, "comboBoxPreviewSize");
            comboBoxPreviewSize.DisplayMember = "Title";
            comboBoxPreviewSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxPreviewSize.FormattingEnabled = true;
            comboBoxPreviewSize.Name = "comboBoxPreviewSize";
            comboBoxPreviewSize.ValueMember = "Value";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // FormSettings
            // 
            AcceptButton = buttonOK;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonCancel;
            Controls.Add(tabControlSettings);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSettings";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += FormSettings_Load;
            flowLayoutPanel1.ResumeLayout(false);
            tabControlSettings.ResumeLayout(false);
            tabFileSystem.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabWorkflow.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupOriginalFileActions.ResumeLayout(false);
            groupOriginalFileActions.PerformLayout();
            tabOther.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabWorkflow;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxPreviewSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabFileSystem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxOutputDirectory;
        private System.Windows.Forms.TextBox textBoxVideoFileExtensions;
        private System.Windows.Forms.Button buttonFFmpegPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDefaultDirectory;
        private System.Windows.Forms.Button buttonOutputDirectory;
        private System.Windows.Forms.TextBox textBoxFFmpegPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDefaultDirectory;
        private System.Windows.Forms.TextBox textBoxOutputFilePattern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxShowQuickSubDirectoryDialog;
        private System.Windows.Forms.GroupBox groupOriginalFileActions;
        private System.Windows.Forms.RadioButton radioDeleteOriginalFile;
        private System.Windows.Forms.RadioButton radioKeepOriginalFile;
        private System.Windows.Forms.RadioButton radioMoveOriginalFileToRelativeDirectory;
        private System.Windows.Forms.RadioButton radioMoveOriginalFileToDirectory;
        private System.Windows.Forms.ComboBox comboBoxOriginalFileAfterCutRelativeTargetDirectory;
        private System.Windows.Forms.TextBox textBoxOriginalFileAfterCutAbsoluteTargetDirectory;
        private System.Windows.Forms.Button buttonOriginalFileTargetDirectory;
    }
}