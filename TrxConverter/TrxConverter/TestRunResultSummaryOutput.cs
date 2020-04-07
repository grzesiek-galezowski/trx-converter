namespace TddXt.TrxConverter
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunResultSummaryOutput
  {

    private string stdOutField;

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
  }
}