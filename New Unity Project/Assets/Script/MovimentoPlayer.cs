using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    [SerializeField] private float velocidadeMovimento;
    [SerializeField] private float limiteDeX;

    private Vector2 mouse;

    private void Start() => Cursor.lockState = CursorLockMode.Locked;//ESC para destravar o cursor
    void Update() => MoveByMouseXPosition();
    private void MoveByMouseXPosition()
    {
        mouse.x = Input.GetAxis("Mouse X") * velocidadeMovimento * Time.deltaTime;
        var resultado = Mathf.Clamp(transform.position.x, -limiteDeX, limiteDeX);
        transform.position = new Vector2(resultado, transform.position.y);
        transform.Translate(mouse);
    }
}
