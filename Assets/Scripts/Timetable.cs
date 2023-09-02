using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timetable : MonoBehaviour
{
    int[] course1 = new int[8];
    int[] course2 = new int[8];
    int[] course3 = new int[8];
    int[] course4 = new int[8];
    int[] course5 = new int[8];

    void Start()
    {
        Array.Fill(course1, 0);
        Array.Fill(course2, 0);
        Array.Fill(course3, 0);
        Array.Fill(course4, 0);
        Array.Fill(course5, 0);
    }

    void Update()
    {
        
    }
}
