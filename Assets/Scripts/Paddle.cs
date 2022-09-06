using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speedFactor;
    private Rigidbody2D paddleRigidbody;
    private bool reverseControls = false;
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
        if(!reverseControls)
		{
            switch (directionFlag)
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
        else
		{
            switch (directionFlag)
            {
                case 1:
                    paddleRigidbody.velocity = Vector2.left * speedFactor;
                    break;
                case -1:
                    paddleRigidbody.velocity = Vector2.right * speedFactor;
                    break;
                case 0:
                    paddleRigidbody.velocity = Vector2.zero;
                    break;
            }
        } 
    }
    
    public void SetReverseFlag(bool flag)
	{
        print("RC_Called");
        reverseControls = flag;
    }

	
	void Update()
    {
        
    }

    public void SetPaddleSize(int xScaleFactor)
	{
        print("Epcalled");
        gameObject.transform.localScale = new Vector3(xScaleFactor,gameObject.transform.localScale.y,gameObject.transform.localScale.z);
	}
}
