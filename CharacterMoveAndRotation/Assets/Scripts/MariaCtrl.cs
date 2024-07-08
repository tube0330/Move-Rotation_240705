using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MariaCtrl : MonoBehaviour
{
    [SerializeField] Transform tr;
    [SerializeField] Animator animator;

    [SerializeField] float moveSpeed = 7f;
    [SerializeField] float turnSpeed = 150f;

    float h = 0f, v = 0f, r = 0f;

    void Start()
    {
        tr = transform;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        r = Input.GetAxis("Mouse X");

        tr.Translate(Vector3.right * h * Time.deltaTime * moveSpeed);
        {
            animator.SetFloat("posX", h, 0.1f, Time.deltaTime);
        }
        tr.Translate(Vector3.forward * v * Time.deltaTime * moveSpeed);
        {
            animator.SetFloat("posY", v, 0.1f, Time.deltaTime);
        }
        tr.Rotate(Vector3.up * r * Time.deltaTime * turnSpeed);

    }
}
