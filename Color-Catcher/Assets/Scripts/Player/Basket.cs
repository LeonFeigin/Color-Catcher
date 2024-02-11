using UnityEngine;
public class Basket : MonoBehaviour
{
    new SpriteRenderer renderer;
    void Start(){
        renderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeBasketColor(int color){
        if(color == 0){
            renderer.color = new Color(255,0,0);
        }
        if(color == 1){
            renderer.color = new Color(0,255,0);
        }
        if(color == 2){
            renderer.color = new Color(255,255,0);
        }
        if(color == 3){
            renderer.color = new Color(0,0,255);
        }
    }
}
