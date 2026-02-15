using System.Collections.Generic;

sealed class Directory : FSContent
{
    public Dictionary<string, string> Files;
    public Dictionary<string, Directory> Directories;

    public void Mkdir(string name)
    {
        if (Directories.ContainsKey(name))
        {
            throw new System.Exception($"Directory with name {name} already exists");
        }
        Directories.Add(name, new Directory());
    }
}