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
        },
        {
            ""name"": ""Podracer"",
            ""id"": ""35d279ff-d0b7-425b-b52f-aac7f3863c56"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""3ea508db-e157-41d3-bd5e-d68188d698c0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9c244889-1dfb-4c3a-b26b-9a929dde3efc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""32479bf4-d2f8-41d8-bd1f-8baf24eb5592"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fe8c24fb-b37d-4586-9ddc-14fda6a8443b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3928dcf8-0e24-45d2-aa26-c6afce1ebec4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d7999b54-314e-49d8-b039-e91c4696405b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""TextControls"",
            ""id"": ""160725c3-dd72-475b-acac-5019999a3283"",
            ""actions"": [
                {
                    ""name"": ""Switch"",
                    ""type"": ""Value"",
                    ""id"": ""32bdba05-22d0-417e-a327-85621e70cb1c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""577f9420-3622-4c8d-b189-4b238961a586"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ca1da646-af99-456c-81bf-47726bad25d0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""18284d10-e971-4e4f-911c-061cd5e34c30"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7dab9a41-6110-4ef3-b687-9e4f2577a87f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bab33593-ff03-411c-af99-f3927eee39d1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
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
        // Podracer
        m_Podracer = asset.FindActionMap("Podracer", throwIfNotFound: true);
        m_Podracer_Movement = m_Podracer.FindAction("Movement", throwIfNotFound: true);
        // TextControls
        m_TextControls = asset.FindActionMap("TextControls", throwIfNotFound: true);
        m_TextControls_Switch = m_TextControls.FindAction("Switch", throwIfNotFound: true);
        m_TextControls_Accelerate = m_TextControls.FindAction("Accelerate", throwIfNotFound: true);
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

    // Podracer
    private readonly InputActionMap m_Podracer;
    private IPodracerActions m_PodracerActionsCallbackInterface;
    private readonly InputAction m_Podracer_Movement;
    public struct PodracerActions
    {
        private @PlayerControls m_Wrapper;
        public PodracerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Podracer_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Podracer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PodracerActions set) { return set.Get(); }
        public void SetCallbacks(IPodracerActions instance)
        {
            if (m_Wrapper.m_PodracerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PodracerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PodracerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PodracerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PodracerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PodracerActions @Podracer => new PodracerActions(this);

    // TextControls
    private readonly InputActionMap m_TextControls;
    private ITextControlsActions m_TextControlsActionsCallbackInterface;
    private readonly InputAction m_TextControls_Switch;
    private readonly InputAction m_TextControls_Accelerate;
    public struct TextControlsActions
    {
        private @PlayerControls m_Wrapper;
        public TextControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Switch => m_Wrapper.m_TextControls_Switch;
        public InputAction @Accelerate => m_Wrapper.m_TextControls_Accelerate;
        public InputActionMap Get() { return m_Wrapper.m_TextControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TextControlsActions set) { return set.Get(); }
        public void SetCallbacks(ITextControlsActions instance)
        {
            if (m_Wrapper.m_TextControlsActionsCallbackInterface != null)
            {
                @Switch.started -= m_Wrapper.m_TextControlsActionsCallbackInterface.OnSwitch;
                @Switch.performed -= m_Wrapper.m_TextControlsActionsCallbackInterface.OnSwitch;
                @Switch.canceled -= m_Wrapper.m_TextControlsActionsCallbackInterface.OnSwitch;
                @Accelerate.started -= m_Wrapper.m_TextControlsActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_TextControlsActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_TextControlsActionsCallbackInterface.OnAccelerate;
            }
            m_Wrapper.m_TextControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Switch.started += instance.OnSwitch;
                @Switch.performed += instance.OnSwitch;
                @Switch.canceled += instance.OnSwitch;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
            }
        }
    }
    public TextControlsActions @TextControls => new TextControlsActions(this);
    public interface IBaseActionsActions
    {
        void OnPlayerMovement(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
    public interface IPodracerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface ITextControlsActions
    {
        void OnSwitch(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
    }
}
