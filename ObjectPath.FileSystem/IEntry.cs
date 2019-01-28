namespace ObjectPath.FileSystem
{
    public interface IEntry<TPath> where TPath : IPath
    {
        TPath Path { get; }
    }
}
