using UnityEngine;
using UnityEngine.InputSystem;

public class Shop : MonoBehaviour
{
    public InputActionAsset InputActions;
    public InputAction shopAction;
    private bool despause;
    [SerializeField] private GameObject menuShop;
    public Pontos pontosScript;
    public Vida vidaScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        despause = false;
        pontosScript = FindObjectOfType<Pontos>();
        vidaScript = FindObjectOfType<Vida>();
    }

    // Update is called once per frame
    void Update()
    {
         if(shopAction.WasPressedThisFrame())
        {
            ShopManager();
        }    
    }

    public void ShopManager()
    {
        if(despause!=true)
        {
            menuShop.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        if(despause==true)
        {
            menuShop.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
        despause = !despause;
    }

    public void VidaShop()
    {
        if(pontosScript.pontucao >= 200)
        {
            vidaScript.AumentaVida();
            pontosScript.MudarPontos(-200);
        }
    }

    private void Awake()
    {
        shopAction = InputSystem.actions.FindAction("Shop");
    }
}
