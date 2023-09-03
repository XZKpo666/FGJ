using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogText;
    private int i = 0;
    private List<string> dialog = new List<string>()
    {
        "Fuck",
        "Suck"
    };
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DialogText();
        }
    }

    public void DialogText()
    {      
        dialogText.text = dialog[i];
        i++;
    }

}
