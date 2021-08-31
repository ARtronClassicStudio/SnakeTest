using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public ConfigSnake configSnake;
    public AnimationClip clip;
    public UnityEvent EndTexts;
    private Animation anim;
    private Text text;
    private bool actived;
    private int length;

    private void Start()
    {
        text = GetComponent<Text>();
        anim = GetComponent<Animation>();
    }

    public void RunAnimation()
    {
        actived = true;
        anim.CrossFade(clip.name);
    }



    private void Update()
    {
        if (!anim.isPlaying & actived)
        {
            if (length <= configSnake.texts.Length)
            {
              
                length++;
                text.text = configSnake.texts[length];
                anim.CrossFade(clip.name);

            }


            if (length >= configSnake.texts.Length -1)
            {
                EndTexts.Invoke();
                actived = false;
            }

        }
    }

}
