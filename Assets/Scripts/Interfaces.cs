using UnityEngine;

public interface IDamagable
{
    void TakeDamage(int damage);
}


public interface BaseAbility
{
    void MovementMechanics();
    void Attack();
    void AttackCooldown();
}

public interface IAbilities
{
    void Passive();
    void Ability1();
    void Ability2();
    void Ultimate();
    void OutOfControl();
}
