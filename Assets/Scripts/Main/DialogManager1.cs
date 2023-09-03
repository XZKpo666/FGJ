using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogManager1 : MonoBehaviour
{
    [SerializeField] private Text dialogText;
    [SerializeField] private GameObject nameBox;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject Server;
    [SerializeField] private GameObject Boom;

    [SerializeField] private GameObject back1;
    [SerializeField] private GameObject back2;


    private ImageChance ic;
    private ImageChance bic;

    private int i = 0;
    private List<string> dialog = new List<string>()
    {       

        "�uĵ�i�A������������`�A�ǿ���O�ɭP���A���W���v",

        "�u�I�I�v",

        "�u�P�޲z���A���_�}�s�u�v",

        "�u��!? ���s�u�쪺�O�޲z���A��?�v",

        "�ܩ|�������A�_�Ǫ��e���N�����F�A��Ҩt�έ��s��ܥX��" +"\n" +
        "�쥻�@���ťժ��Ҫ�Q�񺡤F�ҵ{�A�ܩ�W����ܪ��Ǥ��p��w�w",

        "�u25000��!? �o�]�Ӧh�F�a�v",

        "���ݮɶ��w�g�����F�A�U���F����h�������U�F�e�X����A�̫�e����ܤw���\��ҡC",

        "����P���@�A���O�۫B��ǮդW�Ү�" +"\n" +
        "�~�o���A�q�⤤�߱M���t�d��Ҩt�Ϊ����A���A�b��᪺�ɭԦ]������]�z���_��",

        "�ҥH�j�a���n���s��ҤF",

        ""

    };

    private void Start()
    {
        ic = GameObject.Find("Player").GetComponent<ImageChance>();       
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
            case 1:
                ic.ImageChance0(7);
                break;

            case 2:
                Boom.SetActive(true);
                break;

            case 3:
                Server.SetActive(false);
                break;

            case 4:                
                player.SetActive(true);
                nameBox.SetActive(true);
                ic.ImageChance0(7);
                break;

            case 5:
                player.SetActive(true);
                nameBox.SetActive(true);
                back1.SetActive(true);
                ic.ImageChance0(7);
                break;

            case 6:
                player.SetActive(true);
                nameBox.SetActive(true);
                ic.ImageChance0(7);
                break;

            case 8:
                back2.SetActive(false);
                break;

            case 10:
                SceneManager.LoadScene(0);
                break;


            default:
                player.SetActive(false);
                nameBox.SetActive(false);
                ic.ImageChance0(0);
                break;
        }
    }

}
