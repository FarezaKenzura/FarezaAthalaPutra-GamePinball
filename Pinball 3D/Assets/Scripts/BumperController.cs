using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public float multiplier;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ball")
        {
            Rigidbody ballRig = col.gameObject.GetComponent<Rigidbody>();
            ballRig.velocity *= multiplier;
            
            Renderer render = gameObject.GetComponent<Renderer>();
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            render.material.color = randomColor;

            anim.SetTrigger("hit");
        }
    }
}
