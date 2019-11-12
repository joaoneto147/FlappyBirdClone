using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.5f;
    [SerializeField]
    private float variacaoDaPosicY;
    private Vector3 posicaoAviao;
    private bool pontuado = false;
    private Pontuacao pontuacao;    

    private void Start()
    {
        this.posicaoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
    }

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicY, variacaoDaPosicY));
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();        
    }

    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);

        if ((this.transform.position.x < posicaoAviao.x) && !this.pontuado)
        {
            this.pontuado = true;
            this.pontuacao.AdicionarPontos(1, "pontuacao");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    public void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}