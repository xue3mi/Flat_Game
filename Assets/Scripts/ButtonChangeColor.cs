using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class backgroundShift : MonoBehaviour
{
    //public float moveSpeed;
    private Color initialColor;


    //private Camera mainCamera;
    //public float movingDistance;
    //Vector3 initial;
    //Vector3 final;

    [SerializeField] private Transform Boxes;
    private float nowPosition;
    private float movingBoxes;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Image image = GetComponent<Image>();
        initialColor = image.color;

        //mainCamera = Camera.main;
        //initial = mainCamera.transform.position;
        //final = initial + new Vector3(movingDistance, 0, 0);


    }

    // Update is called once per frame
    void Update()
    {
        //mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, final, moveSpeed * Time.deltaTime);
        //if (mainCamera.transform.position == final)
        //{
        //    Debug.Log("Camera reached final position!");
        //}

    }

    public void changeColor()
    {
        Debug.Log("Clicked on: " + gameObject.name);
        //change color
        Image image = GetComponent<Image>();
        image.color = Color.white;
        Boxes.GetComponent<Boxes>()._pressedButton = GetComponent<Button>();
    }
    public void ChangeColorBack()
    {
        Image image = GetComponent<Image>();
        image.color = initialColor;
    }
}