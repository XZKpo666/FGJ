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

        "�������U���ӫ��s��A�X�{�Ӥ@�ө_�Ǫ��e��",

        "�u�п�J���v�{�ҡv",

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
