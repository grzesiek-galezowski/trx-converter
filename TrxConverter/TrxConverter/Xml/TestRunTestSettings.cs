namespace TddXt.TrxConverter.Xml
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunTestSettings
  {

    private TestRunTestSettingsDeployment deploymentField;

    private string nameField;

    private string idField;

    /// <remarks/>
    public TestRunTestSettingsDeployment Deployment
    {
      get
      {
        return this.deploymentField;
      }
      set
      {
        this.deploymentField = value;
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