// GENERATED AUTOMATICALLY FROM 'Assets/Controls/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""BaseActions"",
            ""id"": ""79033db3-6446-482d-bf83-1988bcc23a4f"",
            ""actions"": [
                {
                    ""name"": ""PlayerMovement"",
                    ""type"": ""Value"",
                    ""id"": ""8fffdfdb-9eb9-45d3-ab83-f472beef0465"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""da0873b1-c525-4e78-9afe-edf1b358ee2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6970ae44-2d99-4e93-807f-2c6e7cd7f455"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dbf6c5a3-c4fb-4a42-a0ff-b642437d7859"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a19af21a-09b5-4cc8-8a5f-ca1653f0e30d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dbe96278-cd5f-486b-8a28-6bf9cfcaba3a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2a950c4c-a3a5-4273-84fe-66e06a6b2e36"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a9c63890-771e-4ac9-adb8-a3e09ef2a848"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BaseActions
        m_BaseActions = asset.FindActionMap("BaseActions", throwIfNotFound: true);
        m_BaseActions_PlayerMovement = m_BaseActions.FindAction("PlayerMovement", throwIfNotFound: true);
        m_BaseActions_Click = m_BaseActions.FindAction("Click", throwIfNotFound: true);
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

    // BaseActions
    private readonly InputActionMap m_BaseActions;
    private IBaseActionsActions m_BaseActionsActionsCallbackInterface;
    private readonly InputAction m_BaseActions_PlayerMovement;
    private readonly InputAction m_BaseActions_Click;
    public struct BaseActionsActions
    {
        private @PlayerControls m_Wrapper;
        public BaseActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerMovement => m_Wrapper.m_BaseActions_PlayerMovement;
        public InputAction @Click => m_Wrapper.m_BaseActions_Click;
        public InputActionMap Get() { return m_Wrapper.m_BaseActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BaseActionsActions set) { return set.Get(); }
        public void SetCallbacks(IBaseActionsActions instance)
        {
            if (m_Wrapper.m_BaseActionsActionsCallbackInterface != null)
            {
                @PlayerMovement.started -= m_Wrapper.m_BaseActionsActionsCallbackInterface.OnPlayerMovement;
                @PlayerMovement.performed -= m_Wrapper.m_BaseActionsActionsCallbackInterface.OnPlayerMovement;
                @PlayerMovement.canceled -= m_Wrapper.m_BaseActionsActionsCallbackInterface.OnPlayerMovement;
                @Click.started -= m_Wrapper.m_BaseActionsActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_BaseActionsActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_BaseActionsActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_BaseActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlayerMovement.started += instance.OnPlayerMovement;
                @PlayerMovement.performed += instance.OnPlayerMovement;
                @PlayerMovement.canceled += instance.OnPlayerMovement;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public BaseActionsActions @BaseActions => new BaseActionsActions(this);
    public interface IBaseActionsActions
    {
        void OnPlayerMovement(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
}
