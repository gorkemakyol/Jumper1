using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{

    public Canvas loseCanvas;
    ScoreSystem scoreSystem;
    public Text lastScoreTxt;
    public GameObject restartBtn;

    AudioSource loseEffect;

    private void Start()
    {
        scoreSystem = GameObject.Find("İnGamePlayers").transform.GetChild(0).GetComponent<ScoreSystem>();
        loseEffect = GameObject.Find("SoundEffects").transform.GetChild(0).gameObject.GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cubes")
        {
            loseEffect.Play();
            loseCanvas.enabled = true;

            lastScoreTxt.text = "Oyun Bitti! Skor: " + scoreSystem.Score.ToString();
            Time.timeScale = 0;

        }

    }



}
