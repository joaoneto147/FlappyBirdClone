using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private int forca = 5;
    private Diretor diretor;
    private Vector3 posicaoInicial;
    private bool deveImpulsionar;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();               
        this.posicaoInicial = this.transform.position;
    }

    private void FixedUpdate()
    {
        if (this.deveImpulsionar)
        {
            this.Impulsionar();
        }

    }

    private void Start()
    {
        diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)){ this.deveImpulsionar = true;}

        if (this.transform.position.x < -7) {
            this.transform.position = new Vector3(-7, this.transform.position.y, this.transform.position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }

    private void Impulsionar() {
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
        this.deveImpulsionar = false;
    }

    public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}
