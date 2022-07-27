namespace catchButton;

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
        // Main menu
        ms = new MenuStrip();
        ToolStripMenuItem newMenu = new ToolStripMenuItem("File");
        ToolStripMenuItem newGame = new ToolStripMenuItem("New game",null, new EventHandler(GameLogic));
        ToolStripMenuItem exit    = new ToolStripMenuItem("Exit"    ,null, new EventHandler(GameLogic));
        newMenu.DropDownItems.Add(newGame);
        newMenu.DropDownItems.Add(exit);
        ms.Items.Add(newMenu);
        ms.Dock = DockStyle.Top;
        this.MainMenuStrip = ms;
        this.Controls.Add(ms);        

        // Progress bar
        this.gameProgress = new ProgressBar();
        this.gameProgress.Location = new Point(10, this.ms.Size.Height + 10);
        this.gameProgress.Size = new Size(380, pbHeight - 10);
        this.gameProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        this.gameProgress.Value = 0;
        this.Controls.Add(gameProgress);


        buttonCatch = new Button();
        buttonCatch.Size = new Size(80, 40);
        buttonCatch.Location = new Point(200, 200);
        buttonCatch.Text = "Catch me";
        buttonCatch.Enabled = false;
        this.Controls.Add(buttonCatch);

        buttonCatch.Click += new EventHandler(buttonCatch_Click);
        this.buttonCatch.MouseHover += new EventHandler(buttonCatch_MouseHover);

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 450);
        this.FormBorderStyle = FormBorderStyle.Fixed3D;
        this.MaximizeBox = false;
        this.Text = "CatchMe";

        this.MouseMove += new MouseEventHandler(Form_OnMouseMove);
    }

    public Button buttonCatch;
    private ProgressBar gameProgress;
    private MenuStrip ms;

    #endregion
}
