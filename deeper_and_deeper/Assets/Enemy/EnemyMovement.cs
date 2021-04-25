using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    private bool isMove = false;
    public float speed;
    private bool left_right;
    public Animator anim;
    public GameObject particle;
    public AudioSource expoldeSound;
    // Start is called before the first frame update
    void Start()
    {
        left_right = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMove)
        {
            if (left_right)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime, Space.World); 
                if (this.gameObject.transform.position.x > 4.0f)
                {
                    left_right = !left_right;
                }
            }
            else
            {

                transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);
                if (this.gameObject.transform.position.x < -4.0f)
                {
                    left_right = !left_right;
                }
            }
            transform.Translate(Vector2.down * speed/2 * Time.deltaTime, Space.World);
        }
    }


    public void isStart()
    {
        isMove = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            expoldeSound.Play();
            Instantiate(particle.gameObject, other.gameObject.transform.position, Quaternion.identity);
            StartCoroutine(WaitTime());

            other.gameObject.SetActive(false);
            if (anim != null)
            {
                anim.SetBool("isTrue", true);
            }
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(0.1f);
        expoldeSound.Play();
        yield return new WaitForSeconds(0.1f);
        expoldeSound.Play();
        yield return new WaitForSeconds(5.5f);
        int nextBuildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nextBuildIndex);
    }
}
