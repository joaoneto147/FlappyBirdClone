using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorAudio : MonoBehaviour
{
    public static AudioClip coletarMoeda, pontuacao, teste;
    static AudioSource audioSrc;

    void Start()
    {

        coletarMoeda = Resources.Load<AudioClip>("coletarMoeda");
        pontuacao = Resources.Load<AudioClip>("pontuacao");
        audioSrc = GetComponent<AudioSource>();

    }

    public static void TocarSom(string clip)
    {
        switch (clip)
        {
            case "pontuacao":
                audioSrc.PlayOneShot(pontuacao);
                break;

            case "coletarMoeda":
                audioSrc.PlayOneShot(coletarMoeda);
                break;

        }
    }
}
