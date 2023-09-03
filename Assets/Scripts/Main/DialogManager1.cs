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

        "「警告，偵測到網路異常，傳輸指令導致伺服器超載」",

        "「碰！」",

        "「與管理伺服器斷開連線」",

        "「欸!? 剛剛連線到的是管理伺服器?」",

        "話尚未說完，奇怪的畫面就消失了，選課系統重新顯示出來" +"\n" +
        "原本一片空白的課表被填滿了課程，至於上方顯示的學分計算──",

        "「25000分!? 這也太多了吧」",

        "眼看時間已經不夠了，顧不了那麼多的澪按下了送出按鍵，最後畫面顯示已成功選課。",

        "直到星期一，澪淋著雨到學校上課時" +"\n" +
        "才得知，電算中心專門負責選課系統的伺服器，在凌晨的時候因不明原因爆炸起火",

        "所以大家都要重新選課了",

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
