namespace TddXt.TrxConverter.Xml
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunUnitTestResult
  {

    private TestRunUnitTestResultOutput outputField;

    private string executionIdField;

    private string testIdField;

    private string testNameField;

    private string computerNameField;

    private System.DateTime durationField;

    private System.DateTime startTimeField;

    private System.DateTime endTimeField;

    private string testTypeField;

    private string outcomeField;

    private string testListIdField;

    private string relativeResultsDirectoryField;

    /// <remarks/>
    public TestRunUnitTestResultOutput Output
    {
      get
      {
        return this.outputField;
      }
      set
      {
        this.outputField = value;
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
    public string testName
    {
      get
      {
        return this.testNameField;
      }
      set
      {
        this.testNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string computerName
    {
      get
      {
        return this.computerNameField;
      }
      set
      {
        this.computerNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
    public System.DateTime duration
    {
      get
      {
        return this.durationField;
      }
      set
      {
        this.durationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime startTime
    {
      get
      {
        return this.startTimeField;
      }
      set
      {
        this.startTimeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime endTime
    {
      get
      {
        return this.endTimeField;
      }
      set
      {
        this.endTimeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string testType
    {
      get
      {
        return this.testTypeField;
      }
      set
      {
        this.testTypeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string outcome
    {
      get
      {
        return this.outcomeField;
      }
      set
      {
        this.outcomeField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string relativeResultsDirectory
    {
      get
      {
        return this.relativeResultsDirectoryField;
      }
      set
      {
        this.relativeResultsDirectoryField = value;
      }
    }
  }
}