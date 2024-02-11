using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 move;
    public float speed = 5f;

    public float RotationSpeed = 1;

    private Quaternion startRotation; 
    private Quaternion endRotation;
    private Quaternion initialRotation;
    private Quaternion flippedRotation;
    private float rotationProgress;

    void Start()
    {
        initialRotation = startRotation = endRotation = transform.rotation ;
        flippedRotation = Quaternion.Euler( 0, 180, 0 ) * transform.rotation ;
        rotationProgress = 1 ;
    }


    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");

        transform.position = transform.position + move * speed * Time.deltaTime;

        if(transform.position.x > 7){
            transform.position = new Vector3(7f,-3.4f,0.1f);
        }
        if(transform.position.x < -7){
            transform.position = new Vector3(-7f,-3.4f,0.1f);
        }


        if(move.x > 0){}
        TurnAroundLerp();
    }

    void TurnAroundLerp()
    {
        if( Input.GetKeyDown(KeyCode.A) && transform.rotation.y == 0)
        {
            startRotation = initialRotation ;
            endRotation = flippedRotation ;
            rotationProgress = 1 - rotationProgress;
        }
        else if( Input.GetKeyDown(KeyCode.D) && transform.rotation.y != 0)
        {
            startRotation = flippedRotation ;
            endRotation = initialRotation ;
            rotationProgress = 1 - rotationProgress;
        }
        
        rotationProgress = Mathf.Clamp01( rotationProgress + RotationSpeed * Time.deltaTime ) ;
        transform.rotation = Quaternion.Slerp( startRotation, endRotation, rotationProgress ) ;
    }
}
