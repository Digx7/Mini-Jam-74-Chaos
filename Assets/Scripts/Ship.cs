using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ship : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;
    [Space]
    [SerializeField] private UnityEvent LevelCompleted;
    [Space]
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject ClawSpawnObject;
    [SerializeField] private Transform ClawSpawnPoint;
    [SerializeField] private GameObject LaserSpawnObject;
    [SerializeField] private Transform LaserSpawnPoint;
    [SerializeField] private GameObject DubstepGunSpawnObject;
    [SerializeField] private Transform DubstepGunSpawnPoint;
    [SerializeField] private GameObject HurtParticles;
    [SerializeField] private GameObject DeathParticles;
    [SerializeField] private GameObject GateParticles;

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

    public void shipTookDamage(){
      Instantiate(HurtParticles, this.gameObject.transform.position, Quaternion.identity);
    }

    public void shipDied(){
      Instantiate(DeathParticles, this.gameObject.transform.position, Quaternion.identity);
    }

    public void shipLeft(){
      Instantiate(GateParticles, this.gameObject.transform.position, Quaternion.identity);
      LevelCompleted.Invoke();
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
