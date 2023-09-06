using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCount : MonoBehaviour
{
    // Start is called before the first frame update
    public int EggTarget;
    private int EggCurrent = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Egg")
        {
            PlayerBehavior.numberOfEggs += 1;
            Debug.Log("Eggs :" + PlayerBehavior.numberOfEggs);
            Destroy(gameObject);
        }
    }
}
