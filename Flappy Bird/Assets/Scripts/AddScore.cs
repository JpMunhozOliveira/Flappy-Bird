using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    [SerializeField] private AudioClip score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Bird")
        {
            GameManager.instance.playSound(score);
            Score.score++;
        }
    }
}
