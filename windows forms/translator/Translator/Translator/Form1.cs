using System.ComponentModel;
using System.Web;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace translate_gui
{


public partial class Form1 : Form
{
    private const string inHelpString = "Скопируйте сюда, или введите текст для перевода...";
    private const string outHelpString = "Здесь будет переведенный текст...";
    public List<Language> langList { get; set; } = new List<Language>();
    public Form1()
    {
        InitializeComponent();

        LoadLangList();
        if (langList == null || langList.Count == 0)
        {
            langList = new List<Language>()
            {
                new Language {Describe = "Английский", CharCode = "en"},
                new Language {Describe = "Русский", CharCode = "ru"}
            };
        }

        UpdateLangList();
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void buttonTranlsate_Click(object sender, EventArgs e)
    {
        // var inputLang  = (Langs) this.comboBoxInputLang.SelectedItem;
        // var outputLang = (Langs) this.comboBoxOutputLang.SelectedItem;
        var inputLang = this.comboBoxInputLang.SelectedItem as Language;
        var outputLang = this.comboBoxOutputLang.SelectedItem as Language;
        Translator tr  = new Translator {FromLanguage = inputLang, ToLanguage = outputLang, InputText = this.inputTextBox.Text};
        this.outputTextBox.ResetText();
        this.outputTextBox.Text = tr.TranslateText();
    }

    private void UpdateLangList()
    {

        this.comboBoxInputLang.Items.Clear();
        this.comboBoxOutputLang.Items.Clear();

        this.comboBoxInputLang.Items.AddRange(langList.ToArray());
        this.comboBoxInputLang.SelectedIndex = 0;
        this.comboBoxOutputLang.Items.AddRange(langList.ToArray());
        this.comboBoxOutputLang.SelectedIndex = 1;
    }

    private void menuAbout_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Простой переводчик с использование google api","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
    }
    private void exitMenu_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void propMenu_Click(object sender, EventArgs e)
    {
        // открыть форму добавления языка.
        PropForms propForm = new PropForms(langList);
        var result = propForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            LoadLangList();
            UpdateLangList();
        }


    }

    private void intpuTextBox_Click(object sender, EventArgs e)
    {
        if (this.inputTextBox.Text.Equals(inHelpString)) 
            this.inputTextBox.ResetText();
    }
    private void outputTextBox_Click(object sender, EventArgs e)
    {
        if (this.outputTextBox.Text.Equals(outHelpString))
            this.outputTextBox.ResetText();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        SaveLandList();
        base.OnClosing(e);
    }

    private void SaveLandList()
    {
        var str = JsonSerializer.Serialize(langList);
        File.WriteAllText("langs.json", str);
    }

    private void LoadLangList()
    {
        if (File.Exists("langs.json"))
        {
            var json = File.ReadAllText("langs.json");
            langList = JsonSerializer.Deserialize<List<Language>>(json);
        }
    }
}

}