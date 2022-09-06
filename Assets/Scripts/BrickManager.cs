using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    [SerializeField] GameObject[] bricksToSpawn;
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
        int blockCategoryIndex = 0;
        for (int i=0;i<brickSpawnConfiguration.x;i++)
		{
            for(int j=0;j<brickSpawnConfiguration.y;j++)
			{
                blockCategoryIndex = Random.Range(0, bricksToSpawn.Length);
                Vector2 newSpawnPoint = new Vector2(spawnerInitialPosition.x+(brickSpawnOffsets.x*j), spawnerInitialPosition.y - (brickSpawnOffsets.y * i));
                GameObject newBrick = Instantiate(bricksToSpawn[blockCategoryIndex], newSpawnPoint, Quaternion.identity);
                newBrick.transform.parent = gameObject.transform;
            }
		}
	}

    private void InitBrickManager()
	{
        brickSize = bricksToSpawn[0].GetComponent<Brick>().MyBrickModel.BrickScale;
        spawnerInitialPosition = transform.position;
        brickSpawnOffsets = brickSize + brickPadding;
    }
}
