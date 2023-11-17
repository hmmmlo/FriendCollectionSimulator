using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] TextMeshProUGUI friendTxt;
    private SceneLoader _scene;

    private int friendCount;

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
            Win();
        }
    }

    void Win()
    {
        _scene.LoadScene("3_Win");
    }

    void Lose()
    {
        _scene.LoadScene("2_Lose");
    }
}
