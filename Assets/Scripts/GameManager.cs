using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameEvent[] mainGameEvents;
    [SerializeField] GameObject ball;
    [SerializeField] Transform ballTransform;

    int score=0;
    int lives = 3;
    int brickPointValue = 10;
    void Start()
    {
        mainGameEvents[0].EventTriggered();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void UpdateScore()
	{
        score += brickPointValue;
        mainGameEvents[1].EventTriggered(score);
    }

    public void ReduceLife()
	{
        lives--;
        mainGameEvents[2].EventTriggered();
        if (lives!=0)
		{
            SpawnBall();
        }
        else
		{
            mainGameEvents[3].EventTriggered();
		}
    }

    private void SpawnBall()
	{
        GameObject newBall = Instantiate(ball, ballTransform.position,Quaternion.identity) as GameObject;
        newBall.transform.parent = FindObjectOfType<Paddle>().transform;
	}

    public void SetBrickPointValue(int value)
	{
        brickPointValue = value;
    }

}
