using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : MonoBehaviour
{
    private const float DISTANCE_FROM_DRAGON = 15f;

    public float speed = 1;

    int previousNum = 2;

    public Vector2 endPoint;

    [SerializeField] private Transform petal;
    [SerializeField] private Transform dragon;

   /* private void Start()
    {
        StartCoroutine(WindSpeed());
    }*/

    private void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, endPoint, speed * Time.deltaTime);

        if (Vector3.Distance(petal.position, dragon.position) > DISTANCE_FROM_DRAGON)
        {
            speed = 11;
        }
        else
        {
            speed = 7;
        }
    }

   /* IEnumerator WindSpeed()
    {




        for (int i = 0; i < 100; i++)
        {
            int num = Random.Range(0, 3);

            if (num == 0 && previousNum != 0)
            {
                speed = 5;
                previousNum = 0;
                i = 101;
            }
            if (num == 1 && previousNum != 1)
            {
                speed = 7;
                previousNum = 1;
                i = 101;
            }
            if (num == 2 && previousNum != 2)
            {
                speed = 9;
                previousNum = 2;
                i = 101;
            }

            Debug.Log(num);

        }

        yield return new WaitForSeconds(5f);

        RepeatWindLoop();

    }

    private void RepeatWindLoop()
    {
        StartCoroutine(WindSpeed());
    }*/
}
