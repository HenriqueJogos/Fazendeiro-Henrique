using UnityEngine;
using TMPro;

public class Pontos : MonoBehaviour
{
    public int pontucao;
    // public GameObject pontucaoText;
    private TextMeshProUGUI texto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // pontucaoText = GameObject.Find("Pontucao");
        texto = gameObject.GetComponent<TextMeshProUGUI>(); 
    }

    public void MudarPontos(int valor)
    {
        pontucao = pontucao + valor;
        texto.text = pontucao.ToString();
    }
}
