using UnityEngine;

public enum DisasterLevelEnemy
{
    None,
    Tiger,
    Orgue,
    Demon,
    Dragon,
    God
}

[CreateAssetMenu(fileName = "EnemiesDataSO", menuName = "ApocalypseMorphosis/EnemiesDataSO")]
public class EnemiesDataSO : ScriptableObject
{
    public string EnemyName;
    public ulong ID;

    public DisasterLevelEnemy disaster;
    public int Health;
    public int Damage;
    public float Speed;

    public float SpawnRate;

    public GameObject prefab;
}
