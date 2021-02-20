// Digx7
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInputManager : MonoBehaviour {
    /* Description --
    *  This script will handel the player inputs using the new input manager package
    *  This should be what every thing else in the scene refrences when getting the player input
    */

    [SerializeField] private Player Player;                  // This references the input action map

    [SerializeField] private UnityEvent Accelerate;
    [SerializeField] private FloatEvent Rotate;
    [SerializeField] private UnityEvent Laser;
    [SerializeField] private UnityEvent Claw;
    [SerializeField] private UnityEvent DubstepGun;


    // --- Updates -------------------------------------

    public void Awake() {
        Player = new Player();             // This is needed to set up the input action map

        BindInputs();
    }

    // --- BindingInputs ----------------------------------

    // This script will bind the inputs on the Input action map to the needed script
    public void BindInputs() {
        //Player.Character.Move.performed += ctx => this.setMoveDirection(ctx.ReadValue<Vector2>()); // This permantly binds the given inputs to the script with no need for any update function
        Player.Ship.Accelerate.performed += ctx => Accelerate.Invoke();
        Player.Ship.Rotate.performed += ctx => Rotate.Invoke(ctx.ReadValue<float>());
        Player.Ship.Laser.performed += ctx => Laser.Invoke();
        Player.Ship.Claw.performed += ctx => Claw.Invoke();
        Player.Ship.DubstepGun.performed += ctx => DubstepGun.Invoke();
    }

    // --- Enable/Disable --------------------------------

    // This will enable the Input Action Map
    private void OnEnable() {
        Player.Enable();
    }

    // This will enable the Input Action Map
    private void OnDisable() {
        Player.Disable();
    }
}
