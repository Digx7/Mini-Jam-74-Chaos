// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""Ship"",
            ""id"": ""086cfd23-8460-4640-8a09-6660ad075e55"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""16d01734-0839-4d11-8425-0040eecb6084"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8b9e6cc5-cd2e-482f-b2cd-a6bc2d2df106"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Claw"",
                    ""type"": ""Button"",
                    ""id"": ""23232f20-a4b7-4d01-8313-18b0e5682c85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Laser"",
                    ""type"": ""Button"",
                    ""id"": ""0dadac3d-f316-4e4f-8cd3-404d42261887"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DubstepGun"",
                    ""type"": ""Button"",
                    ""id"": ""05dd2645-81fc-4861-be77-a5724f323148"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1c52288f-e18c-4912-9ebc-e39c0255ddbb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""A/X"",
                    ""id"": ""b2bc1a76-55e7-40c8-854b-f2bb687130a6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1a11cf45-6f75-4b49-a0ea-fc334d41f725"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9bca28d7-b289-401c-a5e6-aac5df44f021"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""89456544-0d18-4185-9f19-2861ad7c776e"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Claw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c04126bc-813e-4a95-b190-c0e467849d50"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Laser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6558377a-5234-4aef-a9ee-c149f6045632"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DubstepGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_Accelerate = m_Ship.FindAction("Accelerate", throwIfNotFound: true);
        m_Ship_Rotate = m_Ship.FindAction("Rotate", throwIfNotFound: true);
        m_Ship_Claw = m_Ship.FindAction("Claw", throwIfNotFound: true);
        m_Ship_Laser = m_Ship.FindAction("Laser", throwIfNotFound: true);
        m_Ship_DubstepGun = m_Ship.FindAction("DubstepGun", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Ship
    private readonly InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private readonly InputAction m_Ship_Accelerate;
    private readonly InputAction m_Ship_Rotate;
    private readonly InputAction m_Ship_Claw;
    private readonly InputAction m_Ship_Laser;
    private readonly InputAction m_Ship_DubstepGun;
    public struct ShipActions
    {
        private @Player m_Wrapper;
        public ShipActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Ship_Accelerate;
        public InputAction @Rotate => m_Wrapper.m_Ship_Rotate;
        public InputAction @Claw => m_Wrapper.m_Ship_Claw;
        public InputAction @Laser => m_Wrapper.m_Ship_Laser;
        public InputAction @DubstepGun => m_Wrapper.m_Ship_DubstepGun;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                @Accelerate.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnAccelerate;
                @Rotate.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Claw.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnClaw;
                @Claw.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnClaw;
                @Claw.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnClaw;
                @Laser.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnLaser;
                @Laser.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnLaser;
                @Laser.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnLaser;
                @DubstepGun.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnDubstepGun;
                @DubstepGun.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnDubstepGun;
                @DubstepGun.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnDubstepGun;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Claw.started += instance.OnClaw;
                @Claw.performed += instance.OnClaw;
                @Claw.canceled += instance.OnClaw;
                @Laser.started += instance.OnLaser;
                @Laser.performed += instance.OnLaser;
                @Laser.canceled += instance.OnLaser;
                @DubstepGun.started += instance.OnDubstepGun;
                @DubstepGun.performed += instance.OnDubstepGun;
                @DubstepGun.canceled += instance.OnDubstepGun;
            }
        }
    }
    public ShipActions @Ship => new ShipActions(this);
    public interface IShipActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnClaw(InputAction.CallbackContext context);
        void OnLaser(InputAction.CallbackContext context);
        void OnDubstepGun(InputAction.CallbackContext context);
    }
}
