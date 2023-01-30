using System;
using System.Collections;
using System.IO;
using Siccity.GLTFUtility;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

public class ModelLoader : MonoBehaviour
{
    public TextMeshProUGUI text;
    GameObject wrapper;

    private void Start()
    {
        // An example file path we'll use later

        wrapper=new GameObject
        {
            name = "Model"
        };
    }
    public void DownloadFile(string input)
    {
        string url = Application.dataPath + "/" + input + ".glb";
        text.text = url;

        if (File.Exists(url))
        {
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