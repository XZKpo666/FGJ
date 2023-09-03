using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogManager2 : MonoBehaviour
{
    [SerializeField] private Text dialogText;
    [SerializeField] private GameObject nameBox;

    private int i = 0;
    private List<string> dialog = new List<string>()
    {       

        "當澪按下那個按鈕後，出現來一個奇怪的畫面",

        "「請輸入授權認證」",

        "",

    };

    private void Start()
    {
        DialogText();
    }
    private void Update()
    {
        PlayerImage(i);

        if (Input.GetMouseButtonDown(0))
        {
            DialogText();
        }

    }

    public void DialogText()
    {
        if (i < (dialog.Count))
        {
            dialogText.text = dialog[i];
            i++;
        }
        
    }

    private void PlayerImage(int a)
    {
        switch (a)
        {
            case 0:
                nameBox.SetActive(true);
                break;

            case 3:
                nameBox.SetActive(false);
                break;

            default:
                break;
        }
    }


}
