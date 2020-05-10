namespace TddXt.TrxConverter.Xml
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunTestSettingsDeployment
  {

    private string runDeploymentRootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string runDeploymentRoot
    {
      get
      {
        return this.runDeploymentRootField;
      }
      set
      {
        this.runDeploymentRootField = value;
      }
    }
  }
}