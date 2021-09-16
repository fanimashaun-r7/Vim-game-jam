using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 50f;
    private const float PLAYER_DISTANCE_DELETE_LEVEL_PART = -100f;

    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private List<Transform> levelPartList;
    [SerializeField] private Transform petal;

    private Vector3 lastEndPosition;

    private void Awake()
    {
        lastEndPosition = levelPart_Start.Find("EndPosition").position;

        int startingSpawnLevelParts = 5;
        for(int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }

    }

    private void Update()
    {
        if(Vector3.Distance(petal.position, lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
           StartCoroutine(SpawnLevelPart());
        }

       

    }

    IEnumerator SpawnLevelPart()
    {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;

        yield return new WaitForSeconds(30f);

        Destroy(chosenLevelPart);
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
