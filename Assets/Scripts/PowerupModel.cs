using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Powerup",menuName ="Powerups")]
public class PowerupModel : ScriptableObject
{
    [SerializeField] Color[] powerupColors;
    public enum PowerupType { ReverseControl, EnlargePaddle, StrongBall};
    public Color[] PowerupColors
	{
		get
		{
			return powerupColors;
		}
	}
}
