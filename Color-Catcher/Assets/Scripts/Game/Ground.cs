using UnityEngine;

public class Ground : MonoBehaviour
{
    public AudioSource audioSource;
    Stats stats;
    void Start(){
        stats = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Stats>();
    }
    void OnTriggerEnter2D(Collider2D collider){
        Destroy(collider.gameObject);
        stats.lossHeart();
        audioSource.Play();
    }
}
