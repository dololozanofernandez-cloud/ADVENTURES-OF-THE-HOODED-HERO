using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] float velocidadSalto;
    InputAction movimiento;
    InputAction saltar;
    Rigidbody2D rb2D;
    Animator animator;
    SpriteRenderer spriteRenderer;

    [SerializeField] float min;
    [SerializeField] float max;
    void Start()
    {
        movimiento = InputSystem.actions.FindAction("Move");
        saltar = InputSystem.actions.FindAction("Jump");
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        Mover();
        Animar();
        LimitarPosicion();
    }


   

    private void Mover()
    {
        Vector2 mover = movimiento.ReadValue<Vector2>();
        rb2D.linearVelocityX = mover.x * velocidad;
       
        if (saltar.WasPressedThisFrame())
        {
                rb2D.linearVelocityY = velocidadSalto;
                       
        }

    }



    private void Animar()
    {
        Vector2 mover = movimiento.ReadValue<Vector2>();
        if (rb2D.linearVelocityY > 0.1f)
        {
            animator.Play("Saltar");
        }
        else if (mover.x > 0)
        {
            animator.Play("Correr");
            spriteRenderer.flipX = false;
        }
        else if (mover.x < 0 )
        {
            animator.Play("Correr");
            spriteRenderer.flipX = true;
        }
        else
        {
            animator.Play("Parado");
        }


    }


    private void LimitarPosicion()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, min, max);

        transform.position = pos;
        if(pos.x >= max)
        {
            SceneManager.LoadScene("Fin");
        }
    }

}
