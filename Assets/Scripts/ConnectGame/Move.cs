using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    private float speed = 10;
    public Judge judge ;
    
    void Start()
    {

    }


    void Update()
    {
        if (judge.arrow == 7)
        {
            if (transform.position.x < 7)
            {
                Movement();

            } 
            else if (transform.position.x >= 7)
            {
                SceneManager.LoadScene(3);
            }
        }
    }

    void Movement()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
