using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Judge : MonoBehaviour
{
    public int arrow = 1;
    public bool CanJudge = true;
    public GameObject arrowImage1;
    public GameObject arrowImage2;
    public GameObject arrowImage3;
    public GameObject arrowImage4;
    public GameObject arrowImage5;
    public GameObject arrowImage6;
    public Sprite failArrow;
    public Sprite passArrow;

    GameObject[] arrowImages = new GameObject[6];

    private void Awake()
    {
        arrowImages[0] = arrowImage1;
        arrowImages[1] = arrowImage2;
        arrowImages[2] = arrowImage3;
        arrowImages[3] = arrowImage4;
        arrowImages[4] = arrowImage5;
        arrowImages[5] = arrowImage6;
    }

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
                Direction(0);
            }       
            if (arrow == 2)
            {
                Direction(1);
            }
            if (arrow == 3)
            {
                Direction(0);
            }
            if (arrow == 4)
            {
                Direction(1);
            }
            if (arrow == 5)
            {
                Direction(3);
            }
            if (arrow == 6)
            {
                Direction(3);
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

    void IsPass(int x)
    {
        if (x == 0)
        {
            arrowImages[arrow - 1].GetComponent<Image>().sprite = passArrow;
        }
        else
        {
            arrowImages[arrow - 1].GetComponent<Image>().sprite = failArrow;
        }
    }

    void Direction(int x)
    {
        if (x == 0)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                IsPass(0);
                StartCoroutine(JudgeDelay());
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                IsPass(1);
            }
        }
        else if(x == 1)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                IsPass(0);
                StartCoroutine(JudgeDelay());
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                IsPass(1);
            }
        }
        else if(x == 2)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                IsPass(0);
                StartCoroutine(JudgeDelay());
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                IsPass(1);
            }
        }
        else if(x == 3)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                IsPass(0);
                StartCoroutine(JudgeDelay());
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                IsPass(1);
            }
        }
    }
}
