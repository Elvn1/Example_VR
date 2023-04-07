using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float curTime;
    public float coolTime = 5f;

    void Start()
    {
        
    }


    void Update()
    {
        curTime += Time.deltaTime;
        if(curTime > coolTime)
        {
            Instantiate(enemyPrefab, transform.position, transform.rotation);
            curTime = 0;
        }
    }
}
