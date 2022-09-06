using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    [SerializeField] BrickModel myBrickModel;
    SpriteRenderer brickSpriteRenderer;
    void Start()
    {
        brickSpriteRenderer = GetComponent<SpriteRenderer>();
        brickSpriteRenderer.sprite = myBrickModel.BrickSprite;

        gameObject.transform.localScale = myBrickModel.BrickScale;
        brickSpriteRenderer.color = myBrickModel.BrickColors[Random.Range(0, myBrickModel.BrickColors.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
