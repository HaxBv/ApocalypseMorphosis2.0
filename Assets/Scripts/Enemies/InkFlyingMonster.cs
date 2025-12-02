using UnityEngine;

public class InkFlyingMonster : EnemyBase
{
    public override void TakeDamage(int dmg)
    {
        Debug.Log("InkMonster recibió daño!");

        TakeDamage(dmg); 
    }

    protected override void Die()
    {
        Debug.Log("InkMonster murió con efecto especial!");

        Die();
    }
}
