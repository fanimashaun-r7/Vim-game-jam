using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject gamemanager;

    //collision controls
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DeathCollider")
        {
            Death();
        }

        if (collision.gameObject.tag == "LevelClearer")
        {
            Destroy(collision.gameObject);
            Death();
        }
    }


    public void Death()
    {
       // GameObject petal = GameObject.FindWithTag("Petal");

        gamemanager.GetComponent<GameManager>().GameOver();

        //petal.GetComponent<PetalMovementControls>().enabled = false;
    }
}
