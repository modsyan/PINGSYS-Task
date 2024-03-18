namespace MySereneApp.Imports.ClientTypes;

public class LocalTextDisplayNameAttribute : DisplayNameAttribute
{
    private readonly object _localTextKey;

    public LocalTextDisplayNameAttribute(object localTextKey)
    {
        _localTextKey = localTextKey;
    }

    public override string DisplayName
    {
        get
        {
            return _localTextKey.GetKey();
        }
    }
}