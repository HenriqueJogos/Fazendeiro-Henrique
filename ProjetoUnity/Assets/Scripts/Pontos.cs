using UnityEngine;
using TMPro;

public class Pontos : MonoBehaviour
{
    private int pontucao;
    private GameObject pontucaoText;
    private TextMeshProUGUI texto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pontucaoText = GameObject.Find("Pontucao");
        texto = pontucaoText.GetComponent<TextMeshProUGUI>(); 
    }

    public void MudarPontos()
    {
        pontucao = pontucao + 100;
        texto.text = pontucao.ToString();
    }
}
