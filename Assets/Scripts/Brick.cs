using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    [SerializeField] BrickModel myBrickModel;
    [SerializeField] GameEvent[] brickEvents;
    [SerializeField] GameObject brickPowerup;

    private SpriteRenderer brickSpriteRenderer;
    private int brickStrength;

    public BrickModel MyBrickModel
	{
		get { return myBrickModel; }
	}
    void Start()
    {
        brickSpriteRenderer = GetComponent<SpriteRenderer>();
        brickSpriteRenderer.sprite = myBrickModel.BrickSprite;
        gameObject.transform.localScale = myBrickModel.BrickScale;
        brickSpriteRenderer.color = myBrickModel.BrickColors[Random.Range(0, myBrickModel.BrickColors.Length)];
        brickStrength = myBrickModel.BrickStrength;
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.GetComponent < Ball>()!=null)
		{
            brickStrength--;
            if(brickStrength==0)
			{
                brickEvents[1].EventTriggered();
                if(myBrickModel.HasPowerupDrop)
				{
                    Instantiate(brickPowerup, transform.position,Quaternion.identity);
				}
                Destroy(gameObject);
			}
		}
	}
	void Update()
    {
        
    }
}
