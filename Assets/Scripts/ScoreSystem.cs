using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreSystem : MonoBehaviour

{
    [HideInInspector] public int Score = 0;

    [SerializeField] public int SlideScore = 10;
    [SerializeField] public int UpScore = 20;

    public TextMeshProUGUI ScoreTxt;

    public GameObject restartBtn;

  
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Slide") // Arabanın yanından geçerse
        {
            Score += SlideScore;
            ScoreTxt.text = Score.ToString();

        }
        if (other.gameObject.tag == "Up") // Arabanın üstünden geçerse
        {
            Score += UpScore;
            ScoreTxt.text = Score.ToString();
        }

    }

}
