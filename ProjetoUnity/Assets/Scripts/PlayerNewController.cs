using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class PlayerNewController : MonoBehaviour
{
    public float speed = 20f;
    public float xRange = 15f;
    public GameObject projectilePrefab;
    public InputActionAsset InputActions;
    public InputAction moveAction;
    public InputAction fireAction;
    private IEnumerator coroutine;

    // Update is called once per frame
    void Update()
    {
        // antigo input system float horizontalInput = Input.GetAxis("Horizontal");
        float horizontalInput = moveAction.ReadValue<Vector2>().x;
        // movimenta o player para esquerda e direita a partir da entrada do usu�rio
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        // mant�m o player dentro dos limites do jogo (eixo x)
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.y);
        }
        if(fireAction.WasPressedThisFrame())
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        } 
    }

    public void AumentarVelocidade()
    {
        speed = 40f;
        coroutine = Duracao(5.0f);
        StartCoroutine(coroutine);
    }
    private IEnumerator Duracao(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        speed = 20f;
    }

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }
  
    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        fireAction = InputSystem.actions.FindAction("Jump");
    }
}

