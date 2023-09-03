using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private Text dialogText;
    [SerializeField] private GameObject nameBox;
    [SerializeField] private GameObject player;

    private ImageChance ic;

    private int i = 0;
    private List<string> dialog = new List<string>()
    {
        "�P���]�̡A���~�g���ɫB" +"\n" +
        "�䭷�n�����ɭ��٬O�P���񰲪��ɭԡA�֤k�X�G�@��ѳ��X���F���F",

        "�ݤF�@�U�����s�D�A�䭷�ܧִN�|���}�A�P���@�w�g�S���|��䭷���F",

        "�u�z�A�����F�a�A�S�����٭n�����v",

        "�@�P�b�y����Ѹs�̪��P�Ǹ�۶}�l����",

        "�u�藍��A��ɭԤS�n�O�B��ǮաA�W�·Ъ��v",

        "�u�O���A��n�P���@�O�̫�@�ѿ�ҡA�A��ҤF��?�v",

        "�u�K�K���F�A�{�b�X�I!?�v",

        "�u�ߤW11:56���A��Ҩt�Φn���O����12�I��N�|�����F�C�v",

        "�u���F�A�o�Ǵ��S����Ǥ��N�n�����F�C�v",

        "�u�A��L�]�V�o�Ӥj�n�F�a�v",

        "�u�p�G�ڨS�ﺡ�Ǥ��������ܡA�ڤ@�w�C�ѱߤW��A���ж��A"+"\n" +
        "��A���E�Y�������L�V�@���w�v�����Ať�A�j�Ѧb�@�_�h�W���K�C�v",

        "�u���ڡA��ɭԧڦ��N���~�F�A�A�L�ڧO�ö}�����ڸ�۩����ڡC�v",

        "�u���F�A�ҵ{�X�G�Q�飼�F�A�o�U�u���n�����F�C�v",

        "�u��?�o�̫�򦳤@�ӨS�ݹL�����s?�v",

        "�������U���ӫ��s��A�X�{�Ӥ@�ө_�Ǫ��e��",

        "�u�п�J���v�{�ҡv",

        "�uĵ�i�A������������`�A�ǿ���O�ɭP���A���W���v",

        "�u�P�޲z���A���_�}�s�u�v",

        "�u��!? ���s�u�쪺�O�޲z���A��?�v",

        "�ܩ|�������A�_�Ǫ��e���N�����F�A��Ҩt�έ��s��ܥX��" +"\n" +
        "�쥻�@���ťժ��Ҫ�Q�񺡤F�ҵ{�A�ܩ�W����ܪ��Ǥ��p��w�w",

        "�u25000��!? �o�]�Ӧh�F�a�v",

        "���ݮɶ��w�g�����F�A�U���F����h�������U�F�e�X����A�̫�e����ܤw���\��ҡC",

        "����P���@�A���O�۫B��ǮդW�Ү�" +"\n" +
        "�~�o���A�q�⤤�߱M���t�d��Ҩt�Ϊ����A���A�b��᪺�ɭԦ]������]�z���_��",

        "�ҥH�j�a���n���s��ҤF"

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
            case 7:
                nameBox.SetActive(true);
                player.SetActive(true);
                ic.ImageChance0(7);
                break;
            case 9:
                nameBox.SetActive(true);
                player.SetActive(true);
                ic.ImageChance0(9);
                break;
            case 11:
                nameBox.SetActive(true);
                player.SetActive(true);
                ic.ImageChance0(3);
                break;
            case 13:
                nameBox.SetActive(true);
                player.SetActive(true);
                ic.ImageChance0(9);
                break;
            case 14:
                nameBox.SetActive(true);
                player.SetActive(true);
                ic.ImageChance0(7);
                break;
            case 21:
                nameBox.SetActive(true);
                player.SetActive(true);
                ic.ImageChance0(7);
                break;

            default:
                player.SetActive(false);
                nameBox.SetActive(false);
                ic.ImageChance0(0);
                break;
        }
    }

    private IEnumerator SceneToGame()
    {
        yield return new WaitForSeconds(1);
        //SceneManager.LoadScene();
    }
}
