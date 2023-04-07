using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    public ClaySpawner claySpawner;
    public Text scoreTxt;
    public int score;
    public bool isClicked = false;
    public float curTime;
    public float coolTime = 2f;
    public GameObject UICanvas;

    public void ScoreCounter()
    {
        score++;
        scoreTxt.text = $"| SCORE | {score}";
    }

    public void StartGame()
    {
        UICanvas.SetActive(false);
        claySpawner.spawnerSW = true;
        scoreTxt.text = $"| SCORE | {score}";
    }

    public void StartBntEnter()
    {
        isClicked = true;
    }

    public void StartBntExit()
    {
        isClicked = false;
        curTime = 0;
    }


    void Update()
    {
        if(isClicked)
        {
            curTime += Time.deltaTime;
            if(curTime > coolTime)
            {
                StartGame();
                curTime = 0;
                isClicked = false;
            }
        }
    }
}
