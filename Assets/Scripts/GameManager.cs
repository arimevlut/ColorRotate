using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public int point;

    private void Awake()
    {
        MakeSingleton();
    }

    private void Start()
    {
        point = 0;
    }

    void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);           
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
}
