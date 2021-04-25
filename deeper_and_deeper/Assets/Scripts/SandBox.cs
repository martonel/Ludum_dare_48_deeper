using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandBox : MonoBehaviour
{
    public float Timer;
    public float speed;
    public int getCoinNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer < 0.0f)
        {
            isDead();
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "drill")
        {
            Timer -= speed*Time.deltaTime;
        }
    }
    public void isDead()
    {
        if (this.gameObject.tag == "coin")
        {
            Debug.Log("coinSound is on");
            GameObject[] manager = GameObject.FindGameObjectsWithTag("gameManager");
            if (manager.Length != 0)
            {
                manager[0].GetComponent<GameManager>().AddCoin(getCoinNumber);
            }
        }
        Destroy(this.gameObject);
    }
}
