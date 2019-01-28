using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPath.FileSystem
{
    public class Folder<TPath> : IEntry<TPath> where TPath : IPath
    {
        public Folder(TPath path)
        {
            Path = path;
        }

        public TPath Path { get; }
    }
}
