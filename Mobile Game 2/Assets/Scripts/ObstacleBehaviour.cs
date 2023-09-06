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



    [Tooltip("How long to wait before restarting the game")]
    public float waitTime = 0f;
    private void OnCollisionEnter(Collision collision)
    {
        // First check if we collided with the player
        if (collision.gameObject.GetComponent<PlayerBehavior>())
        {
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


    public GameObject explosion;
    /// <summary>
    /// If the object is tapped, we spawn an explosion and
    /// destroy this object
    /// </summary>
    private void PlayerTouch()
    {
        if (explosion != null)
        {
            var particles = Instantiate(explosion, transform.position,
            Quaternion.identity);
            Destroy(particles, 1.0f);
        }
        Destroy(this.gameObject);
    }
}
