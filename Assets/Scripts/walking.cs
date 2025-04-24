using UnityEngine;
using UnityEngine.UIElements;

public class walking : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float characterSpeed;
    //ÒýÓÃ characterAnimation
    private characterAnimation characterAnimation;
    private characterWalkingSound characterWalkingSound;


    private bool isMoving = false;

    private void Start()
    {
        //get the things!!
        characterAnimation = GetComponent<characterAnimation>();
        characterWalkingSound = GetComponent<characterWalkingSound>();
    }

    // Update is called once per frame
    private void Update()
    {
        //detect input
        Vector2 movementInput = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, characterSpeed * Time.deltaTime, 0);
            movementInput.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -characterSpeed * Time.deltaTime, 0);
            movementInput.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-characterSpeed * Time.deltaTime, 0, 0);
            movementInput.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(characterSpeed * Time.deltaTime, 0, 0);
            movementInput.x = 1;
        }

        //detect & play animation
        if (movementInput != Vector2.zero)
        {
            if (!isMoving)
            {
                isMoving = true;
                // start play
                characterWalkingSound.StartWalkingSound();
            }
            characterAnimation.PlayAnimation(movementInput);
        }
        else
        {
            if (isMoving)
            {
                isMoving = false;
                //stop play
                characterWalkingSound.StopWalkingSound();
            }
            characterAnimation.PlayIdleAnimation();
        }

    }
}
