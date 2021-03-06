//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scenes/InputActionSample.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActionSample : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActionSample()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActionSample"",
    ""maps"": [
        {
            ""name"": ""Action2D"",
            ""id"": ""16f8541b-aa20-4b72-969d-3f8a9f19b3da"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c9d970d7-8df0-42cc-a2d8-9da3135de0cf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""c0aa369c-fd89-43c0-a2ac-6d0bdd0af344"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bc195109-b009-4921-bdd1-e8f4a5ce13d8"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cc1f4419-35ca-436f-add6-9ddae910650e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cfd5f18c-106c-4d67-b2bb-9b44d7afdf27"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7b6932b8-9c62-4aca-8802-eaf6f5d6bcf2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dd844b3f-fd3b-42cc-8bf6-e98cb8890f3b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""13eda366-4e5b-4e27-a01e-63722c1a31a9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0460a015-a85d-4e41-8b4c-29a11828f9dd"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d1234c0-fb73-4a94-a421-f16482b7691d"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Action2D
        m_Action2D = asset.FindActionMap("Action2D", throwIfNotFound: true);
        m_Action2D_Move = m_Action2D.FindAction("Move", throwIfNotFound: true);
        m_Action2D_Attack = m_Action2D.FindAction("Attack", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Action2D
    private readonly InputActionMap m_Action2D;
    private IAction2DActions m_Action2DActionsCallbackInterface;
    private readonly InputAction m_Action2D_Move;
    private readonly InputAction m_Action2D_Attack;
    public struct Action2DActions
    {
        private @InputActionSample m_Wrapper;
        public Action2DActions(@InputActionSample wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Action2D_Move;
        public InputAction @Attack => m_Wrapper.m_Action2D_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Action2D; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Action2DActions set) { return set.Get(); }
        public void SetCallbacks(IAction2DActions instance)
        {
            if (m_Wrapper.m_Action2DActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Action2DActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Action2DActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Action2DActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_Action2DActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Action2DActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Action2DActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_Action2DActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public Action2DActions @Action2D => new Action2DActions(this);
    public interface IAction2DActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
