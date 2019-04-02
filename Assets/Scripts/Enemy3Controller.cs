using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Controller : MoveDown
{

    public Sprite secondSprite;

    private new void OnTriggerEnter2D(Collider2D other)
    {
        if (lifes > 1)
        {
            BeingHitted();
            Destroy(other.gameObject);
        }
        else
        { 
            base.OnTriggerEnter2D(other);
        }
    }

    private void BeingHitted()
    {
        lifes -= 1;
        GetComponent<SpriteRenderer>().sprite = secondSprite;
    }

}
