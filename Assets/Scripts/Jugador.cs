using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb;
    private float movimiento;
    public float alturaSalto = 4f;
    private bool esPiso;//true=estamos en el piso, false=estamos en el aire
    public Transform comprobadorPiso;
    public float radioComprobadorPiso = 0.1f;
    public LayerMask layerPiso;
    private Animator animator;
    private int cantAbejas = 0;
    public TMP_Text textoAbejas;
    private bool enRetroceso = false;
    public AudioSource audioSource;
    public AudioClip audioPuerquito;
    public AudioClip audioCaracol;
    public AudioClip audioAbeja;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!enRetroceso)
        {
            movimiento = Input.GetAxisRaw("Horizontal");
            rb.linearVelocity = new Vector2(movimiento * velocidad, rb.linearVelocity.y);
            if (movimiento != 0) transform.localScale = new Vector3(Mathf.Sign(movimiento), 1, 1);
        }
        if (Input.GetButtonDown("Jump") && esPiso)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, alturaSalto);
        animator.SetFloat("Velocidad", Mathf.Abs(movimiento));
        animator.SetFloat("VelocidadVertical", rb.linearVelocity.y);
        animator.SetBool("estaEnPiso", esPiso);
    }

    public void FixedUpdate()
    {
        esPiso = Physics2D.OverlapCircle(comprobadorPiso.position, radioComprobadorPiso, layerPiso);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("abejita"))
        {
            audioSource.PlayOneShot(audioAbeja);
            Destroy(collision.gameObject);
            cantAbejas++;
            textoAbejas.text = "" + cantAbejas;
        }
        if (collision.transform.CompareTag("puerquito"))
        {
            audioSource.PlayOneShot(audioPuerquito);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.transform.CompareTag("caracol"))
        {
            audioSource.PlayOneShot(audioCaracol);
            enRetroceso = true;
            Vector2 arrastre = (rb.position - (Vector2)collision.transform.position).normalized * 3;
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(arrastre, ForceMode2D.Impulse);
            Collider2D[] colliders = collision.GetComponents<Collider2D>();
            foreach (Collider2D col in colliders)
                col.enabled = false;
            collision.GetComponent<Animator>().enabled = true;
            Destroy(collision.gameObject, 0.4f);
            Invoke(nameof(QuitarRetroceso), 0.2f);
        }
    }

    void QuitarRetroceso()
    {
        enRetroceso = false;
    }
}
