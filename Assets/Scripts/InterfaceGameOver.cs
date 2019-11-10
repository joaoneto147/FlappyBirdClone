using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;

    [SerializeField]
    private Text valorRecorde;

    public void AtualizarVisibilidadeInterface(bool mostrar)
    {
        this.imagemGameOver.SetActive(mostrar);
        
        if (mostrar)
        {
          this.AtualizarInterfaceGrafica();
        }
    }
    public void AtualizarInterfaceGrafica()
    {
        int recorde = PlayerPrefs.GetInt("recorde");
        valorRecorde.text = recorde.ToString();
    }
}
