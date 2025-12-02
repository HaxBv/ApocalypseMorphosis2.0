using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

[System.Serializable]
public class FormAbilitiesUI
{
    public GameObject[] Skill;
}
public class FormManager : MonoBehaviour
{

    public static FormManager instance;
    private InputSystem_Actions input;
    [Header("UI SETTINGS")]
    public FormAbilitiesUI[] formsAbilitiesUI;
    public GameObject PanelSelection;


    [Header("FORMS SETTINGS")]
    public GameObject[] FormPrefabs;
    public int MorphCost;
    public int MorphCD;


    private float currentMorphCooldown;
    public GameObject currentForm;
    public int currentFormID = 0;


    public bool Selecting = false;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        input = new();
    }
    void Start()
    {
        PanelSelection.SetActive(false);
        currentForm = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        RechargeMorph();
    }

    public void RechargeMorph()
    {
        if (currentMorphCooldown > 0)
        {
            currentMorphCooldown -= Time.deltaTime;
        }

    }
    private void OnEnable()
    {
        input.Enable();

        input.UI.Morph.started += OnChangeAcive;
        input.UI.Morph.canceled += OnChangeDesactive;
    }

    private void OnChangeAcive(InputAction.CallbackContext context)
    {
        PanelSelection.SetActive(true);

        Selecting = true;

    }
    private void OnChangeDesactive(InputAction.CallbackContext context)
    {
        PanelSelection.SetActive(false);
        Selecting = false;

    }

    private void OnDisable()
    {
        input.Disable();



        input.UI.Morph.started -= OnChangeAcive;
        input.UI.Morph.canceled -= OnChangeDesactive;

    }


    public void ChangeForm(int IDForm)
    {
        if (IDForm < 0 || IDForm >= FormPrefabs.Length)
        {
            Debug.Log("The form doesn't exist");
            return;
        }

        if (IDForm == currentFormID)
        {
            Debug.Log("You are currently in this form");
            return;
        }

        Vector3 actualPos = currentForm != null ? currentForm.transform.position : Vector3.zero;
        Quaternion actualRot = currentForm != null ? currentForm.transform.rotation : Quaternion.identity;

        if (currentForm != null)
            Destroy(currentForm);
        Camera.main.GetComponent<CameraTargetFollower>().UpdatePlayerReference(currentForm.transform);
        NotifyEnemySpawnerAboutNewPlayer(currentForm);

        StartCoroutine(InstantiateFormDelayed(IDForm, actualPos, actualRot));

    }
    private void NotifyEnemySpawnerAboutNewPlayer(GameObject newPlayer)
    {
        EnemySpawner[] spawners = FindObjectsByType<EnemySpawner>(
            FindObjectsInactive.Include,
            FindObjectsSortMode.None


        );

        foreach (var spawner in spawners)
        {
            spawner.UpdatePlayerReference(newPlayer.transform);

        }

        Debug.Log("EnemySpawner actualizado con el nuevo Player");
    }

    private IEnumerator InstantiateFormDelayed(int IDForm, Vector3 position, Quaternion rotation)
    {
        yield return new WaitForSeconds(0.05f); 

        

        currentForm = Instantiate(FormPrefabs[IDForm], position, rotation);
        currentFormID = IDForm;

        Debug.Log("Transformado a forma: " + FormPrefabs[IDForm].name);
    }

}
