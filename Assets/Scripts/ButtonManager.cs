using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

     public void restartGame() // Oyunu yeniden ba�lat
    {
        if (SceneManager.GetActiveScene().name == "Game") // E�er ilk seviyedeyse
        {
            Time.timeScale = 1; // Zaman� ba�lar
            SceneManager.LoadScene("Game"); // �lk level sahnesini y�kle
        }
        else if (SceneManager.GetActiveScene().name == "Game 2")
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Game 2");
        }
    }
    
    public Slider soundSlider;
    public AudioSource GameMusic;

    public Canvas setCanvas;

    public void changeVolume()
    {
        GameMusic.volume = soundSlider.value;
    }

    public void openSetCanvas()
    {
        setCanvas.enabled = true;
    }
    public void closeSetCanvas()
    {
        setCanvas.enabled = false;
    }

    public void startLevel1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void startLevel2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game 2");
    }
    public void backMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");

    }

    public void quitGame()
    {
        Application.Quit();
    }

   
}
