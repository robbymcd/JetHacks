using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player player;
    public GameObject menuButton;
    public GameObject retryButton;
    public DistanceManager distanceManager;
    public GameObject distanceTraveled;
    public GameObject distance;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    public void Play()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        menuButton.SetActive(false);
        retryButton.SetActive(false);
        distanceTraveled.SetActive(false);
        distance.SetActive(false);
        distanceManager.distance = 0f;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        menuButton.SetActive(true);
        retryButton.SetActive(true);
        distanceTraveled.SetActive(true);
        distance.SetActive(true);
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
