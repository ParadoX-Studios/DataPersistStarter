using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerName;
    public static int highScore;

    void Start()
    {
        highScore = MainManager.highScore;
    }



    public void StartNew()
    {
        Debug.Log("Player Name is : " + playerName.text);
        MainManager.playerNameStr = playerName.text;

        SceneManager.LoadScene(1);
    }
}
