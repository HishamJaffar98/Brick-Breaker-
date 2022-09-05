using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private int speedFactor;
    private Vector2 position;
    private Rigidbody2D paddleRigidbody;

    void Start()
    {

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
                paddleRigidbody.AddForce(Vector2.right * speedFactor * Time.deltaTime);
                break;
            case -1:
                paddleRigidbody.AddForce(Vector2.right * speedFactor * Time.deltaTime);
                break;
            default:
                break;
        }
    }

	// Update is called once per frame
	void Update()
    {
        
    }
}
