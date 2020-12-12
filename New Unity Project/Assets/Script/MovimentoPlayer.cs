using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    public float velocidadeMovimento;
    public float limiteDeX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float directionMouseX = Input.GetAxis("Mouse X"); // -1 =  esquerda; 0 = parado; 1 = direita
        GetComponent<Transform>().position += Vector3.right * directionMouseX * velocidadeMovimento  * Time.deltaTime;
        float xAtual = transform.position.x;
        xAtual = Mathf.Clamp (xAtual, -limiteDeX, limiteDeX);
        transform.position = new Vector3(xAtual, transform.position.y, transform.position.z);
    }
}
