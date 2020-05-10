namespace TddXt.TrxConverter.Xml
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunTestEntry
  {

    private string testIdField;

    private string executionIdField;

    private string testListIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string testId
    {
      get
      {
        return this.testIdField;
      }
      set
      {
        this.testIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string executionId
    {
      get
      {
        return this.executionIdField;
      }
      set
      {
        this.executionIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string testListId
    {
      get
      {
        return this.testListIdField;
      }
      set
      {
        this.testListIdField = value;
      }
    }
  }
}