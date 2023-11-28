using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] TextMeshProUGUI friendTxt;
    private SceneLoader _scene;

    [SerializeField] private int friendCount;

    private void Awake()
    {
        friendCount = 0;
        _scene = GetComponent<SceneLoader>();
    }

    public void UpdateFriends()
    {
        friendCount++;
        friendTxt.text = friendCount.ToString();
    }

    private void Update()
    {
        if(friendCount >= 6)
        {
            Invoke("Win", 0.2f);
        }
    }

    public void Win()
    {
        _scene.LoadScene("3_Win");
    }

    public void Lose()
    {
        Invoke("EndGame", 0.2f);
    }

    public void EndGame()
    {
        _scene.LoadScene("2_Lose");
    }
}
