using UnityEngine;

public class Vida : MonoBehaviour
{
    private int vidas;
    [SerializeField] private GameObject vida;
    [SerializeField] private GameObject vida2;
    [SerializeField] private GameObject vida3;
    [SerializeField] private GameObject gameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidas = 3;
    }
    public void MudarImagem()
    {
        if(vidas==3)
        {
            vida.SetActive(true);
            vida2.SetActive(true);
            vida3.SetActive(true);
        }
        if(vidas==2)
        {
            vida3.SetActive(false); 
        }
        if(vidas==1)
        {
            vida2.SetActive(false); 
        }
        if(vidas<1)
        {
            vida3.SetActive(false);
            gameOver.SetActive(true);
        }
    }

    public void AumentaVida()
    {
        if(vidas<3)
        {
            vidas++;
            MudarImagem();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Pizza"))
        {
            vidas--;
            MudarImagem();
        }
    }
}
