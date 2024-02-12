using UnityEngine;

public class Basket : MonoBehaviour
{
    Stats stats;
    new SpriteRenderer renderer;
    void Start(){
        stats = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Stats>();
        renderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collider){
        renderer.color = collider.GetComponent<SpriteRenderer>().color;
        Destroy(collider.gameObject);
        stats.score++;
        stats.difficultyScore++;
    }
}
