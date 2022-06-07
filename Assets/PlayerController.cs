using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float moveSpeed;
    Vector2 moveInput;
    Animator anim;
    [SerializeField] float speed;
    public GameObject lightning;
    public Transform spawnLightning;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        moveInput.y += 0.25f;

        transform.Translate(moveInput * Time.deltaTime * moveSpeed);

        Shoot();
    }

    void Shoot(){
        if(Input.GetButtonDown("Fire1")){
            Instantiate(lightning, spawnLightning.position, transform.rotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }

        if(collision.gameObject.CompareTag("Finish")){
            SceneManager.LoadScene("WinScene");
        }
    }

}
