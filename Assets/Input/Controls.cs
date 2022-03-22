// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
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
                    ""name"": ""Fire 1"",
                    ""type"": ""Button"",
                    ""id"": ""fac5684f-00b4-47ae-9371-6f13e2f23647"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire 2"",
                    ""type"": ""Button"",
                    ""id"": ""e2668300-0c48-429a-aad4-76d88aa77828"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire 3"",
                    ""type"": ""Button"",
                    ""id"": ""7c3b4a8c-d1fe-4214-8eff-0053f699d26a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aiming"",
                    ""type"": ""Value"",
                    ""id"": ""b5c5e04c-8384-4491-a638-cff07628b7dc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
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
                    ""action"": ""Fire 1"",
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
                    ""action"": ""Fire 2"",
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
                    ""action"": ""Fire 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95fbe89b-7a4e-4f21-ad2e-a65b10e0092a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""471910cb-0fb5-441c-b0d9-4578a5381272"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""64d73baa-ba05-490c-a1d1-9b84b9010a17"",
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
                    ""id"": ""67644b43-00dc-43ae-b36e-724c24f1c4a8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fd78c322-ee2f-4f8c-90f3-cc7f52ce9c91"",
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
                    ""id"": ""1f064a19-aa27-45bb-957e-2b8d8daecdc1"",
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
        m_Cannons_Fire1 = m_Cannons.FindAction("Fire 1", throwIfNotFound: true);
        m_Cannons_Fire2 = m_Cannons.FindAction("Fire 2", throwIfNotFound: true);
        m_Cannons_Fire3 = m_Cannons.FindAction("Fire 3", throwIfNotFound: true);
        m_Cannons_Aiming = m_Cannons.FindAction("Aiming", throwIfNotFound: true);
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

    // Cannons
    private readonly InputActionMap m_Cannons;
    private ICannonsActions m_CannonsActionsCallbackInterface;
    private readonly InputAction m_Cannons_Fire1;
    private readonly InputAction m_Cannons_Fire2;
    private readonly InputAction m_Cannons_Fire3;
    private readonly InputAction m_Cannons_Aiming;
    public struct CannonsActions
    {
        private @Controls m_Wrapper;
        public CannonsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire1 => m_Wrapper.m_Cannons_Fire1;
        public InputAction @Fire2 => m_Wrapper.m_Cannons_Fire2;
        public InputAction @Fire3 => m_Wrapper.m_Cannons_Fire3;
        public InputAction @Aiming => m_Wrapper.m_Cannons_Aiming;
        public InputActionMap Get() { return m_Wrapper.m_Cannons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CannonsActions set) { return set.Get(); }
        public void SetCallbacks(ICannonsActions instance)
        {
            if (m_Wrapper.m_CannonsActionsCallbackInterface != null)
            {
                @Fire1.started -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFire1;
                @Fire1.performed -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFire1;
                @Fire1.canceled -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFire1;
                @Fire2.started -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFire2;
                @Fire2.performed -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFire2;
                @Fire2.canceled -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFire2;
                @Fire3.started -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFire3;
                @Fire3.performed -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFire3;
                @Fire3.canceled -= m_Wrapper.m_CannonsActionsCallbackInterface.OnFire3;
                @Aiming.started -= m_Wrapper.m_CannonsActionsCallbackInterface.OnAiming;
                @Aiming.performed -= m_Wrapper.m_CannonsActionsCallbackInterface.OnAiming;
                @Aiming.canceled -= m_Wrapper.m_CannonsActionsCallbackInterface.OnAiming;
            }
            m_Wrapper.m_CannonsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire1.started += instance.OnFire1;
                @Fire1.performed += instance.OnFire1;
                @Fire1.canceled += instance.OnFire1;
                @Fire2.started += instance.OnFire2;
                @Fire2.performed += instance.OnFire2;
                @Fire2.canceled += instance.OnFire2;
                @Fire3.started += instance.OnFire3;
                @Fire3.performed += instance.OnFire3;
                @Fire3.canceled += instance.OnFire3;
                @Aiming.started += instance.OnAiming;
                @Aiming.performed += instance.OnAiming;
                @Aiming.canceled += instance.OnAiming;
            }
        }
    }
    public CannonsActions @Cannons => new CannonsActions(this);
    public interface ICannonsActions
    {
        void OnFire1(InputAction.CallbackContext context);
        void OnFire2(InputAction.CallbackContext context);
        void OnFire3(InputAction.CallbackContext context);
        void OnAiming(InputAction.CallbackContext context);
    }
}
