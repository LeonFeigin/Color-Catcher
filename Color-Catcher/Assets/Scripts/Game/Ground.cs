using UnityEngine;

public class Ground : MonoBehaviour
{
    Stats stats;
    void Start(){
        stats = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Stats>();
    }
    void OnTriggerEnter2D(Collider2D collider){
        Destroy(collider.gameObject);
        stats.lossHeart();
    }
}
