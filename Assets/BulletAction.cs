﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > 5f)
        {
            Destroy(gameObject);
        }
        else
        {
            gameObject.transform.Translate(0, 5f * Time.deltaTime, 0);
        }
    }

    

}
