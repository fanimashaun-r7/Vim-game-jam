using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrol : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public float rightRotation;
    public float leftRotation;
    public float flipRight;
    public float flipLeft;

    public Transform[] moveSpots;
    private int nextSpot;

    private bool facingRight = false;

    private void Start()
    {
        waitTime = startWaitTime;
        nextSpot = 0;
 
    }

    private void Update()
    {

        for (int counter = 0; counter < moveSpots.Length; counter++)
        {



            if (nextSpot >= moveSpots.Length)
            {
                nextSpot = 0;
                
            }

            transform.position = Vector2.MoveTowards(transform.position, moveSpots[nextSpot].position, speed * Time.deltaTime);

            

            if (Vector2.Distance(transform.position, moveSpots[nextSpot].position) < 0.2f)
            {
                if (facingRight == false)
                {
                    facingRight = true;
                    transform.localRotation = Quaternion.Euler(0, flipRight, rightRotation);
                }
                else
                {
                    facingRight = false;
                    transform.localRotation = Quaternion.Euler(0, flipLeft, leftRotation);
                }

                if (waitTime <= 0)
                {

                    waitTime = startWaitTime;
                    nextSpot = nextSpot + 1;

                    

                }
                else
                {
                    waitTime -= Time.deltaTime;
                }

            }
            /*Debug.Log(nextSpot);*/
        }
    }


    /*public void changeState(string dir)
    {
        if (dir == "left")
        {
            transform.RotateAround(transform.position, transform.up, 180f);
        }
        else if (dir == "right")
        {
            transform.RotateAround(transform.position, transform.up, 180f);
        }
    }

    [System.Serializable]
    public class MovePoint
    {
        public string FacingDirection;
        public Transform StopPoint;
    }*/
}
