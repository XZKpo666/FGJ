using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private Text dialogText;
    [SerializeField] private GameObject nameBox;
    [SerializeField] private GameObject player;

    private ImageChance ic;

    private int i = 0;
    private List<string> dialog = new List<string>()
    {
        "周末夜裡，窗外狂風暴雨" +"\n" +
        "颱風登陸的時候還是周末放假的時候，少女幾乎一整天都出不了門了",

        "看了一下網路新聞，颱風很快就會離開，星期一已經沒機會放颱風假了",

        "「哇，太虧了吧，沒的放假還要玩水」",

        "一同在語音聊天群裡的同學跟著開始抱怨著",

        "「對不對，到時候又要淋雨到學校，超麻煩的」",

        "「是說，剛好星期一是最後一天選課，你選課了嗎?」",

        "「……完了，現在幾點!?」",

        "「晚上11:56分，選課系統好像是到凌晨12點整就會關閉了。」",

        "「完了，這學期沒選夠學分就要延畢了。」",

        "「你鍵盤也敲得太大聲了吧」",

        "「如果我沒選滿學分延畢的話，我一定每天晚上到你的房間，"+"\n" +
        "到你的枕頭旁邊用鍵盤敲一首安眠曲給你聽，隔天在一起痛苦早八。」",

        "「哭啊，到時候我早就畢業了，你嘴巴別亂開光讓我跟著延畢啊。」",

        "「完了，課程幾乎被選走了，這下真的要延畢了。」",

        "「嗯?這裡怎麼有一個沒看過的按鈕?」",

        "當澪按下那個按鈕後，出現來一個奇怪的畫面"

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
                SceneManager.LoadScene(2);
                break;

            default:
                player.SetActive(false);
                nameBox.SetActive(false);
                ic.ImageChance0(0);
                break;
        }
    }

}
