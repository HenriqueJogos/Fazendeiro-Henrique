using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class Ghost : MonoBehaviour
{
    public InputActionAsset InputActions;
    public InputAction ghostAction;
    [SerializeField] private GameObject model;
    private IEnumerator coroutine;

    // Update is called once per frame
    void Update()
    {
        if(ghostAction.WasPressedThisFrame())
        {
            model.SetActive(false);
            coroutine = Duracao(0.6f);
            StartCoroutine(coroutine);
        } 
    }

    private void Awake()
    {
        ghostAction = InputSystem.actions.FindAction("Ghost");
    }

    private IEnumerator Duracao(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        model.SetActive(true);
    }
}
