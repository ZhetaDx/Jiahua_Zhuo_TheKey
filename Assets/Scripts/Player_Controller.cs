using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float velocidad = 5f; // Margaugulu73 / Speed según ticher
    float HorizontalMove;
    float VerticalMove;
    private CharacterController character_Controller;  // Margol vago de mierda / (controller) según ticher

    void Start()
    {
        character_Controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        HorizontalMove = Input.GetAxis("Horizontal"); // Ojalá pierda España
        VerticalMove = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(HorizontalMove, 0, VerticalMove);
        character_Controller.Move(direction * velocidad * Time.deltaTime);
    }
}
