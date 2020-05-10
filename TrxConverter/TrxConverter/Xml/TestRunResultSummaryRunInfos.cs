namespace TddXt.TrxConverter.Xml
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunResultSummaryRunInfos
  {

    private TestRunResultSummaryRunInfosRunInfo runInfoField;

    /// <remarks/>
    public TestRunResultSummaryRunInfosRunInfo RunInfo
    {
      get
      {
        return this.runInfoField;
      }
      set
      {
        this.runInfoField = value;
      }
    }
  }
}