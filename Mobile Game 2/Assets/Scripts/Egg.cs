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

    [SerializeField] private AudioSource eggtouch;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag== "Player")
        {

            eggtouch.Play();

            PlayerBehavior.numberOfEggs += 1;
            Debug.Log("Eggs :" + PlayerBehavior.numberOfEggs);
            Destroy(gameObject);
        }
    }
}
