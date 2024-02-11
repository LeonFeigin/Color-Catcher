using UnityEngine;

public class BallDropping : MonoBehaviour
{
    public GameObject obj;

    public Transform redHole;
    public Transform greenHole;
    public Transform yellowHole;
    public Transform blueHole;

    float time;
    public float SpawnRate = 3f;

    Vector3 pos = new Vector3(0,0,-1);

    Stats stats;

    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
        stats = GetComponent<Stats>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > time + (SpawnRate - stats.difficulty) && stats.pm.CanPlay){
            summonBall();
        }
    }

    void summonBall(){
        time = Time.time;

        float num = Random.Range(0,5);
        if(num == 1){
            GameObject temp = Instantiate(obj);
            temp.transform.position = redHole.transform.position + pos;
            temp.GetComponent<SpriteRenderer>().color = new Color(255,0,0);
        }
        if(num == 2){
            GameObject temp = Instantiate(obj);
            temp.transform.position = greenHole.transform.position + pos;
            temp.GetComponent<SpriteRenderer>().color = new Color(0,255,0);
        }
        if(num == 3){
            GameObject temp = Instantiate(obj);
            temp.transform.position = yellowHole.transform.position + pos;
            temp.GetComponent<SpriteRenderer>().color = new Color(255,255,0);
        }
        if(num == 4){
            GameObject temp = Instantiate(obj);
            temp.transform.position = blueHole.transform.position + pos;
            temp.GetComponent<SpriteRenderer>().color = new Color(0,0,255);
        }
    }
    public void test(){
        Debug.Log("e");
    }
}
