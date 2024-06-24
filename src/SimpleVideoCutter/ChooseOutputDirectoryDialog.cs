using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace SimpleVideoCutter
{
    public partial class ChooseOutputDirectory : Form
    {
        private FFmpegTask task;

        private bool isEditMode = false;

        private readonly int numberOfSubDirectories = 9;

        private readonly string explanationInEditMode = "Stop editing to activate the functionality of this dialog.";

        private readonly string explanationStandard;

        private readonly string originalOutputDir;

        public FFmpegTask Task { get => task; }

        public ChooseOutputDirectory(FFmpegTask task)
        {
            InitializeComponent();
            this.task = task;

            this.GenerateControls();
            this.explanationStandard = labelDialogExplanation.Text;
            this.originalOutputDir = Path.GetDirectoryName(this.task.OutputFilePath);
            this.labelPath.Text = this.labelPath.Text = "\"" + this.originalOutputDir + "\"";
        }


        private void ChooseOutputDirectory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.isEditMode || !char.IsAsciiDigit(e.KeyChar))
            {
                return;
            }

            LabelledTextBox labelledTextBox = (LabelledTextBox)panelDirectoryList.Controls[int.Parse(e.KeyChar.ToString()) - 1];
            string subDir = labelledTextBox.TextBox.Text;

            this.task.OutputFilePath = Path.Combine(
                Path.GetDirectoryName(task.OutputFilePath),
                subDir,
                Path.GetFileName(task.OutputFilePath)
            );

            this.Close();
        }


        private void GenerateControls()
        {
            for (int i = 1; i <= this.numberOfSubDirectories; i++)
            {
                var labelledTextBox = new LabelledTextBox(i.ToString(), 20, 440);
                labelledTextBox.BackColor = Color.Transparent;
                labelledTextBox.Dock = DockStyle.Left;
                labelledTextBox.TextBox.Enabled = false;
                // The following two colors are not respected, if the control is disabled.
                labelledTextBox.TextBox.ForeColor = SystemColors.ControlText;
                labelledTextBox.TextBox.BackColor = SystemColors.Window;
                labelledTextBox.TextBox.Text = VideoCutterSettings.Instance.QuickSubDirectories[i - 1];

                panelDirectoryList.Controls.Add(labelledTextBox);
            }
        }

        private void ToggleEditModeButton_Click(object sender, EventArgs e)
        {
            this.isEditMode = !this.isEditMode;

            if (this.isEditMode)
            {
                labelDialogExplanation.Text = this.explanationInEditMode;
                labelPath.Text = String.Empty;
            }
            else // Edit mode was just left, so the settings will be saved now.
            {
                labelDialogExplanation.Text = this.explanationStandard;
                labelPath.Text = "\"" + this.originalOutputDir + "";

                VideoCutterSettings.Instance.QuickSubDirectories = this.panelDirectoryList.Controls.Cast<Control>()
                                       .OfType<LabelledTextBox>()
                                       .Select(labelledTextBox => labelledTextBox.TextBox.Text)
                                       .ToArray();
            }

            this.UpdateInputEditModeStatus();
        }


        private void UpdateInputEditModeStatus()
        {
            this.toggleEditModeButton.Text = this.isEditMode ? "Stop editing" : "Edit directories";

            foreach (LabelledTextBox labelledTextBox in panelDirectoryList.Controls)
            {
                labelledTextBox.TextBox.Enabled = this.isEditMode;
            }
        }
    }
}
