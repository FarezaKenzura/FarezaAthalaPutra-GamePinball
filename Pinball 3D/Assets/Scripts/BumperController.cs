using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public float multiplier;
    private Animator anim;
    public AudioManager audioManager;
    public VFXManager VFXManager;

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

            audioManager.PlaySFX(col.transform.position, 0);
            VFXManager.PlayVFX(col.transform.position, 0);

            anim.SetTrigger("hit");
        }
    }
}
