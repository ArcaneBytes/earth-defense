﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave1Controller : BaseMovement
{

    public override void setMovementKeys(KeyCode up, KeyCode left, KeyCode right, KeyCode down, KeyCode shoot)
    {
        this.up = up;
        this.left = left;
        this.right = right;
        this.down = down;
        this.shoot = shoot;
    }

    // Start is called before the first frame update
    void Start()
    {
        setMovementKeys(KeyCode.W, KeyCode.A, KeyCode.D, KeyCode.S, KeyCode.Space);
    }
    
}
