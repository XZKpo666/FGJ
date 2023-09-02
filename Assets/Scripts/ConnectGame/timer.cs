using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI tmpUI;
    public int total_time;
    public int sec;

    void Start()
    {
        tmpUI = GetComponent<TextMeshProUGUI>();
        StartCoroutine(TimerCal());
    }

    private IEnumerator TimerCal()
    {
        tmpUI.text = string.Format("{0}", sec.ToString("00"));
        total_time = sec;

        while (total_time > 0)
        {
            yield return new WaitForSeconds(1);

            total_time--;
            sec--;

            if (sec < 0)
            {
                sec = 0;
            }
            tmpUI.text = string.Format("{0}", sec.ToString("00"));
        }

        yield return new WaitForSeconds(1);
    }
}
