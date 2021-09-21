using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : MonoBehaviour
{
    private const float DISTANCE_FROM_DRAGON = 15f;

    public float speed = 1;

    public Vector2 endPoint;

    [SerializeField] private Transform petal;
    [SerializeField] private Transform dragon;

    public int difficulty; 

    private void Start()
    {
        difficulty = PlayerPrefs.GetInt("Difficulty");
    }

    private void Update()
    {
        //dragon moves to destination
        transform.position = Vector2.MoveTowards(transform.position, endPoint, speed * Time.deltaTime);

        if(difficulty == 1)
        {
            //dragon speeds up if it falls behind player
            if (Vector3.Distance(petal.position, dragon.position) > DISTANCE_FROM_DRAGON)
            {
                speed = 12;
            }
            else
            {
                speed = 4;
            }
        }
        else if (difficulty == 2)
        {
            //dragon speeds up if it falls behind player
            if (Vector3.Distance(petal.position, dragon.position) > DISTANCE_FROM_DRAGON)
            {
                speed = 12;
            }
            else
            {
                speed = 6;
            }
        }
        else if (difficulty == 3)
        {
            //dragon speeds up if it falls behind player
            if (Vector3.Distance(petal.position, dragon.position) > DISTANCE_FROM_DRAGON)
            {
                speed = 12;
            }
            else
            {
                speed = 8;
            }
        }
        else if (difficulty == 4)
        {
            //dragon speeds up if it falls behind player
            if (Vector3.Distance(petal.position, dragon.position) > DISTANCE_FROM_DRAGON)
            {
                speed = 12;
            }
            else
            {
                speed = 10;
            }
        }
        

        //3 easy, 5 medium, 7 hard, 9 pro gamer
        
    }

}
