using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    LevelController _lvlController;

    [Header("Timer")]
    int _timePlayed = 60;
    TextMeshProUGUI _timer;

    private void Awake()
    {
        _timer = GameObject.FindGameObjectWithTag("TimerText").GetComponent<TextMeshProUGUI>();
        _lvlController = GameObject.FindGameObjectWithTag("LevelController").GetComponent<LevelController>();

        StartCoroutine(GameCounter());
    }

    IEnumerator GameCounter()
    {
        WaitForSeconds wfs = new WaitForSeconds(1);
        while (true)
        {
            _timer.text = _timePlayed.ToString();
            yield return wfs;
            _timePlayed--;
        }
    }

    private void Update()
    {
        if (_timePlayed <= 0)
        {
            _lvlController.Lose();
        }
    }
}
