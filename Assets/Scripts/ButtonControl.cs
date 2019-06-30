using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("2 Color");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("SampleScene");
        GameManager.instance.point = 0;
    }

}
