using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speedFactor;
    private Rigidbody2D paddleRigidbody;
    void Start()
    {
        paddleRigidbody = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Function to move paddle
    /// </summary>
    /// <param name="directionFlag"> 1 = Right, -1 = Left </param>
	public void Move(float directionFlag)
	{
        switch(directionFlag)
		{
            case 1:
                paddleRigidbody.velocity = Vector2.right * speedFactor;
                break;
            case -1:
                paddleRigidbody.velocity = Vector2.left * speedFactor;
                break;
            case 0:
                paddleRigidbody.velocity = Vector2.zero;
                break;
        }
    }
    
    public void PrintToConsole(string text)
	{
        Debug.Log(text);
	}
	// Update is called once per frame
	void Update()
    {
        
    }
}
