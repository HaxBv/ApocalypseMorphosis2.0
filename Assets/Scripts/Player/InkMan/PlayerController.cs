using UnityEngine;

[RequireComponent (typeof(PlayerInputs))]
public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    public PlayerInputs InputManager;
    public PlayerMovement MovementManager;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        InputManager = GetComponent<PlayerInputs>();

        MovementManager = GetComponent<PlayerMovement>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
