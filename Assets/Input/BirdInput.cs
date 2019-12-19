// GENERATED AUTOMATICALLY FROM 'Assets/Input/BirdInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BirdInput : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @BirdInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BirdInput"",
    ""maps"": [
        {
            ""name"": ""Bird"",
            ""id"": ""f089806e-66be-4722-9a2e-58588d20e12b"",
            ""actions"": [
                {
                    ""name"": ""Flap"",
                    ""type"": ""Button"",
                    ""id"": ""ad7ffad3-74ea-41e0-9e94-b236e22213dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e7fe8b2b-f62e-4620-b749-c5d44b0316c0"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6a92668-3fdc-40a0-a2e9-443e2b1747d8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Bird
        m_Bird = asset.FindActionMap("Bird", throwIfNotFound: true);
        m_Bird_Flap = m_Bird.FindAction("Flap", throwIfNotFound: true);
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

    // Bird
    private readonly InputActionMap m_Bird;
    private IBirdActions m_BirdActionsCallbackInterface;
    private readonly InputAction m_Bird_Flap;
    public struct BirdActions
    {
        private @BirdInput m_Wrapper;
        public BirdActions(@BirdInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Flap => m_Wrapper.m_Bird_Flap;
        public InputActionMap Get() { return m_Wrapper.m_Bird; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BirdActions set) { return set.Get(); }
        public void SetCallbacks(IBirdActions instance)
        {
            if (m_Wrapper.m_BirdActionsCallbackInterface != null)
            {
                @Flap.started -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlap;
                @Flap.performed -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlap;
                @Flap.canceled -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlap;
            }
            m_Wrapper.m_BirdActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Flap.started += instance.OnFlap;
                @Flap.performed += instance.OnFlap;
                @Flap.canceled += instance.OnFlap;
            }
        }
    }
    public BirdActions @Bird => new BirdActions(this);
    public interface IBirdActions
    {
        void OnFlap(InputAction.CallbackContext context);
    }
}
