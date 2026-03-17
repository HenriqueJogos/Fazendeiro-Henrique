using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string nomedacena;
    [SerializeField] private GameObject menuInicio;
    [SerializeField] private GameObject menuOpcoes;
    [SerializeField] private GameObject sairOpcoes;

    public void Jogar()
    {
        SceneManager.LoadScene(nomedacena);
    }
    public void AbrirOpcoes()
    {
        menuInicio.SetActive(false);
        menuOpcoes.SetActive(true);
    }
    public void SairOpcoes()
    {
        menuInicio.SetActive(true);
        menuOpcoes.SetActive(false);
    } 
    public void Sairdojogo()
    {
        sairOpcoes.SetActive(true);
        menuInicio.SetActive(false);
    }
    public void Sim()
    {
        Application.Quit();  
    }
    public void Nao()
    {
       sairOpcoes.SetActive(false); 
       menuInicio.SetActive(true);
    }
}
