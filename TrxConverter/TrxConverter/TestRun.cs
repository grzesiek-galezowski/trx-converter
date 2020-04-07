﻿namespace TddXt.TrxConverter
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable = false)]
  public partial class TestRun
  {

    private TestRunTimes timesField;

    private TestRunTestSettings testSettingsField;

    private TestRunUnitTestResult[] resultsField;

    private TestRunUnitTest[] testDefinitionsField;

    private TestRunTestEntry[] testEntriesField;

    private TestRunTestList[] testListsField;

    private TestRunResultSummary resultSummaryField;

    private string idField;

    private string nameField;

    private string runUserField;

    /// <remarks/>
    public TestRunTimes Times
    {
      get
      {
        return this.timesField;
      }
      set
      {
        this.timesField = value;
      }
    }

    /// <remarks/>
    public TestRunTestSettings TestSettings
    {
      get
      {
        return this.testSettingsField;
      }
      set
      {
        this.testSettingsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("UnitTestResult", IsNullable = false)]
    public TestRunUnitTestResult[] Results
    {
      get
      {
        return this.resultsField;
      }
      set
      {
        this.resultsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("UnitTest", IsNullable = false)]
    public TestRunUnitTest[] TestDefinitions
    {
      get
      {
        return this.testDefinitionsField;
      }
      set
      {
        this.testDefinitionsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("TestEntry", IsNullable = false)]
    public TestRunTestEntry[] TestEntries
    {
      get
      {
        return this.testEntriesField;
      }
      set
      {
        this.testEntriesField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("TestList", IsNullable = false)]
    public TestRunTestList[] TestLists
    {
      get
      {
        return this.testListsField;
      }
      set
      {
        this.testListsField = value;
      }
    }

    /// <remarks/>
    public TestRunResultSummary ResultSummary
    {
      get
      {
        return this.resultSummaryField;
      }
      set
      {
        this.resultSummaryField = value;
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
    public string runUser
    {
      get
      {
        return this.runUserField;
      }
      set
      {
        this.runUserField = value;
      }
    }
  }
}