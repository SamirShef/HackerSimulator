public enum FSContentType
{
    Directory,
    File
}

class FSContent
{
    public FSContentType Type { get => _type; }

    private FSContentType _type;

    public Directory ToDirectory()
    {
        if (_type == FSContentType.Directory)
        {
            return (Directory)this;
        }
        throw new System.Exception($"Cannot convert {_type} to directory");
    }

    public File ToFile()
    {
        if (_type == FSContentType.Directory)
        {
            return (File)this;
        }
        throw new System.Exception($"Cannot convert {_type} to file");
    }
}