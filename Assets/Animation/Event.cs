using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public float donusHizi;
    public float hiz;
    Animator animator;
    void Start()
    {
        donusHizi = 0.5f;
        hiz = 3.5f;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))

        {
            animator.SetBool("isWalk", true);
            transform.Translate(Vector3.forward * hiz* Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A))

        {
            animator.SetBool("isWalk", true);
            transform.Rotate(new Vector3(0, -90*donusHizi*Time.deltaTime, 0));
            transform.Translate(new Vector3(hiz*Time.deltaTime,0,0));
        }

        else if (Input.GetKey(KeyCode.D))

        {
            animator.SetBool("isWalk", true);
            transform.Rotate(new Vector3(0, 90 * donusHizi * Time.deltaTime, 0));
            transform.Translate(new Vector3(hiz * Time.deltaTime, 0, 0));
        }

        else
        {
            animator.SetBool("isWalk", false);
        }
    }

}
