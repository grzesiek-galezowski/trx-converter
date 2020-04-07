﻿namespace TddXt.TrxConverter
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunUnitTestResultOutputErrorInfo
  {

    private string messageField;

    private string stackTraceField;

    /// <remarks/>
    public string Message
    {
      get
      {
        return this.messageField;
      }
      set
      {
        this.messageField = value;
      }
    }

    /// <remarks/>
    public string StackTrace
    {
      get
      {
        return this.stackTraceField;
      }
      set
      {
        this.stackTraceField = value;
      }
    }
  }
}