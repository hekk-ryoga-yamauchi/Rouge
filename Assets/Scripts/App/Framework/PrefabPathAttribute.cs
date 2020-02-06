using System;

namespace Framework
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PrefabPathAttribute : Attribute
    {
        public PrefabPathAttribute(string path)
        {
            Path = path;
        }

        public string Path { get; }
    }
}