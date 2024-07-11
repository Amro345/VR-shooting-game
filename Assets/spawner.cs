using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    private float timer;
    private Vector3 enemyPostion;
    // Start is called before the first frame update
    void Start()
    {
        timer = 2f;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            enemyPostion = new Vector3(Random.Range(-3.9929f, -5f), -19.14f, Random.Range(-26f, -22.53f));
            Instantiate(enemy, enemyPostion, enemy.transform.rotation);
            timer = 2f;
        }
    }
}
