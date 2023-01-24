using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject instance = Instantiate(Resources.Load("chess board", typeof(GameObject))) as GameObject;
    }
}
