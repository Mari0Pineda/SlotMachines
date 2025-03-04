//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.13.0
//     from Assets/BlackJack_Root/Mario_Folder/Scripts_Mario/GuessCardInputActions.inputactions
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

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/BlackJack_Root/Mario_Folder/Scripts_Mario/GuessCardInputActions.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @GuessCardInputActions: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @GuessCardInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GuessCardInputActions"",
    ""maps"": [
        {
            ""name"": ""GuessTheCardGame"",
            ""id"": ""0ed6684f-440c-4913-9a10-e11a8587db21"",
            ""actions"": [
                {
                    ""name"": ""Navigation"",
                    ""type"": ""Value"",
                    ""id"": ""c5a10444-f97a-42fa-953a-6b6cb6500b78"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Submition"",
                    ""type"": ""Button"",
                    ""id"": ""93c5ceee-3aa9-4cf1-b52e-1e2acff6d520"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Bet"",
                    ""type"": ""Button"",
                    ""id"": ""2d52cdb6-3c0b-42ab-a265-d88bf3541299"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PointerMovement"",
                    ""type"": ""Value"",
                    ""id"": ""301da584-1e60-4881-9552-3127ecc9f276"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PointerClick"",
                    ""type"": ""Button"",
                    ""id"": ""bd89c743-520e-4fcd-a859-d16f641a4855"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""644baaea-ff1d-47b0-a311-fdd78399bf62"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49117d51-e1f6-486c-80c2-7ccfd5b5090a"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c0d0318d-a4ba-4172-8bce-043ebf48d858"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""be36e72d-d80d-45a2-b0fb-5f5fe2ebb25c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b64dca95-6676-4298-9264-bdc10ab1e565"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9068e7ca-5efd-44d3-89ba-ddb68ed750b3"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""419e4071-ef87-4ba3-bb2f-db9386964bff"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae161ef8-9d9d-4382-9dbd-af7022e1b0e9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91f1efa5-4b05-4f93-aa4b-1db823dfabbf"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a37afc56-7ee6-4a82-b175-4c27989c782d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointerClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GuessTheCardGame
        m_GuessTheCardGame = asset.FindActionMap("GuessTheCardGame", throwIfNotFound: true);
        m_GuessTheCardGame_Navigation = m_GuessTheCardGame.FindAction("Navigation", throwIfNotFound: true);
        m_GuessTheCardGame_Submition = m_GuessTheCardGame.FindAction("Submition", throwIfNotFound: true);
        m_GuessTheCardGame_Bet = m_GuessTheCardGame.FindAction("Bet", throwIfNotFound: true);
        m_GuessTheCardGame_PointerMovement = m_GuessTheCardGame.FindAction("PointerMovement", throwIfNotFound: true);
        m_GuessTheCardGame_PointerClick = m_GuessTheCardGame.FindAction("PointerClick", throwIfNotFound: true);
    }

    ~@GuessCardInputActions()
    {
        UnityEngine.Debug.Assert(!m_GuessTheCardGame.enabled, "This will cause a leak and performance issues, GuessCardInputActions.GuessTheCardGame.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // GuessTheCardGame
    private readonly InputActionMap m_GuessTheCardGame;
    private List<IGuessTheCardGameActions> m_GuessTheCardGameActionsCallbackInterfaces = new List<IGuessTheCardGameActions>();
    private readonly InputAction m_GuessTheCardGame_Navigation;
    private readonly InputAction m_GuessTheCardGame_Submition;
    private readonly InputAction m_GuessTheCardGame_Bet;
    private readonly InputAction m_GuessTheCardGame_PointerMovement;
    private readonly InputAction m_GuessTheCardGame_PointerClick;
    /// <summary>
    /// Provides access to input actions defined in input action map "GuessTheCardGame".
    /// </summary>
    public struct GuessTheCardGameActions
    {
        private @GuessCardInputActions m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public GuessTheCardGameActions(@GuessCardInputActions wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "GuessTheCardGame/Navigation".
        /// </summary>
        public InputAction @Navigation => m_Wrapper.m_GuessTheCardGame_Navigation;
        /// <summary>
        /// Provides access to the underlying input action "GuessTheCardGame/Submition".
        /// </summary>
        public InputAction @Submition => m_Wrapper.m_GuessTheCardGame_Submition;
        /// <summary>
        /// Provides access to the underlying input action "GuessTheCardGame/Bet".
        /// </summary>
        public InputAction @Bet => m_Wrapper.m_GuessTheCardGame_Bet;
        /// <summary>
        /// Provides access to the underlying input action "GuessTheCardGame/PointerMovement".
        /// </summary>
        public InputAction @PointerMovement => m_Wrapper.m_GuessTheCardGame_PointerMovement;
        /// <summary>
        /// Provides access to the underlying input action "GuessTheCardGame/PointerClick".
        /// </summary>
        public InputAction @PointerClick => m_Wrapper.m_GuessTheCardGame_PointerClick;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_GuessTheCardGame; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="GuessTheCardGameActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(GuessTheCardGameActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="GuessTheCardGameActions" />
        public void AddCallbacks(IGuessTheCardGameActions instance)
        {
            if (instance == null || m_Wrapper.m_GuessTheCardGameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GuessTheCardGameActionsCallbackInterfaces.Add(instance);
            @Navigation.started += instance.OnNavigation;
            @Navigation.performed += instance.OnNavigation;
            @Navigation.canceled += instance.OnNavigation;
            @Submition.started += instance.OnSubmition;
            @Submition.performed += instance.OnSubmition;
            @Submition.canceled += instance.OnSubmition;
            @Bet.started += instance.OnBet;
            @Bet.performed += instance.OnBet;
            @Bet.canceled += instance.OnBet;
            @PointerMovement.started += instance.OnPointerMovement;
            @PointerMovement.performed += instance.OnPointerMovement;
            @PointerMovement.canceled += instance.OnPointerMovement;
            @PointerClick.started += instance.OnPointerClick;
            @PointerClick.performed += instance.OnPointerClick;
            @PointerClick.canceled += instance.OnPointerClick;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="GuessTheCardGameActions" />
        private void UnregisterCallbacks(IGuessTheCardGameActions instance)
        {
            @Navigation.started -= instance.OnNavigation;
            @Navigation.performed -= instance.OnNavigation;
            @Navigation.canceled -= instance.OnNavigation;
            @Submition.started -= instance.OnSubmition;
            @Submition.performed -= instance.OnSubmition;
            @Submition.canceled -= instance.OnSubmition;
            @Bet.started -= instance.OnBet;
            @Bet.performed -= instance.OnBet;
            @Bet.canceled -= instance.OnBet;
            @PointerMovement.started -= instance.OnPointerMovement;
            @PointerMovement.performed -= instance.OnPointerMovement;
            @PointerMovement.canceled -= instance.OnPointerMovement;
            @PointerClick.started -= instance.OnPointerClick;
            @PointerClick.performed -= instance.OnPointerClick;
            @PointerClick.canceled -= instance.OnPointerClick;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="GuessTheCardGameActions.UnregisterCallbacks(IGuessTheCardGameActions)" />.
        /// </summary>
        /// <seealso cref="GuessTheCardGameActions.UnregisterCallbacks(IGuessTheCardGameActions)" />
        public void RemoveCallbacks(IGuessTheCardGameActions instance)
        {
            if (m_Wrapper.m_GuessTheCardGameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="GuessTheCardGameActions.AddCallbacks(IGuessTheCardGameActions)" />
        /// <seealso cref="GuessTheCardGameActions.RemoveCallbacks(IGuessTheCardGameActions)" />
        /// <seealso cref="GuessTheCardGameActions.UnregisterCallbacks(IGuessTheCardGameActions)" />
        public void SetCallbacks(IGuessTheCardGameActions instance)
        {
            foreach (var item in m_Wrapper.m_GuessTheCardGameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GuessTheCardGameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="GuessTheCardGameActions" /> instance referencing this action map.
    /// </summary>
    public GuessTheCardGameActions @GuessTheCardGame => new GuessTheCardGameActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "GuessTheCardGame" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="GuessTheCardGameActions.AddCallbacks(IGuessTheCardGameActions)" />
    /// <seealso cref="GuessTheCardGameActions.RemoveCallbacks(IGuessTheCardGameActions)" />
    public interface IGuessTheCardGameActions
    {
        /// <summary>
        /// Method invoked when associated input action "Navigation" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnNavigation(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Submition" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnSubmition(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Bet" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnBet(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PointerMovement" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPointerMovement(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PointerClick" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPointerClick(InputAction.CallbackContext context);
    }
}
