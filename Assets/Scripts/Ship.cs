using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;
    [Space]
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject ClawSpawnObject;
    [SerializeField] private Transform ClawSpawnPoint;
    [SerializeField] private GameObject LaserSpawnObject;
    [SerializeField] private Transform LaserSpawnPoint;
    [SerializeField] private GameObject DubstepGunSpawnObject;
    [SerializeField] private Transform DubstepGunSpawnPoint;

    private Vector3 rotationAxis;
    private float rotation;

    public void Awake(){
      rotationAxis = new Vector3(0,1,0);
    }

    public void FixedUpdate(){
      RotationFunct();
    }

    public void Move(){
      rb.AddForce(transform.right * movementSpeed * Time.deltaTime);
    }

    public void Rotate(float input){
       rotation = input;
    }

    public void Claw(){
      Instantiate(ClawSpawnObject, ClawSpawnPoint);
    }

    public void Laser(){
      Instantiate(LaserSpawnObject, LaserSpawnPoint);
    }

    public void DubstepGun(){
      Instantiate(DubstepGunSpawnObject, DubstepGunSpawnPoint);
    }

    private void RotationFunct(){
      rotationAxis.y = rotation * rotationSpeed;
      Quaternion deltaRotation = Quaternion.Euler(rotationAxis * Time.deltaTime);
      rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
