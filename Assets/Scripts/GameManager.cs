using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public FormManager formManager;
    public StatsManager statsManager;




    [Header("LEVEL SETTINGS")]
    private int MaxLevel;
    public int CurrentLevel;
    private int InitialLevel = 1;

    [Header("XP SETTINGS")]
    public float CurrentXp;
    private float InitialXPToLevelUp = 100f;
    public float XpToLevelUp;
    public float XpIncrease = 50f;

    public Action OnLevelUp;

    private void Awake()
    {
        if (instance == null)
        instance = this;
        else
            Destroy(gameObject);
    }
    void Start()
    {
        CurrentLevel = InitialLevel;

        XpToLevelUp = NewXPToLevelUp(CurrentLevel);
    }
    public void GetXp(float cantidad)
    {
        if (CurrentLevel >= MaxLevel)
        {
            CurrentXp = XpToLevelUp;
            return;
        }

        CurrentXp += cantidad;

        
            LevelUp();

        
    }


    private void LevelUp()
    {
        

        CurrentXp -= XpToLevelUp;
        CurrentLevel++;

        XpToLevelUp = NewXPToLevelUp(CurrentLevel);

        OnLevelUp?.Invoke();

    }
    void Update()
    {
        
    }

    private float NewXPToLevelUp(int nivel)
    {
        return InitialXPToLevelUp + (nivel - 1) * XpIncrease;
    }

}
