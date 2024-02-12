using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    [Header("Stats")]
    public int hearts = 3;
    public float score = 0;
    public float difficulty = 0;
    public float difficultyScore = 0;
    [Header("Objects")]
    public TMP_Text text;
    public Image[] heartsImages;
    public Sprite lostHeart;
    public PlayerMovement pm;


    void Update(){
        text.text = "Score:\n" + score;
        if(difficultyScore / 10 == 1){
            difficultyScore = 0;
            difficulty += 0.25f;
        }
    }

    public void lossHeart(){
        hearts--;
        heartsImages[hearts].sprite = lostHeart;
        if(hearts == 0){
            pm.Died();
        }
    }

    

    
    
}
