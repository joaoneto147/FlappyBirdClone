using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    private int pontos = 0;
    [SerializeField]
    private Text textoPontuacao;    

    public void AdicionarPontos(int multiplicador, string audioNome)
    {

        this.pontos += 1 * multiplicador;
        this.textoPontuacao.text = this.pontos.ToString();
        GerenciadorAudio.TocarSom(audioNome);

    }

    public void ZerarPontos()
    {
        this.pontos = 0;
        this.textoPontuacao.text = "0";
    }

    public void SalvarRecorde()
    {
        int recordeAtual = PlayerPrefs.GetInt("recorde");
        if (this.pontos > recordeAtual) {
            PlayerPrefs.SetInt("recorde", this.pontos);
        }
    }

    public int GetRecord()
    {
        return PlayerPrefs.GetInt("recorde");
    }
}
