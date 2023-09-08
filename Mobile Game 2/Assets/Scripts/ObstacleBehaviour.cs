using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene

public class ObstacleBehaviour : MonoBehaviour
{

    //public PlayerBehavior PBScript;
    //private GameObject PB;
    

    private void Start()
    {
        //PB = GameObject.FindGameObjectsWithTag("Player");
        //PBScript = PB.GetComponent<PlayerBehavior>();
    }

    [SerializeField] private AudioSource chickenHit;
    

    [Tooltip("How long to wait before restarting the game")]
    public float waitTime = 0f;
    private void OnCollisionEnter(Collision collision)
    {
        // First check if we collided with the player
        if (collision.gameObject.GetComponent<PlayerBehavior>())
        {
            //Chicken Hit sound effect
            chickenHit.Play();

            // Destroy the player
            Destroy(collision.gameObject);
            // Call the function ResetGame after waitTime
            // has passed
            GameOverFunction();
        }
    }
    /// <summary>
    /// Will restart the currently loaded level
    /// </summary>
   private void GameOverFunction()
    {
        FindObjectOfType<PlayerBehavior>().GameOver();
    }


    
}
