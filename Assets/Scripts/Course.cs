using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Course : MonoBehaviour
{
    private Timetable tt;
    [SerializeField] TextMeshProUGUI peopleNumText;
    
    // Start is called before the first frame update
    void Start()
    {
        tt = GameObject.Find("TimetableManager").GetComponent<Timetable>();
        StartCoroutine(CousePeople());
    }

    public void Check2()
    {
        ImageChance(2,0);
    }

    public void Check3()
    {
        ImageChance(3,2);
    }

    IEnumerator CousePeople()
    {
        int peopleNum = 0;
        while (peopleNum < 50)
        {
            yield return new WaitForSeconds(1);
            peopleNum += 5;
            peopleNumText.text = peopleNum.ToString() + "/50";
        }
        yield return new WaitForSeconds(1);
    }

    private void ImageChance(int i, int x)
    {
        Image thisImage = this.GetComponent<Image>();

        for (int j = 0; j < i;j++)
        {
            Image otherImage = tt.week1[x + j].GetComponent<Image>();
            otherImage.sprite = thisImage.sprite;
        }
    }


}
