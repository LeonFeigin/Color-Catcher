using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public Vector3 move;
    public float speed = 5f;

    public float RotationSpeed = 1;

    private Quaternion startRotation; 
    private Quaternion endRotation;
    private Quaternion initialRotation;
    private Quaternion flippedRotation;
    private float rotationProgress;
    int num;

    public bool mobile = true;
    public bool CanPlay = true;
    public GameObject deathScreen;

    [HideInInspector] public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        initialRotation = startRotation = endRotation = transform.rotation ;
        flippedRotation = Quaternion.Euler( 0, 180, 0 ) * transform.rotation ;
        rotationProgress = 1 ;
    }


    // Update is called once per frame
    void Update()
    {
        if(!mobile && CanPlay){
            move.x = Input.GetAxis("Horizontal");
        }

        transform.position = transform.position + move * speed * Time.deltaTime;

        if(transform.position.x > 7){
            transform.position = new Vector3(7f,-3.4f,0.1f);
        }
        if(transform.position.x < -7){
            transform.position = new Vector3(-7f,-3.4f,0.1f);
        }


        if(move.x > 0){num = 2; anim.SetBool("IsRunning", true);}
        if(move.x < 0){num =1; anim.SetBool("IsRunning", true);}
        if(!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && !mobile){
            anim.SetBool("IsRunning", false);
        }
        TurnAroundLerp();

        

        
        
    }

    void TurnAroundLerp()
    {
        if( num ==1 && transform.rotation.y == 0)
        {
            startRotation = initialRotation ;
            endRotation = flippedRotation ;
            rotationProgress = 1 - rotationProgress;
        }
        else if( num==2 && transform.rotation.y == -1)
        {
            startRotation = flippedRotation ;
            endRotation = initialRotation ;
            rotationProgress = 1 - rotationProgress;
        }
        
        rotationProgress = Mathf.Clamp01( rotationProgress + RotationSpeed * Time.deltaTime ) ;
        transform.rotation = Quaternion.Slerp( startRotation, endRotation, rotationProgress ) ;
    }

    public void Died(){
        move.x = 0;
        CanPlay = false;
        anim.SetBool("IsDed", true);
        deathScreen.SetActive(true);
    }
}
