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

    private void Update()
    {
        //dragon moves to destination
        transform.position = Vector2.MoveTowards(transform.position, endPoint, speed * Time.deltaTime);

        //dragon speeds up if it falls behind player
        if (Vector3.Distance(petal.position, dragon.position) > DISTANCE_FROM_DRAGON)
        {
            speed = 11;
        }
        else
        {
            speed = 7;
        }
    }

}
