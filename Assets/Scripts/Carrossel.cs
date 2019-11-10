using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.10f;

    private Vector3 posicInicial;
    private float tamanhoRealDaImagem;

    private void Awake()
    {
        this.posicInicial = this.transform.position;
        float tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoRealDaImagem = tamanhoDaImagem * escala;
    }


    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoRealDaImagem);
        this.transform.position = this.posicInicial + Vector3.left * deslocamento;
    }
}
