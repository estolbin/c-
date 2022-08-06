using System;
using System.Drawing;
using System.Windows.Forms;

namespace translate_gui
{


partial class PropForms 
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
        this.buttonClose = new Button();
        this.buttonClose.Location = new Point(105, 260);
        this.buttonClose.Text = "Закрыть";
        this.buttonClose.Size = new Size(90, 30);
        this.buttonClose.Click += new EventHandler(buttonClose_Click);

        this.buttonSave = new Button();
        this.buttonSave.Location = new Point(200, 260);
        this.buttonSave.Text = "Сохранить";
        this.buttonSave.Size = new Size(90, 30);
        this.buttonSave.Click += new EventHandler(buttonSave_Click);

        this.labelHeader = new Label();
        this.labelHeader.Location = new Point(10, 10);
        this.labelHeader.Size = new Size(200, 20);
        this.labelHeader.Text = "Список языков :";

        this.buttonAdd = new Button();
        this.buttonAdd.Location = new Point(10, 260);
        this.buttonAdd.Size = new Size(90,30);
        this.buttonAdd.Text = "Добавить";
        this.buttonAdd.Click += new EventHandler(buttonAdd_Click);

        this.listboxLang = new ListBox();
        this.listboxLang.Location = new Point(10, 35);
        this.listboxLang.Size = new Size(280, 200);

        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(300, 300);
        this.Controls.Add(buttonClose);
        this.Controls.Add(buttonSave);
        this.Controls.Add(listboxLang);
        this.Controls.Add(labelHeader);
        this.Controls.Add(buttonAdd);
        this.Name = "PropForms";
        this.Text = "Properties";
        this.MinimizeBox = false;
        this.MaximizeBox = false;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.ResumeLayout();
        this.PerformLayout();
    }
    #endregion
    private ListBox listboxLang;
    private Button buttonSave;
    private Button buttonClose;
    private Button buttonAdd;
    private Label labelHeader;
}
}