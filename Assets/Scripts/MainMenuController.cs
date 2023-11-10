using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private AudioClip _menuMusic;

    private void Awake()
    {
        //mouse cursor allowed to move aroudn the game window
        Cursor.lockState = CursorLockMode.Confined;

        //make mouse visible
        Cursor.visible = true;
    }

    private void Start()
    {
        //play music
        if(_menuMusic != null)
        {
            AudioManager.Instance.PlayMusic(_menuMusic);
        }
    }

    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        Debug.Log("reset score");
    }

    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }
}
