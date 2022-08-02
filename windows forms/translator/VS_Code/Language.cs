namespace translate_gui;

[Serializable]
public class Language
{
    public string Describe { get; set; }
    public string CharCode { get; set; }

    public override string ToString()
    {
        return $"{Describe}";
    }
}
