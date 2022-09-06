using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PowerUp : MonoBehaviour
{
    [SerializeField] PowerupModel powerupModel;
    [SerializeField] GameEvent[] powerupEvents;
    SpriteRenderer powerupSpriteRenderer;
    PowerupModel.PowerupType powerupType;
    void Start()
    {
        int powerupIndex = UnityEngine.Random.Range(0, 3);
        Array values = Enum.GetValues(typeof(PowerupModel.PowerupType));
        powerupSpriteRenderer = GetComponent<SpriteRenderer>();
        powerupSpriteRenderer.color = powerupModel.PowerupColors[powerupIndex];
        powerupType = (PowerupModel.PowerupType)values.GetValue(powerupIndex);
    }

    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.GetComponent<Paddle>() != null)
        {
            switch (powerupType)
            {
                case PowerupModel.PowerupType.ReverseControl:
                    powerupEvents[0].EventTriggered();
                    break;
                case PowerupModel.PowerupType.EnlargePaddle:
                    powerupEvents[1].EventTriggered();
                    break;
                case PowerupModel.PowerupType.StrongBall:
                    powerupEvents[2].EventTriggered();
                    break;
            }
            Destroy(gameObject);
        }
        
    }
}
