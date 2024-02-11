using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Stats stats;
    public TMP_Text currentScore;
    public TMP_Text bestScore;

    void Start(){
        float best = PlayerPrefs.GetFloat("BestScore");
        currentScore.text = "Your Score Was: " + stats.score;
        if(stats.score > best){
            PlayerPrefs.SetFloat("BestScore", stats.score);
            bestScore.text = "Your Best score: " + stats.score;
        }else{
            bestScore.text = "Your Best score: " + best;
        }
        
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
