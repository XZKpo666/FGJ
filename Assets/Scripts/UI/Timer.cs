using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI tmpUI;
    //private GameManager gm;
    public int total_time;
    public int min;
    public int sec;

    // Start is called before the first frame update
    void Start()
    {
        //gm = GameObject.Find("GameManeger").GetComponent<GameManager>();
        total_time = 30;
        tmpUI = GetComponent<TextMeshProUGUI>();
        StartCoroutine(TimerCal());
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (gm.OnGame)
        {
        }*/
        //TimerCal();

    }

    private IEnumerator TimerCal()
    {
        tmpUI.text = string.Format("{0}:{1}", min.ToString("00"), sec.ToString("00"));
        total_time = (min * 60) + sec;
        
        while(total_time > 0)
        {
            yield return new WaitForSeconds(1);

            total_time--;
            sec--;

            if (sec < 0 && min > 0)
            {
                min -= 1;
                sec = 59;
            }
            else if (sec < 0 && min == 0)
            {
                sec = 0;
            }
            tmpUI.text = string.Format("{0}:{1}", min.ToString("00"), sec.ToString("00"));
        }


        //time -= Time.deltaTime;
        //tmpUI.text = time.ToString("0");

        yield return new WaitForSeconds(1);
    }
}


