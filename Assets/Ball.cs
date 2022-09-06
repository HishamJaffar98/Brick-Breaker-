using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speedFactor;
    private Rigidbody2D ballRigidBody;

    void Start()
    {
        ballRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LaunchBall()
	{
        gameObject.transform.parent = null;
        //ballRigidBody.bodyType = RigidbodyType2D.Dynamic;
        Bounce();
    }

    private void Bounce()
	{
        if(ballRigidBody.velocity == Vector2.zero)
		{
            ballRigidBody.velocity = transform.up * speedFactor;
        }
        ballRigidBody.velocity = -ballRigidBody.velocity.normalized * speedFactor;
    }

	private void OnTriggerEnter2D(Collider2D collider)
	{
        Debug.Log(collider.gameObject.name);
        Bounce();
    }
}
