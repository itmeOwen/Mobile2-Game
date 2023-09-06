using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag== "Player")
        {
            PlayerBehavior.numberOfEggs += 1;
            Debug.Log("Eggs :" + PlayerBehavior.numberOfEggs);
            Destroy(gameObject);
        }
    }
}
