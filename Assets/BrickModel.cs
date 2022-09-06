using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Brick",menuName ="Bricks")]
public class BrickModel : ScriptableObject
{
    [SerializeField] private Sprite brickSprite;
    [SerializeField] private Vector3 brickScale;
    [SerializeField] private Color[] brickColors;
    public Sprite BrickSprite
	{
        get{return brickSprite;}
    }

    public Vector2 BrickScale
	{
		get { return brickScale; }
	}

    public Color[] BrickColors
    {
        get { return brickColors; }
    }

}
