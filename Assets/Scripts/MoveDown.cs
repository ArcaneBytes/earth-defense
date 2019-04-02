using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveDown : MonoBehaviour
{

    public int lifes = 1;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void moveDown()
    {
        gameObject.transform.Translate(0, -speed * Time.deltaTime, 0);
        if (gameObject.transform.position.y <= -0.72f)
        {
            SceneManager.LoadScene("StartMenu");
        }
    }
    // Update is called once per frame
    void Update()
    {
        moveDown();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "enemy" && other.gameObject.tag != "enemyBullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }



}
