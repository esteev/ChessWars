using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warhead : MonoBehaviour
{
    private static Warhead instance;
    public static Warhead Instance { get; private set; }

    void Awake()
    {
        Instance = this;
        //    DontDestroyOnLoad(gameObject);

        if (PlayerPrefs.HasKey("First"))
        {

        }
        else
        {
            FirstRun();
        }
    }

    void FirstRun()
    {
        Save();
    }

    public void Save()
    {
        PlayerPrefs.SetInt("First", 1);
    }
}
