using UnityEngine;
using UnityEngine.InputSystem;

public class Pause : MonoBehaviour
{
    public InputActionAsset InputActions;
    public InputAction pauseAction;
    private bool despause;
    public GameObject menuPause;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        despause = false;
    }

    // Update is called once per frame
    void Update()
    {
         if(pauseAction.WasPressedThisFrame())
        {
            PauseGame();
        } 
    }
    private void PauseGame()
    {
        if(despause!=true)
        {
            InputActions.FindActionMap("Player").Disable();
            InputActions.FindActionMap("UI").Enable();
            menuPause.gameObject.SetActive(true);
            Time.timeScale = 0f;
            pauseAction = InputSystem.actions.FindAction("Despause");
        }
        if(despause==true)
        {
            InputActions.FindActionMap("Player").Enable();
            InputActions.FindActionMap("UI").Disable();
            menuPause.gameObject.SetActive(false);
            Time.timeScale = 1f;
            pauseAction = InputSystem.actions.FindAction("Pause");
        }
        despause = !despause;
    }
    private void Awake()
    {
        pauseAction = InputSystem.actions.FindAction("Pause");
    }
}
