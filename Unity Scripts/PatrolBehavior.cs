using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBehavior : MonoBehaviour
{
    public float speed;
    public float rayDist;
    private bool movingLeft;
    public Transform groundDetect;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        RaycastHit2D groundCheck = Physics2D.Raycast(groundDetect.position, Vector2.down, rayDist);

        if (groundCheck.collider == false)
        {
            if (movingLeft)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingLeft = true;
            }
        }
    }
}
