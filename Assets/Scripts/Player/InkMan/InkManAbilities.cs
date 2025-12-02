using System;
using UnityEngine;

public class InkManAbilities : PlayerInputs
{
    void Start()
    {

    }

    void Update()
    {

    }

    public override void MovementMechanics()
    {
        throw new NotImplementedException();
    }

    public override void Attack()
    {
        OnAttackPerformed?.Invoke();
    }

    public override void AttackCooldown()
    {
        throw new NotImplementedException();
    }


    public override void Passive()
    {
        throw new NotImplementedException();
    }

    public override void Ability1()
    {
        OnSkill1Performed?.Invoke();
    }

    public override void Ability2()
    {
        OnSkill2Performed?.Invoke();
    }

    public override void Ultimate()
    {
        OnUltPerformed?.Invoke();
    }

    public override void OutOfControl()
    {
        throw new NotImplementedException();
    }
}
