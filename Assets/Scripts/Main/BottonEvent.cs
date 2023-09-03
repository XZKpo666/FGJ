using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonEvent : MonoBehaviour
{
    private SceneManager sm;
    private bool autoOnOff = false;
    private void Start()
    {
        sm = GameObject.Find("Dialogbox").GetComponent<SceneManager>();
    }
    public void AutoBotton()
    {
        autoOnOff = !autoOnOff;
        StartCoroutine(Auto());
    }

    IEnumerator Auto()
    {
        while (autoOnOff)
        {
            yield return new WaitForSeconds(1);
            sm.DialogText();            
        }
        yield return new WaitForSeconds(1);
    }
}
