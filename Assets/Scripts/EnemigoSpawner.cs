using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSpawner : MonoBehaviour
{ 
	float timer;
    public GameObject Enemigo1Prefab;
    public GameObject Enemigo2Prefab;
    public GameObject Enemigo3Prefab;

    enum EnemiesType
    {
        NormalEnemy,
        FasterEnemy,
        ShooterEnemy
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 0.6f)
        {
            timer = 0;
            float random = Random.Range(-1f, 1f);
            Vector3 position = new Vector3(random, 2f, 0);
            Quaternion rot = new Quaternion();
            EnemiesType enemy = (EnemiesType)Random.Range(0, 3);
            switch (enemy)
            {
                case EnemiesType.NormalEnemy:
                    Instantiate(Enemigo1Prefab, position, rot);
                    break;
                case EnemiesType.FasterEnemy:
                    Instantiate(Enemigo1Prefab, position, rot);
                    break;
                case EnemiesType.ShooterEnemy:
                    Instantiate(Enemigo2Prefab, position, rot);
                    break;
            }
            

        }

    }
}
