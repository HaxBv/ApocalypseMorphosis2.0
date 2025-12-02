using UnityEngine;

public enum RangeForm
{
    None,
    RangeS,
    RangeA,
    RangeB,
    RangeC,
}
public enum RolPlayer
{
    None,
    Fighter,
    Assassin,
    Tank,
    Marksman,
    Mage,
}

[CreateAssetMenu(fileName = "CharactersDataSO", menuName = "ApocalypseMorphosis/CharactersDataSO")]


public class CharactersDataSO : ScriptableObject
{
    [Header("GENERAL")]
    public ulong ID;
    public string Name;
    public RangeForm Range;
    public RolPlayer PrimaryRol;
    public RolPlayer SecundaryRol;

    [Header("STATS")]
    public int Health;
    public int Damage;
    public int Armor;
    public float SpeedMovement;
    public float SpeedAttack;
    public bool BuffActive;


    [Header("UPGRADES PER LEVEL")]
    public int HeatlhPerLevel;
    public int DamagePerLevel;
    public int ArmorPerLevel;
    public float SpeedMovementPerLevel;
    public float SpeedAttackPerLevel;

}
