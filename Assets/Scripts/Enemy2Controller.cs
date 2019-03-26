using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MoveDown
{

    float timer;
    public GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        base.moveDown();
        Shoot();
    }

    void Shoot()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer = 0;
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
        }
    }

}
