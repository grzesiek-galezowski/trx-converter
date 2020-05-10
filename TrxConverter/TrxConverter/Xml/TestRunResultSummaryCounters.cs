namespace TddXt.TrxConverter.Xml
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunResultSummaryCounters
  {

    private byte totalField;

    private byte executedField;

    private byte passedField;

    private byte failedField;

    private byte errorField;

    private byte timeoutField;

    private byte abortedField;

    private byte inconclusiveField;

    private byte passedButRunAbortedField;

    private byte notRunnableField;

    private byte notExecutedField;

    private byte disconnectedField;

    private byte warningField;

    private byte completedField;

    private byte inProgressField;

    private byte pendingField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte total
    {
      get
      {
        return this.totalField;
      }
      set
      {
        this.totalField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte executed
    {
      get
      {
        return this.executedField;
      }
      set
      {
        this.executedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte passed
    {
      get
      {
        return this.passedField;
      }
      set
      {
        this.passedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte failed
    {
      get
      {
        return this.failedField;
      }
      set
      {
        this.failedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte error
    {
      get
      {
        return this.errorField;
      }
      set
      {
        this.errorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte timeout
    {
      get
      {
        return this.timeoutField;
      }
      set
      {
        this.timeoutField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte aborted
    {
      get
      {
        return this.abortedField;
      }
      set
      {
        this.abortedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte inconclusive
    {
      get
      {
        return this.inconclusiveField;
      }
      set
      {
        this.inconclusiveField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte passedButRunAborted
    {
      get
      {
        return this.passedButRunAbortedField;
      }
      set
      {
        this.passedButRunAbortedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte notRunnable
    {
      get
      {
        return this.notRunnableField;
      }
      set
      {
        this.notRunnableField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte notExecuted
    {
      get
      {
        return this.notExecutedField;
      }
      set
      {
        this.notExecutedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte disconnected
    {
      get
      {
        return this.disconnectedField;
      }
      set
      {
        this.disconnectedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte warning
    {
      get
      {
        return this.warningField;
      }
      set
      {
        this.warningField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte completed
    {
      get
      {
        return this.completedField;
      }
      set
      {
        this.completedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte inProgress
    {
      get
      {
        return this.inProgressField;
      }
      set
      {
        this.inProgressField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte pending
    {
      get
      {
        return this.pendingField;
      }
      set
      {
        this.pendingField = value;
      }
    }
  }
}