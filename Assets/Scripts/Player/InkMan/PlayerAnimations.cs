using System;
using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class PlayerAnimations : MonoBehaviour
{

    public static PlayerAnimations Instance;
    public Animator Controller;

    


    public SpriteRenderer Sprite;
    private void Awake()
    {
        if (Controller == null)
            Controller = GetComponentInChildren<Animator>();

        if (Instance == null)
       Instance = this;
        Controller = GetComponent<Animator>();

        
        Sprite = GetComponent<SpriteRenderer>();

        

         
        
    }
    void Start()
    {
        PlayerController.Instance.InputManager.OnAttackPerformed += SetAttackAnimation;
        PlayerController.Instance.InputManager.OnSkill1Performed += SetSkill1Animation;
        PlayerController.Instance.InputManager.OnSkill2Performed += SetSkill2Animation;
        PlayerController.Instance.InputManager.OnUltPerformed += SetUltAnimation;
    }




    private void SetAttackAnimation()
    {
        
        switch (FormManager.instance.currentFormID)


        {
            case 0:
                Controller.SetTrigger("OnAttack");
                print("AttackForm0");
                break;
            case 1:
                Controller.SetTrigger("OnAttack");
                print("AttackForm1");
                break;
            case 2:
                print("Whadya want?");
                break;
            case 3:
                Controller.SetTrigger("OnAttack");
                print("AttackForm1");
                break;
            case 4:
                Controller.SetTrigger("OnAttack");
                print("AttackForm3");
                break;
            case 5:
                print("Incorrect intelligence level.");
                break;
            case 6:
                print("Ulg, glib, Pblblblblb");
                break;
        }
    }
    private void SetSkill1Animation()
    { 
        
        switch (FormManager.instance.currentFormID)


        {
            case 0:
                Controller.SetBool("BuffActive", true);
                print("AttackForm0");
                break;
            case 1:
                print("AttackForm1");
                break;
            case 2:
                print("AttackForm2");
                break;
            case 3:
                Controller.SetTrigger("OnSkill1");
                print("AttackForm3");
                break;
            case 4:
                Controller.SetTrigger("OnSkill1");
                print("AttackForm4");
                break;
            case 5:
                print("AttackForm5");
                break;
            case 6:
                print("AttackForm6");
                break;
        }
    }
    private void SetSkill2Animation()
    {
       

        switch (FormManager.instance.currentFormID)


        {
            case 0:
                Controller.SetTrigger("OnSkill2");
                print("AttackForm0");
                break;
            case 1:
                print("AttackForm1");
                break;
            case 2:
                print("Whadya want?");
                break;
            case 3:
                Controller.SetTrigger("OnSkill2");
                print("AttackForm3");
                break;
            case 4:
                Controller.SetTrigger("OnSkill2");
                print("AttackForm4");
                break;
            case 5:
                print("Incorrect intelligence level.");
                break;
            case 6:
                print("Ulg, glib, Pblblblblb");
                break;
        }
    }
    private void SetUltAnimation()
    { 
      
        switch (FormManager.instance.currentFormID)


        {
            case 0:
                Controller.SetTrigger("OnUlt");
                print("AttackForm0");
                break;
            case 1:
                print("AttackForm1");
                break;
            case 2:
                print("Whadya want?");
                break;
            case 3:
                Controller.SetBool("BuffActive", true);
                print("AttackForm3");
                break;
            case 4:
                Controller.SetBool("BuffActive", true);
                print("AttackForm4");
                break;
            case 5:
                print("Incorrect intelligence level.");
                break;
            case 6:
                print("Ulg, glib, Pblblblblb");
                break;
        }
    }








    void Update()
    {
        
    }

  
}
