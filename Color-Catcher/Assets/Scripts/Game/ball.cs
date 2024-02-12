using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rg;
    Stats stats;
    
    void Start()
    {
        stats = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<Stats>();
        rg = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(stats.pm.CanPlay){
            rg.gravityScale = 0.5f;
        }else{
            rg.gravityScale = 0;
            rg.velocity = new Vector2(0,0);
        }
    }
}
