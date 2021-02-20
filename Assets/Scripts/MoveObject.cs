using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody rb;

    public void FixedUpdate(){
      move();
    }

    private void move(){
      rb.AddForce(transform.forward * moveSpeed * Time.deltaTime);
    }
}
