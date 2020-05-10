namespace TddXt.TrxConverter.Xml
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunUnitTestTestMethod
  {

    private string codeBaseField;

    private string adapterTypeNameField;

    private string classNameField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeBase
    {
      get
      {
        return this.codeBaseField;
      }
      set
      {
        this.codeBaseField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string adapterTypeName
    {
      get
      {
        return this.adapterTypeNameField;
      }
      set
      {
        this.adapterTypeNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string className
    {
      get
      {
        return this.classNameField;
      }
      set
      {
        this.classNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }
}