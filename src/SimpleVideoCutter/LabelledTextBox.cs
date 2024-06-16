using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class LabelledTextBox : FlowLayoutPanel
{
    public Label Label { get; private set; }
    public TextBox TextBox { get; private set; }

    public LabelledTextBox(string labelText)
    {
        this.FlowDirection = FlowDirection.LeftToRight;
        this.WrapContents = false;

        Label = new Label() { Text = labelText, TextAlign = ContentAlignment.MiddleLeft };
        Label.Width = 20;
        TextBox = new TextBox();
        TextBox.Width = 400;

        // Set the size of the panel to accommodate both label and textbox
        Size = new Size(Label.Width + TextBox.Width, Math.Max(Label.Height, TextBox.Height));

        Controls.AddRange(new Control[] { Label, TextBox });
        Label.Dock = DockStyle.None;
        TextBox.Dock = DockStyle.Fill;
    }
}
