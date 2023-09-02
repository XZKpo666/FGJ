using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    int arrow = 1;

    void Start()
    {
        
    }

    void Update()
    {
        Judgement();
    }
    void Judgement()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && arrow == 1)
        {
            Debug.Log("Work1");
            arrow++;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("gameOver");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && arrow == 2)
        {
            Debug.Log("Work2");
            arrow++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("gameOver");
        }
    }
}
