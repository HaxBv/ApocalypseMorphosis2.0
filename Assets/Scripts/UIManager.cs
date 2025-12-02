using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI PANEL LEVELUP SETTINGS")]
    public Image LevelUpSkill;
    public float TargetScaleX = 1f;
    public float TargetScaleY = 1f;
    public float ScaleStep = 0.01f;

    public bool CanUpSkill = false;

    void Start()
    {
        LevelUpSkill.transform.localScale = new Vector3(0f, 0f, 0f);
    }

    void Update()
    {
        if (CanUpSkill && LevelUpSkill.transform.localScale.x <= TargetScaleX && LevelUpSkill.transform.localScale.y <= TargetScaleY)
        {
            LevelUpSkill.transform.localScale += new Vector3(ScaleStep, ScaleStep, 0f);
        }

        if (!CanUpSkill)
        {
            
            LevelUpSkill.transform.localScale = new Vector3(0, 0, 0f);
            

        }

    }
    public void AbrirPanel()
    {
        

        
        
           
        
        
    }

}
