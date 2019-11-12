using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.5f;
    [SerializeField]
    private float variacaoDaPosicY = 0;
    private Pontuacao pontuacao;    

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicY, variacaoDaPosicY));
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();        
    }

    // Update is called once per frame
    private void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);        
    }

    public void ColetarCoin()
    {
        this.pontuacao.AdicionarPontos(2, "coletarMoeda");
        this.Destruir();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "BarreiraDeObstaculos")
        {
            this.Destruir();
        } else if (collision.transform.name == "aviao1")
        {            
            this.ColetarCoin();
        }
    }

    public void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}