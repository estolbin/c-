using System.Text.Json; 

namespace translate_gui;

public partial class PropForms : Form 
{
    public List<Language> langList {get; set;} = new List<Language>();
    public PropForms()
    {
        InitializeComponents();
    }

    public PropForms(List<Language> list) : this()
    {
        this.langList = list;
        this.listboxLang.Items.AddRange(langList.ToArray());
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        var str = JsonSerializer.Serialize(langList);
        File.WriteAllText("langs.json", str);
        DialogResult = DialogResult.OK;
        this.Close();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        AddForms addForms = new AddForms();
        var lang = addForms.ShowDialog();
        if (lang != null)
        {
            langList.Add(lang);
            listboxLang.Items.Add(lang);
        }
    }
}