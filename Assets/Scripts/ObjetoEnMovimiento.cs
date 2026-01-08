using UnityEngine;
using UnityEngine.Rendering;

public class ObjetoEnMovimiento : MonoBehaviour
{
    [SerializeField] float velocidad;
    float aceleracion = 0.1f;
    int direccion = 1;
    SpriteRenderer sp;
    void Start()
    {
        transform.position = new Vector3(-1, -2, 0);
        sp = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        
      velocidad = velocidad + aceleracion * Time.deltaTime;

        /*Ejercicio 1.3

        transform.position += new Vector3(velocidad * direccion * Time.deltaTime, 0, 0);*/

        //Ejercicio 1.4
        transform.Translate(new Vector3(velocidad * direccion * Time.deltaTime, 0, 0));


        if (transform.position.x >= 9f)
        {
            direccion = -1; 
            sp.flipX = true;
            velocidad = 0.1f;
            
            
        }
        else if (transform.position.x <= -9f)
        {
            direccion = 1; 
            sp.flipX = false;
            velocidad = 0.1f;
        }
        
        
    }
}
