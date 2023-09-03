using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public int arrow = 1;
    public bool CanJudge = true;

    void Update()
    {
        Judgement();
    }

    void Judgement()
    {
        if (CanJudge == true)
        {
            if (arrow == 1)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Debug.Log("Work1");
                    StartCoroutine(JudgeDelay());
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Debug.Log("gameOver");
                }
            }
          
            if (arrow == 2)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Debug.Log("Work2");
                    StartCoroutine(JudgeDelay());
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Debug.Log("gameOver2");
                }
            }           
        }       
    }

    IEnumerator JudgeDelay()
    {
        CanJudge = false;
        yield return new WaitForSeconds(0.1f);
        arrow++;
        CanJudge = true;
    }
}
