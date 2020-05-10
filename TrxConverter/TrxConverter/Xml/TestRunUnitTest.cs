namespace TddXt.TrxConverter.Xml
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunUnitTest
  {

    private TestRunUnitTestExecution executionField;

    private TestRunUnitTestTestMethod testMethodField;

    private string nameField;

    private string storageField;

    private string idField;

    /// <remarks/>
    public TestRunUnitTestExecution Execution
    {
      get
      {
        return this.executionField;
      }
      set
      {
        this.executionField = value;
      }
    }

    /// <remarks/>
    public TestRunUnitTestTestMethod TestMethod
    {
      get
      {
        return this.testMethodField;
      }
      set
      {
        this.testMethodField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string storage
    {
      get
      {
        return this.storageField;
      }
      set
      {
        this.storageField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }
  }
}