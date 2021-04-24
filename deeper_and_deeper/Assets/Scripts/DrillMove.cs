using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrillMove : MonoBehaviour
{
    private float moveInput;
    private float moveInput1;
    public float Speed = 20.0f;
    private Rigidbody2D rb;
    private bool isMove;
    
    public GameObject Enemy;
    public Text distText;
    private float dist;

    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        isMove = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(gameObject.transform.position, Enemy.transform.position);
        int dist2 = (int)dist;
        distText.text = "Distance:\n " + dist2.ToString() + "m";


        if (isMove)
        {
            if (Input.GetKey(KeyCode.S))
            {
                direction = Vector2.down;
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                direction = Vector2.left;
                transform.rotation = Quaternion.Euler(0, 0, -90);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                direction = Vector2.right;
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            else
            {
                direction = Vector2.zero;
            }
            transform.Translate(direction * Speed * Time.deltaTime, Space.World);
        }
    }

    public void isStart(bool isTrue)
    {
        Debug.Log("isStart");   
        isMove = isTrue;
    }
}
