using System;
using System.Collections;
using System.IO;
using Siccity.GLTFUtility;
using UnityEngine;
using UnityEngine.Networking;

public class ModelLoader : MonoBehaviour
{
    GameObject wrapper;
    string filePath;

    private void Start()
    {
        // An example file path we'll use later
        filePath = $"{Application.persistentDataPath}/Files/test.gltf";

        wrapper=new GameObject
        {
            name = "Model"
        };
    }
    public void DownloadFile(string url)
    {
        if (File.Exists(url))
        {
            Debug.Log("Found file locally, loading...");
            LoadModel(url);
            return;
        }
        else
        {
            Debug.Log("File not found 404");
        }
    }
    
    void LoadModel(string path)
    {
        GameObject model = Importer.LoadFromFile(path);
        model.transform.SetParent(wrapper.transform);
    }
}