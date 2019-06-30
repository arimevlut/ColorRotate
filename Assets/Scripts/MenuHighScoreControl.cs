using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHighScoreControl : MonoBehaviour
{
    [SerializeField]
    private Text Highest_Point_Text;

    float Highest_Point;

    void Update()
    {
        Highest_Point = PlayerPrefs.GetFloat("Highest_Point");

        Highest_Point_Text.text = "HIGHEST POINT : " + Highest_Point.ToString();
    }
}
