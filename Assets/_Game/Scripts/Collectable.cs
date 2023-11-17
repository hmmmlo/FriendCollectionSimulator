using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] AudioClip _collectSound;
    private LevelController _lvlController;

    private void Awake()
    {
        _lvlController = GameObject.FindGameObjectWithTag("LevelController").GetComponent<LevelController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
            AudioHelper.PlayClip2D(_collectSound, .2f);

            _lvlController.UpdateFriends();
        }
    }
}
