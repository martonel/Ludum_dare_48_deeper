using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text img;
    public float speed = 1f;
    public AnimationCurve curve;

    private int coin;
    public Text coinText;

    public GameObject player;
    public GameObject bomb;
    public Animator anim;

    private void Start()
    {
        coinText.text = "";
    }

    private void Update()
    {
        if(coin >= 10)
        {
            anim.SetBool("isTrue", false);
            anim.SetBool("isBomb", true);
        }
        else
        {
            anim.SetBool("isBomb", false);
        }
    }
    public int GetCoin()
    {
        return coin;
    }
    public void AddCoin(int number)
    {
        coin += number;
        coinText.text = coin.ToString(); 
        StartCoroutine(FadeIn());
    }
    public void SubCoin(int number)
    {
        coin -= number;
        coinText.text = coin.ToString();
        StartCoroutine(FadeIn());
    }
    IEnumerator FadeIn()
    {
        float t = 1f;
        while (t > 0f)
        {
            t -= Time.deltaTime * speed;
            float a = curve.Evaluate(t);
            img.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }
    }


    public void DroppBomb()
    {
        Instantiate(bomb, player.transform.position, Quaternion.identity);
    }
    public void isStarted()
    {
        anim.SetBool("isTrue", true);
    }
}
