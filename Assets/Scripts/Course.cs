using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Course : MonoBehaviour
{
    private Timetable tt;
    
    // Start is called before the first frame update
    void Start()
    {
        tt = GameObject.Find("TimetableManager").GetComponent<Timetable>();
    }

    public void Check2()
    {
        ImageChance(2);
    }

    public void Check3()
    {
        ImageChance(3);
    }

    private void ImageChance(int i)
    {
        Image thisImage = this.GetComponent<Image>();

        for (int j = 0; j < i;j++)
        {
            Image otherImage = tt.week1[j].GetComponent<Image>();
            otherImage.sprite = thisImage.sprite;
        }
    }


}
