using System.Collections.Generic;
using UnityEngine;

public class TerminalManager : MonoBehaviour
{
    private Dictionary<string, FSContent> _fs;
    private string _currentPath;

    private void Start()
    {
        Debug.Log("Terminal manager was started!");
    }

    private void Update()
    {
        
    }

    private FSContent ResolvePath(string path)
    {
        string[] pathParts = path.Split('/');
        int index = 0;
        foreach (var pair in _fs)
        {
            if (pair.Key != pathParts[index])
            {
                throw new System.Exception($"Object with type {path} does not contains in file system");
            }
            if (index == pathParts.Length - 1)
            {
                return pair.Value;
            }
            ++index;
        }
        throw new System.Exception($"Object with type {path} does not contains in file system");
    }
}