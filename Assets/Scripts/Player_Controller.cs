using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float velocidad = 5f; // Margaugulu73 / Speed según ticher
    public float gravedad = -9.81f;
    public float VerticalSpeed; 
    float HorizontalMove;
    float VerticalMove;
    float Contador_Quartz;
    private CharacterController character_Controller;  // Margol vago de mierda / (controller) según ticher

    void Start()
    {
        character_Controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        HorizontalMove = Input.GetAxis("Horizontal"); // Ojalá pierda España
        VerticalMove = Input.GetAxis("Vertical");
        
        if (character_Controller.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                VerticalSpeed = 5f;
            }
        }

        VerticalSpeed += gravedad * Time.deltaTime;

        Vector3 direction = new Vector3(HorizontalMove, VerticalSpeed, VerticalMove);
        character_Controller.Move(direction * velocidad * Time.deltaTime);

    }
    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Quartz"))
        {
            Contador_Quartz++;
            Debug.Log("Has recolectado " +  Contador_Quartz + " Quartz");
            Destroy(hit.gameObject);
        }
        Debug.Log("Collided with: " + hit.gameObject.name);
    }
}
