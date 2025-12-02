using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

[System.Serializable]
public class CharacterStats
{
    public ulong ID;
    public int MaxHealth;
    public int CurrentHealth;
    public int Damage;
    public float SpeedMovement;
    public float SpeedAttack;
    public bool BuffActive;
}
public class StatsManager : MonoBehaviour
{
    public static StatsManager instance;

    [Header("ALL FORMS")]
    public CharactersDataSO[] CharactersData;

    [Header("BASE FORM")]
    public CharacterStats InkmanStats;

    [Header("FORM 01")]
    public CharacterStats ShadowStats;

    [Header("FORM 02")]
    public CharacterStats ZeroStats;

    [Header("FORM 03")]
    public CharacterStats MaximwolfStats;

    [Header("FORM 04")]
    public CharacterStats DracoStats;

    [Header("FORM 05")]
    public CharacterStats KonquestStats;

    [Header("FORM 06")]
    public CharacterStats TruenoStats;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    void Start()
    {
        ApplyDataBase(InkmanStats, CharactersData[0]);
        ApplyDataBase(ShadowStats, CharactersData[1]);
        ApplyDataBase(ZeroStats, CharactersData[2]);
        ApplyDataBase(MaximwolfStats, CharactersData[3]);
        ApplyDataBase(DracoStats, CharactersData[4]);
        ApplyDataBase(KonquestStats, CharactersData[5]);
        ApplyDataBase(TruenoStats, CharactersData[6]);


    }

    void Update()
    {
        
    }
    public void ApplyDataBase(CharacterStats stats, CharactersDataSO data)
    {
        stats.ID = data.ID;
        stats.MaxHealth = data.Health;
        stats.CurrentHealth= data.Health;
        stats.Damage = data.Damage;
        stats.SpeedMovement = data.SpeedMovement;
        stats.SpeedAttack = data.SpeedAttack;
        stats.BuffActive = data.BuffActive;

    }
}
