using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeaveBotton()
    {
        Debug.Log("quit");
        Application.Quit();
    }   
    
    public void StartBotton()
    {
        //SceneManager.LoadScene(0);
    }
}
