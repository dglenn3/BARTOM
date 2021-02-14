// GENERATED AUTOMATICALLY FROM 'Assets/Input/ControlBindings.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlBindings : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlBindings()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlBindings"",
    ""maps"": [
        {
            ""name"": ""Chester"",
            ""id"": ""92f14b21-ef51-4156-8268-1b9eff7f5c77"",
            ""actions"": [
                {
                    ""name"": ""Duck"",
                    ""type"": ""Button"",
                    ""id"": ""5431925d-485e-4c77-9e81-19c25cf1c108"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""2d3d0491-ca90-4ce8-b1a9-fc7e2c30eb73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""eb803ac4-b78e-45f0-9d33-eec692d4093d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""378571cb-649a-40fd-9687-475152e0d628"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleInventory"",
                    ""type"": ""Button"",
                    ""id"": ""92384686-e3bb-4021-b82d-9029c4e9d408"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""103e5687-d5a6-44a1-9552-fd714fe6847c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90a95ad3-c10b-4981-996b-b2f5ff5ae344"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbe8c4b1-9f03-41e7-a0b5-f1231633c15a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""SideScroll"",
                    ""id"": ""9539bd04-66fa-4675-838c-9f7472f309f6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""03191371-880e-4cab-9c50-dea111031948"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2b02a576-0aa1-4035-b045-f49ff340fd49"",
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
                    ""id"": ""510aacab-87e8-422c-a55e-a7016f5b8ab8"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Chester
        m_Chester = asset.FindActionMap("Chester", throwIfNotFound: true);
        m_Chester_Duck = m_Chester.FindAction("Duck", throwIfNotFound: true);
        m_Chester_Grab = m_Chester.FindAction("Grab", throwIfNotFound: true);
        m_Chester_Jump = m_Chester.FindAction("Jump", throwIfNotFound: true);
        m_Chester_Move = m_Chester.FindAction("Move", throwIfNotFound: true);
        m_Chester_ToggleInventory = m_Chester.FindAction("ToggleInventory", throwIfNotFound: true);
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

    // Chester
    private readonly InputActionMap m_Chester;
    private IChesterActions m_ChesterActionsCallbackInterface;
    private readonly InputAction m_Chester_Duck;
    private readonly InputAction m_Chester_Grab;
    private readonly InputAction m_Chester_Jump;
    private readonly InputAction m_Chester_Move;
    private readonly InputAction m_Chester_ToggleInventory;
    public struct ChesterActions
    {
        private @ControlBindings m_Wrapper;
        public ChesterActions(@ControlBindings wrapper) { m_Wrapper = wrapper; }
        public InputAction @Duck => m_Wrapper.m_Chester_Duck;
        public InputAction @Grab => m_Wrapper.m_Chester_Grab;
        public InputAction @Jump => m_Wrapper.m_Chester_Jump;
        public InputAction @Move => m_Wrapper.m_Chester_Move;
        public InputAction @ToggleInventory => m_Wrapper.m_Chester_ToggleInventory;
        public InputActionMap Get() { return m_Wrapper.m_Chester; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChesterActions set) { return set.Get(); }
        public void SetCallbacks(IChesterActions instance)
        {
            if (m_Wrapper.m_ChesterActionsCallbackInterface != null)
            {
                @Duck.started -= m_Wrapper.m_ChesterActionsCallbackInterface.OnDuck;
                @Duck.performed -= m_Wrapper.m_ChesterActionsCallbackInterface.OnDuck;
                @Duck.canceled -= m_Wrapper.m_ChesterActionsCallbackInterface.OnDuck;
                @Grab.started -= m_Wrapper.m_ChesterActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_ChesterActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_ChesterActionsCallbackInterface.OnGrab;
                @Jump.started -= m_Wrapper.m_ChesterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ChesterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ChesterActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_ChesterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ChesterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ChesterActionsCallbackInterface.OnMove;
                @ToggleInventory.started -= m_Wrapper.m_ChesterActionsCallbackInterface.OnToggleInventory;
                @ToggleInventory.performed -= m_Wrapper.m_ChesterActionsCallbackInterface.OnToggleInventory;
                @ToggleInventory.canceled -= m_Wrapper.m_ChesterActionsCallbackInterface.OnToggleInventory;
            }
            m_Wrapper.m_ChesterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Duck.started += instance.OnDuck;
                @Duck.performed += instance.OnDuck;
                @Duck.canceled += instance.OnDuck;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @ToggleInventory.started += instance.OnToggleInventory;
                @ToggleInventory.performed += instance.OnToggleInventory;
                @ToggleInventory.canceled += instance.OnToggleInventory;
            }
        }
    }
    public ChesterActions @Chester => new ChesterActions(this);
    public interface IChesterActions
    {
        void OnDuck(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnToggleInventory(InputAction.CallbackContext context);
    }
}
