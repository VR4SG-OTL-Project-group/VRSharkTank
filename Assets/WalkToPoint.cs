using UnityEngine;


public class WalkToPoint : MonoBehaviour
{

    public GameObject destination;
    public GameObject npc;
    private Animator anim;
    private float speed = 1.0f; //Speed at which object moves
    private bool moving;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("WalkFWD");
        moving = true;
    }

    void Update()
    {
        //Moves the object right forever at the speed of 'Speed'
        if (moving && transform.position.z > destination.transform.position.z)
        {
            //transform.position += new Vector3(0, 0, -1 * Speed * Time.deltaTime);
        }
        else
        {
            moving = false;
            //anim.speed = 0;
            //anim.Play("Idle2walk_AllAngles");
            npc.transform.Rotate(Vector3.down, speed * Time.deltaTime);
        }
    }
}