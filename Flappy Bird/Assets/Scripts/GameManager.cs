using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private AudioSource audios;
    [SerializeField] private AudioClip pauseS;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        audios = GetComponent<AudioSource>();
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void playSound(AudioClip clip)
    {
        audios.PlayOneShot(clip);
    }

    public void pause()
    {
        if (!gameOverCanvas.activeSelf)
        {
            playSound(pauseS);

            if (Time.timeScale == 0)
            {
                pauseCanvas.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                pauseCanvas.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
