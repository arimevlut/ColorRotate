using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Button passButton;

    [SerializeField]
    private Text pointText;

    public string NextLevel;

    void Start()
    {
        passButton.enabled = false;
    }

    void Update()
    {
        pointText.text = "POINT : " + GameManager.instance.point.ToString();

        if (GameManager.instance.point % 10 == 0 && GameManager.instance.point != 0)
        {
            passButton.enabled = true;
        }

        else if (GameManager.instance.point%10 !=0 && GameManager.instance.point == 0)
        {
            passButton.enabled = false;
        }
    }

    public void pass_Button()
    {
        SceneManager.LoadScene(NextLevel);
    }
}
