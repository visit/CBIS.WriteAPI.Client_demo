using System;
using System.Collections.Generic;
using System.Text;

namespace CBISimpaler.Models
{
    class Class1
    {
    }
}




public class Attribute
{
    public int AttributId { get; set; }
    public bool LanguageInvariant { get; set; }
    public bool AllowHtml { get; set; }
    public Translations Translations { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
}

public class Translations
{
    public string Title { get; set; }
    public string Value { get; set; }
}
