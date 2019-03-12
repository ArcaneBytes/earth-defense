using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMovement : MonoBehaviour
{

    public float speed = 1.5f;
    public KeyCode up;
    public KeyCode left;
    public KeyCode right;
    public KeyCode down;
    public KeyCode shoot;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            if (transform.position.x > -1.18f)
                gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(right))
        {
            if (transform.position.x < 1.18f)
                gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(up))
        {
            if (transform.position.y < -1.38f)
                gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(down))
        {
            if (transform.position.y > -1.85f)
                gameObject.transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(shoot))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 0.1f, 0), transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collide");
        if (other.gameObject.tag == "enemyBullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    public abstract void setMovementKeys(KeyCode up, KeyCode left, KeyCode right, KeyCode down, KeyCode shoot);
}
