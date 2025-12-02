using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour, BaseAbility, IAbilities
{
    public InputSystem_Actions inputs;
    public Action<Vector2> OnMoveChange;
    public Action OnAttackPerformed;
    public Action OnSkill1Performed;
    public Action OnSkill2Performed;
    public Action OnUltPerformed;



    private Vector2 moveInput;
    private void Awake()
    {
        inputs = new();
    }


    private void OnEnable()
    {
        inputs.Enable();

        inputs.Player.Move.started += OnMove;
        inputs.Player.Move.performed += OnMove;
        inputs.Player.Move.canceled += OnMove;


        inputs.Player.Attack.performed += OnAttack;
        inputs.Player.Skill1.performed += OnSkill1;
        inputs.Player.Skill2.performed += OnSkill2;
        inputs.Player.Ultimate.performed += OnUltimate;

    }
    private void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        OnMoveChange?.Invoke(moveInput);
    }
    private void OnAttack(InputAction.CallbackContext context)
    {
        
        if (FormManager.instance.Selecting != true)
            Attack();

    }
    private void OnSkill1(InputAction.CallbackContext context)
    {
        if (FormManager.instance.Selecting != true)
            Ability1();

    }
    private void OnSkill2(InputAction.CallbackContext context)
    {
        if (FormManager.instance.Selecting != true)
            Ability2();
            
    }

    private void OnUltimate(InputAction.CallbackContext context)
    {
        if (FormManager.instance.Selecting != true)
            Ultimate();

    }
  



    private void OnDisable()
    {
        inputs.Disable();
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public virtual void MovementMechanics()
    {
        
    }

    public virtual void Attack()
    {
        OnAttackPerformed?.Invoke();
    }

    public virtual void AttackCooldown()
    {
        
    }




    public virtual void Passive()
    {
        
    }

    public virtual void Ability1()
    {
        OnSkill1Performed?.Invoke();
    }

    public virtual void Ability2()
    {
        OnSkill2Performed?.Invoke();
    }

    public virtual void Ultimate()
    {
        OnUltPerformed?.Invoke();
    }

    public virtual void OutOfControl()
    {
       
    }



    public Vector2 MoveInput => moveInput;
}
