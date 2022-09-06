using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    [SerializeField] GameEvent ballDestroyEvent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.GetComponent<Ball>()!=null)
		{
            //Destroy(collision.gameObject);
            ballDestroyEvent.EventTriggered();
        }
	}
}
