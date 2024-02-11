using UnityEngine;

public class MobileMove : MonoBehaviour
{
    public PlayerMovement pm;
    public Animator anim;
    void Start(){
        if(!(Application.platform == RuntimePlatform.WebGLPlayer && Application.isMobilePlatform)){
            gameObject.SetActive(false);
            pm.mobile = false;
        }
    }

    public void OnMoveRight(){
        if (pm.CanPlay)
        {
            pm.move = new Vector3(1,0,0);
            anim.SetBool("IsRunning", true);
        }
    }
    public void OnDeMoveRight(){
        if (pm.CanPlay)
        {
            pm.move = new Vector3(0,0,0);
            anim.SetBool("IsRunning", false);
        }
    }
    public void OnMoveLeft(){
        if (pm.CanPlay)
        {
            pm.move = new Vector3(-1,0,0);
            anim.SetBool("IsRunning", true);
        }
    }
    public void OnDeMoveLeft(){
        if (pm.CanPlay)
        {
            pm.move = new Vector3(0,0,0);
            anim.SetBool("IsRunning", false);
        }
    }   
}
