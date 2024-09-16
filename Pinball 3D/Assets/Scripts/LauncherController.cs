using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;

    public float maxTimeHold;
    public float maxForce;

    private bool isHold;

    private void Start()
    {
        isHold = false;
    }
    public void OnCollisionStay(Collision col)
    {
        if(col.collider == bola)
        {
            ReadInput(bola);
        }
    }

    public void ReadInput(Collider other)
    {
        if(Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(other));

            Renderer render = gameObject.GetComponent<Renderer>();
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            render.material.color = randomColor;
        }
    }

    private IEnumerator StartHold(Collider other)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while(Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);
		
            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        other.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }
}
