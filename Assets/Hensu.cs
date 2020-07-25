using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

public class Hensu : UnityEngine.MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        float fw = 3.14f;
        string str = "こんにちは";
        bool bl = true;

        UnityEngine.Debug.Log(a+a);
        UnityEngine.Debug.Log(fw);
        UnityEngine.Debug.Log(str);
        UnityEngine.Debug.Log(bl);
    }

    public void Proc2()
    {
        UnityEngine.Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
