using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChance : MonoBehaviour
{
    [SerializeField] private List<GameObject> image = new List<GameObject>();
    [SerializeField] Image image0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ImageChance0(int i)
    {
        image0.sprite = image[i].GetComponent<Image>().sprite;
    }
}
