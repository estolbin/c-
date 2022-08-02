namespace translate_gui;

partial class AddForms 
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windos Form Designer
    private void InitializeComponents()
    {
        this.labelCharCode = new Label();
        this.labelDescribe = new Label();
        this.textBoxCharCode = new TextBox();
        this.textBoxDescribe = new TextBox();
        this.buttonClose = new Button();
        this.buttonSave = new Button();

        this.labelDescribe.Text = "Название : ";
        this.labelDescribe.Location = new Point(10, 13);
        this.labelDescribe.Size = new Size(65, 15);

        this.textBoxDescribe.Location = new Point(100, 10);
        this.textBoxDescribe.Size = new Size(180, 10);

        this.labelCharCode.Text = "Код :";
        this.labelCharCode.Location = new Point(10, 43);
        this.labelCharCode.Size = new Size(65, 15);

        this.textBoxCharCode.Location = new Point(100, 40);
        this.textBoxCharCode.Size = new Size(180, 10);

        this.buttonSave.Location = new Point(10, 80);
        this.buttonSave.Text = "Ок";
        this.buttonSave.Size = new Size(100, 30);
        this.buttonSave.Click += new EventHandler(buttonSave_Click);

        this.buttonClose.Location = new Point(120, 80);
        this.buttonClose.Text = "Отмена";
        this.buttonClose.Size = new Size(100, 30);
        this.buttonClose.Click += new EventHandler(buttonClose_Click);

        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(300, 120);
        this.Name = "AddForms";
        this.Text = "Add lang";
        this.Controls.Add(labelDescribe);
        this.Controls.Add(labelCharCode);
        this.Controls.Add(textBoxCharCode);
        this.Controls.Add(textBoxDescribe);
        this.Controls.Add(buttonClose);
        this.Controls.Add(buttonSave);
        this.MinimizeBox = false;
        this.MaximizeBox = false;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.ResumeLayout();
        this.PerformLayout();
    }
    #endregion

    private Label labelDescribe;
    private Label labelCharCode;
    private TextBox textBoxDescribe;
    private TextBox textBoxCharCode;
    private Button buttonSave;
    private Button buttonClose;
}