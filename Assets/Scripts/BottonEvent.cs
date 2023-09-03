using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonEvent : MonoBehaviour
{
    private SceneManager sm;
    private bool autoOnOff = false;
    private void Start()
    {
        StartCoroutine(Auto());
        sm = GameObject.Find("Dialogbox").GetComponent<SceneManager>();
    }
    public void AutoBotton()
    {
        autoOnOff = !autoOnOff;
    }

    IEnumerator Auto()
    {
        while (autoOnOff)
        {
            sm.DialogText();
        }
        yield return new WaitForSeconds(1);
    }
}
