namespace TddXt.TrxConverter.Xml
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
  public partial class TestRunResultSummaryCounters
  {

    private uint totalField;

    private uint executedField;

    private uint passedField;

    private uint failedField;

    private uint errorField;

    private uint timeoutField;

    private uint abortedField;

    private uint inconclusiveField;

    private uint passedButRunAbortedField;

    private uint notRunnableField;

    private uint notExecutedField;

    private uint disconnectedField;

    private uint warningField;

    private uint completedField;

    private uint inProgressField;

    private uint pendingField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint total
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
    public uint executed
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
    public uint passed
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
    public uint failed
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
    public uint error
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
    public uint timeout
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
    public uint aborted
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
    public uint inconclusive
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
    public uint passedButRunAborted
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
    public uint notRunnable
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
    public uint notExecuted
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
    public uint disconnected
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
    public uint warning
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
    public uint completed
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
    public uint inProgress
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
    public uint pending
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