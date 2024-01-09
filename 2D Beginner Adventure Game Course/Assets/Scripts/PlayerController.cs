using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Karakter hareketi için oluþturuldu.
    [SerializeField]
    private InputAction MoveAction;
  

    //Karaktere ait hareket ivmesi için oluþturuldu.
    private float horizontalValue = 0f;
    private float verticalValue = 0f;



    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
        
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
    }



    private void CharacterMove()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Vector2 characterPosition = (Vector2)transform.position + move * 3.5f *Time.deltaTime; 
        transform.position = characterPosition;

    }
}
