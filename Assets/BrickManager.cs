using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    [SerializeField] GameObject brickToSpawn;
    [SerializeField] Vector2 brickSpawnConfiguration;
    [SerializeField] Vector2 brickPadding;
    private Vector2 brickSize;
    private Vector2 brickSpawnOffsets;
    private Vector2 spawnerInitialPosition;
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnBricks()
	{
        InitBrickManager();
        for (int i=0;i<brickSpawnConfiguration.x;i++)
		{
            Vector2 spawnPoint = new Vector2(spawnerInitialPosition.x, spawnerInitialPosition.y - (brickSpawnOffsets.y*i));
            Instantiate(brickToSpawn, spawnPoint, Quaternion.identity);
            Debug.Log(spawnPoint);
            for(int j=1;j<brickSpawnConfiguration.y;j++)
			{
                Vector2 newSpawnPoint = new Vector2(spawnPoint.x+(brickSpawnOffsets.x*j), spawnPoint.y);
                Instantiate(brickToSpawn, newSpawnPoint, Quaternion.identity);
            }
		}
	}

    private void InitBrickManager()
	{
        brickSize = brickToSpawn.GetComponent<Brick>().MyBrickModel.BrickScale;
        spawnerInitialPosition = transform.position;
        brickSpawnOffsets = brickSize + brickPadding;
    }
}
