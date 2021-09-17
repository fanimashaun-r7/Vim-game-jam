using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelClearer : MonoBehaviour
{
    public float lifetime = 30f;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

}
