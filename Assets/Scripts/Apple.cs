using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public ConfigSnake configSnake;
    private Animator anim;
    private Collider2D col;

    private void Start()
    {
        col = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.CrossFade("DestroyOn",1);
        col.enabled = false;
        StartCoroutine(ReturnApple());
    }


   IEnumerator ReturnApple()
    {
        yield return new WaitForSeconds(configSnake.retunApple);
        anim.CrossFade("DestroyOff", 1);
        col.enabled = true;

    }

}
