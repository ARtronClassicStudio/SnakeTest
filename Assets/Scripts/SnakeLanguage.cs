using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class SnakeLanguage : MonoBehaviour
{
    public ConfigSnake configSnake;
    public Player player;
    public Text textScrole;
    public GameObject prefab;
    public Transform pointSpawn;
    public AnimationClip clip;
    public List<Transform> transforms;
    private Animation anim;
    private Transform target;
    private bool addCollider = false;
    public UnityEvent OnDead;

    private void Start()
    {
        configSnake.score = 0;
        configSnake.dead = false;
        target = new GameObject("Trails").transform;
        anim = GetComponent<Animation>();
   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Apple")
        {

            if (transforms.Count < 1)
            {

                Spawn(pointSpawn.transform);
            }
            else
            {
                Spawn(transforms[transforms.Count - 1]);
            }

            if(transforms.Count > 10)
            {
                addCollider = true;
            }
        }
        else
        {
            player.enabled = false;
            configSnake.dead = true;
            OnDead.Invoke();
        }

        anim.CrossFade(clip.name);

    }

    void Spawn(Transform pose)
    {
        var p = Instantiate(prefab, pose.position, Quaternion.identity);
        p.transform.SetParent(target);
        p.GetComponent<Trail>().point = pose;
        transforms.Add(p.transform);
        configSnake.score++;
        textScrole.text = "Score:"+configSnake.score.ToString();
        if (addCollider)
        {
            p.AddComponent<CircleCollider2D>().radius = 0.6f;
        }
    }


}

