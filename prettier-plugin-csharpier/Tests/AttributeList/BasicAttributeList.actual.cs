[assembly: System.Copyright(@"(C)""

2009")]
[module: System.Copyright("\n\t\u0123(C) \"2009" + "\u0123")]
[Obsolete]
class ClassName
{
    [Obsolete]
    private string Field;
    [Obsolete]
    public string Property
    {
        [Obsolete]
        get;
        [Obsolete]
        set;
    }
    [Obsolete]
    void MethodName([In]string value) { }
}
