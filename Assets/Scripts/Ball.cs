using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speedFactor;
    [SerializeField] private float maxBounceAngle;
    [SerializeField] GameEvent[] ballEvents;
    private Rigidbody2D ballRigidBody;
    private bool isBallLaunched;

    void Start()
    {
        ballRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isBallLaunched)
		{
            gameObject.transform.position = new Vector2(gameObject.transform.parent.transform.position.x, gameObject.transform.position.y);
        }
    }

    public void LaunchBall()
	{
        if(!isBallLaunched)
		{
            gameObject.transform.parent = null;
            ballRigidBody.bodyType = RigidbodyType2D.Dynamic;
            Vector2 direction;
            direction.y = -1;
            direction.x = Random.Range(-1f, 1f);
            ballRigidBody.AddForce(direction.normalized * speedFactor);
            isBallLaunched = true;
            ballEvents[0].EventTriggered();
        }
    }

    private void Bounce()
	{
        if(ballRigidBody.velocity == Vector2.zero)
		{
            ballRigidBody.velocity = transform.up * speedFactor;
        }
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{ 
		if(collision.gameObject.GetComponent<Paddle>()!=null)
		{
            Vector2 paddlePosition = collision.gameObject.transform.position;
            Vector2 firstContactPoint = collision.GetContact(0).point;
            float ballOffsetFromPaddle = paddlePosition.x - firstContactPoint.x;

            float halfPaddleWidth = collision.gameObject.GetComponent<BoxCollider2D>().bounds.extents.x;
            float currentAngleofBounce = Vector2.SignedAngle(Vector2.up, ballRigidBody.velocity);
            float bounceAngle = (ballOffsetFromPaddle / halfPaddleWidth) * maxBounceAngle;
            float newAngleOfBounce = Mathf.Clamp(currentAngleofBounce + bounceAngle, -maxBounceAngle, maxBounceAngle);

            Quaternion rotation = Quaternion.AngleAxis(newAngleOfBounce, Vector3.forward);
            ballRigidBody.velocity = rotation * Vector2.up * ballRigidBody.velocity.magnitude;
            ballEvents[0].EventTriggered();
        }
        else if(collision.gameObject.GetComponent<Brick>() != null)
        {
            ballEvents[1].EventTriggered();
        }
	}
}
