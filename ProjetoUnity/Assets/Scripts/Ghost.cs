using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ghost : MonoBehaviour
{
    public InputActionAsset InputActions;
    public InputAction ghostAction;
    [SerializeField] private GameObject model;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ghostAction.WasPressedThisFrame())
        {
            model.SetActive(false);
        } 
    }

    private void Awake()
    {
        ghostAction = InputSystem.actions.FindAction("Ghost");
    }
}
