using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    // referência ao componente "Character Controller"
    public CharacterController oCharacterController;

    // controla a velocidade de movimento do jogador
    public float velocidadeDoJogador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // roda o método "MoverJogador"
        MoverJogador();
    }

    private void MoverJogador()
    {
        // armazena os inputs "Horizontais" e "Verticais" do teclado (A/D e W/S)
        float movimentoX = Input.GetAxis("Horizontal");
        float movimentoZ = Input.GetAxis("Vertical");

        // calcular o movimento final do jogador (tanto o movimento horizontal, quanto o vertical)
        Vector3 movimentoFinal = transform.right * movimentoX + transform.forward * movimentoZ;

        // aplica o movimento final ao componente "Character Controller"
        oCharacterController.Move(movimentoFinal * velocidadeDoJogador * Time.deltaTime);
    }
}
