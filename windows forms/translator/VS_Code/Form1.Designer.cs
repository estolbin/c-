namespace translate_gui;

partial class Form1
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
        this.buttonTranlsate = new Button();
        this.buttonClose = new Button();
        this.comboBoxInputLang = new ComboBox();
        this.comboBoxOutputLang = new ComboBox();
        this.inputTextBox = new TextBox();
        this.outputTextBox = new TextBox();
        this.SuspendLayout();

        this.buttonTranlsate.Location = new Point(290, 410);
        this.buttonTranlsate.Size = new Size(100, 30);
        this.buttonTranlsate.Text = "Перевод";
        this.buttonTranlsate.Click += new EventHandler(this.buttonTranlsate_Click);

        this.comboBoxInputLang.Location = new Point(10, 30);

        this.comboBoxOutputLang.Location = new Point(400, 30);

        this.inputTextBox = new TextBox();
        this.inputTextBox.Location = new Point(10, 60);
        this.inputTextBox.Multiline = true;
        this.inputTextBox.Size = new Size(380, 340);
        this.inputTextBox.Text = inHelpString;
        this.inputTextBox.GotFocus += new EventHandler(intpuTextBox_Click);


        this.outputTextBox = new TextBox();
        this.outputTextBox.Location = new Point(400, 60);
        this.outputTextBox.Multiline = true;
        this.outputTextBox.Size = new Size(380, 340);
        this.outputTextBox.Text = outHelpString;
        this.outputTextBox.Click += new EventHandler(outputTextBox_Click);
        this.outputTextBox.ReadOnly = true;


        this.buttonClose.Location = new Point(400, 410);
        this.buttonClose.Size = new Size(100, 30);
        this.buttonClose.Text = "Закрыть";
        this.buttonClose.GotFocus += new EventHandler(this.buttonClose_Click);


        this.MainMenuStrip = CreateMenuStrip();

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.buttonTranlsate);
        this.Controls.Add(this.buttonClose);
        this.Controls.Add(this.comboBoxInputLang);
        this.Controls.Add(this.comboBoxOutputLang);
        this.Controls.Add(this.inputTextBox);
        this.Controls.Add(this.outputTextBox);
        this.Controls.Add(this.ms);
        this.Text = "Переводчик";
    }

    #endregion

    private MenuStrip CreateMenuStrip()
    {
        this.ms = new MenuStrip();
        ToolStripMenuItem newMenu = new ToolStripMenuItem("File");
        ToolStripMenuItem propMenu = new ToolStripMenuItem("Properties",null,new EventHandler(propMenu_Click));
        ToolStripMenuItem exitMenu = new ToolStripMenuItem("Exit", null, new EventHandler(exitMenu_Click));
        newMenu.DropDownItems.Add(propMenu);
        newMenu.DropDownItems.Add(exitMenu);

        ToolStripMenuItem aboutMenu = new ToolStripMenuItem("About", null, new EventHandler(menuAbout_Click));
        ms.Items.Add(newMenu);
        ms.Items.Add(aboutMenu);
        ms.Dock = DockStyle.Top;
        return ms;
    }

    private Button buttonTranlsate;
    private Button buttonClose;
    private TextBox inputTextBox;
    private TextBox outputTextBox;
    private ComboBox comboBoxInputLang;
    private ComboBox comboBoxOutputLang;
    private MenuStrip ms;

}
