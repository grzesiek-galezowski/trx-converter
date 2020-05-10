namespace TddXt.TrxConverter.Xml
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunUnitTestResultOutput
  {

    private string stdOutField;

    private TestRunUnitTestResultOutputErrorInfo errorInfoField;

    /// <remarks/>
    public string StdOut
    {
      get
      {
        return this.stdOutField;
      }
      set
      {
        this.stdOutField = value;
      }
    }

    /// <remarks/>
    public TestRunUnitTestResultOutputErrorInfo ErrorInfo
    {
      get
      {
        return this.errorInfoField;
      }
      set
      {
        this.errorInfoField = value;
      }
    }
  }
}