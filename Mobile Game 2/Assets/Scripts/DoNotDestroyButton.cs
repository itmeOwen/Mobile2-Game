using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroyButton : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("ButtonSound");

        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);




    }
}
