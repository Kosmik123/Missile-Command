//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Cannons"",
            ""id"": ""ff891f9d-6b35-4bdb-a323-dfcdb9a8ddd8"",
            ""actions"": [
                {
                    ""name"": ""Fire Left"",
                    ""type"": ""Button"",
                    ""id"": ""fac5684f-00b4-47ae-9371-6f13e2f23647"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire Center"",
                    ""type"": ""Button"",
                    ""id"": ""e2668300-0c48-429a-aad4-76d88aa77828"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire Right"",
                    ""type"": ""Button"",
                    ""id"": ""7c3b4a8c-d1fe-4214-8eff-0053f699d26a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""96c5a319-5b61-46f2-a2ed-69ae3080ce7a"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88a751f5-a11d-4cc6-ac8f-6b1192fb85e0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f3f028d-f790-4094-8001-f0b1e89308e7"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Center"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f9790aa-18ea-4cb6-a424-2a16ea6d9493"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""443b5df8-baa0-4b95-8846-1f5a23035e8b"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Center"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f65a07a-2ecd-4b1e-88ee-0d1a6f891a84"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Crosshair"",
            ""id"": ""a47da700-75df-49fb-861d-71edd9b58889"",
            ""actions"": [
                {
                    ""name"": ""Aiming"",
                    ""type"": ""Value"",
                    ""id"": ""3a2ae25b-884c-4e2a-9042-0fc9d643fb73"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""578be764-f08d-451f-84e1-6c3d44f43470"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.5,y=0.5)"",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""f40c016f-cf80-4c52-9c0a-4a2d7c790406"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=5,y=5)"",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""aaa0a49d-97ca-4feb-8f50-090b3c8ee6b7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8834ba31-e2af-4796-b80b-23dd95278a36"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5b201e8d-6f33-4e94-b3ce-35ee0e3bc4ce"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c530dbc6-9448-4bf1-bdf3-acbf6f1cb172"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Cannons
        m_Cannons = asset.FindActionMap("Cannons", throwIfNotFound: true);
        m_Cannons_FireLeft = m_Cannons.FindAction("Fire Left", throwIfNotFound: true);
        m_Cannons_FireCenter = m_Cannons.FindAction("Fire Center", throwIfNotFound: true);
        m_Cannons_FireRight = m_Cannons.FindAction("Fire Right", throwIfNotFound: true);
        // Crosshair
        m_Crosshair = asset.FindActionMap("Crosshair", throwIfNotFound: true);
        m_Crosshair_Aiming = m_Crosshair.FindAction("Aiming", throwIfNotFound: true);
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

    // Cannons
    private readonly InputActionMap m_Cannons;
    private ICannonsActions m_CannonsActionsCallbackInterface;
    private readonly InputAction m_Cannons_FireLeft;
    private readonly InputAction m_Cannons_FireCenter;
    private readonly InputAction m_Cannons_FireRight;
    public struct CannonsActions
    {
        private @Controls m_Wrapper;
        public CannonsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @FireLeft => m_Wrapper.m_Cannons_FireLeft;
        public InputAction @FireCenter => m_Wrapper.m_Cannons_FireCenter;
        public InputAction @FireRight => m_Wrapper.m_Cannons_FireRight;
        public InputActionMap Get() { return m_Wrapper.m_Cannons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CannonsActions set) { return set.Get(); }
        public void SetCallbacks(ICannonsActions instance)
        {
            if (m_Wrapper.m_CannonsActionsCallbackInterface != null)
            {
                @FireLeft.started -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFireLeft;
                @FireLeft.performed -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFireLeft;
                @FireLeft.canceled -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFireLeft;
                @FireCenter.started -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFireCenter;
                @FireCenter.performed -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFireCenter;
                @FireCenter.canceled -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFireCenter;
                @FireRight.started -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFireRight;
                @FireRight.performed -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFireRight;
                @FireRight.canceled -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFireRight;
            }
            m_Wrapper.m_CannonsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FireLeft.started += instance.OnFireLeft;
                @FireLeft.performed += instance.OnFireLeft;
                @FireLeft.canceled += instance.OnFireLeft;
                @FireCenter.started += instance.OnFireCenter;
                @FireCenter.performed += instance.OnFireCenter;
                @FireCenter.canceled += instance.OnFireCenter;
                @FireRight.started += instance.OnFireRight;
                @FireRight.performed += instance.OnFireRight;
                @FireRight.canceled += instance.OnFireRight;
            }
        }
    }
    public CannonsActions @Cannons => new CannonsActions(this);

    // Crosshair
    private readonly InputActionMap m_Crosshair;
    private ICrosshairActions m_CrosshairActionsCallbackInterface;
    private readonly InputAction m_Crosshair_Aiming;
    public struct CrosshairActions
    {
        private @Controls m_Wrapper;
        public CrosshairActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aiming => m_Wrapper.m_Crosshair_Aiming;
        public InputActionMap Get() { return m_Wrapper.m_Crosshair; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CrosshairActions set) { return set.Get(); }
        public void SetCallbacks(ICrosshairActions instance)
        {
            if (m_Wrapper.m_CrosshairActionsCallbackInterface != null)
            {
                @Aiming.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnAiming;
                @Aiming.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnAiming;
                @Aiming.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnAiming;
            }
            m_Wrapper.m_CrosshairActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Aiming.started += instance.OnAiming;
                @Aiming.performed += instance.OnAiming;
                @Aiming.canceled += instance.OnAiming;
            }
        }
    }
    public CrosshairActions @Crosshair => new CrosshairActions(this);
    public interface ICannonsActions
    {
        void OnFireLeft(InputAction.CallbackContext context);
        void OnFireCenter(InputAction.CallbackContext context);
        void OnFireRight(InputAction.CallbackContext context);
    }
    public interface ICrosshairActions
    {
        void OnAiming(InputAction.CallbackContext context);
    }
}
