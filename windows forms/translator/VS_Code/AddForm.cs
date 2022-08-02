namespace translate_gui;

public partial class AddForms : Form 
{
    private Language  lang {get; set;}
    public AddForms()
    {
        InitializeComponents();
    }

    public new Language ShowDialog()
    {
        base.ShowDialog();
        return lang;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        lang = new Language();
        lang.Describe = this.textBoxDescribe.Text;
        lang.CharCode = this.textBoxCharCode.Text;
        this.Close();
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}