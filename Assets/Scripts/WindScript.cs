using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindScript : MonoBehaviour
{
    public float speed = 1;


    public Vector2 endPoint;

    private void Start()
    {
        StartCoroutine(WindSpeed());
    }

    private void Update()
    {     
        transform.position = Vector2.MoveTowards(transform.position, endPoint, speed * Time.deltaTime);
    }

    IEnumerator WindSpeed()
    {

        int num = Random.Range(0, 3);

        int previousNum;

        if(num == 0)
        {
            speed = 3;
        }
        else if (num == 1)
        {
            speed = 5;
        }
        else if (num == 2)
        {
            speed = 7;
        }

        Debug.Log(num);

        yield return new WaitForSeconds(5f);

        RepeatWindLoop();


    }

    private void RepeatWindLoop()
    {
        StartCoroutine(WindSpeed());
    }





}
