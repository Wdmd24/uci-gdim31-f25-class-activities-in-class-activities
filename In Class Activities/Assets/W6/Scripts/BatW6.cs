using UnityEngine;
using UnityEngine.AI;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    public Vector2 pl_pos;
    
    public float spd;
    
    public void Start()
    {
        SetDestin(gameObject.transform.position);
    }

    void Update()
    {
          transform.position = Vector2.MoveTowards(
            transform.position,
            pl_pos,
            spd * Time.deltaTime
        );
    }

    public void SetDestin(Vector2 sd)
    {
        pl_pos=sd;
        Debug.Log("ss");
    }
}
