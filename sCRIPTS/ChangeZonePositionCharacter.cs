using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeZonePositionCharacter : MonoBehaviour
{
    //private CharacterController charController;
    //private Animator charAnimator;
    //public GameObject zonePanel;

    public Transform zone1;
    public Transform zone2;
    public Transform zone3;
    public Transform zone4;
    public Transform zone5;
    //public Transform zone6;
    //public Transform zone7;
    //public Transform zone8;
    //public Transform zone9;
    //public Transform zone10;
    //public Transform zone11;




    //private bool GoToZoneOnClickFunction;

    //private float inputX;
    //private float inputZ;
    //private Vector3 v_movement;
    //private Vector3 v_velocity;

    //public float camSpeed;
    //public float moveSpeed;
    //private float gravity;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    //Zone1Mirage();
    //    //Zone2Mirage();
    //    GameObject temporaryCharacter = GameObject.FindGameObjectWithTag("Camera");
    //    charController = temporaryCharacter.GetComponent<CharacterController>();
    //    charAnimator = temporaryCharacter.transform.GetChild(0).GetComponent<Animator>();

    //    camSpeed = 0.8f;
    //    moveSpeed = 150f;

    //    gravity = 0.5f;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    inputX = Input.GetAxis("Horizontal");
    //    inputZ = Input.GetAxis("Vertical");
    //    if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
    //    {
    //        zonePanel.gameObject.SetActive(false);
    //        charController.enabled = true;
    //    }
    //}

    //private void FixedUpdate()
    //{
    //    //Input Forward
    //    v_movement = charController.transform.forward * inputZ;

    //    //char Rotate 
    //    charController.transform.Rotate(Vector3.up * inputX * camSpeed * (100f * Time.deltaTime));

    //    //Char Move
    //    charController.Move(v_movement * moveSpeed * Time.deltaTime);
    //}

    //Zones Mirages----------------------########################################----------------
    //public void AllOff()
    //{
    //    images1.gameObject.SetActive(false);
    //    images2.gameObject.SetActive(false);
    //    images3.gameObject.SetActive(false);
    //    images4.gameObject.SetActive(false);
    //    images5.gameObject.SetActive(false);
    //    images6.gameObject.SetActive(false);
    //    images7.gameObject.SetActive(false);
    //    images8.gameObject.SetActive(false);
    //    images9.gameObject.SetActive(false);
    //    images10.gameObject.SetActive(false);
    //    images11.gameObject.SetActive(false);

    //}
    public void Zone1Mirage()
    {
        //zonePanel.gameObject.SetActive(true);
        //AllOff();
        //images1.gameObject.SetActive(true);
        //charController.enabled = false;
        Debug.Log("Zone1 position change");
        transform.position = zone1.transform.position;
        transform.rotation = zone1.rotation;
    }

    public void Zone2Mirage()
    {
        //zonePanel.gameObject.SetActive(true);
        //AllOff();
        //images2.gameObject.SetActive(true);
        //charController.enabled = false;
        //Debug.Log("Zone2 position change");
        transform.position = zone2.transform.position;
        transform.rotation = zone2.rotation;
    }

    public void Zone3Mirage()
    {
        //zonePanel.gameObject.SetActive(true);
        //AllOff();
        //images3.gameObject.SetActive(true);
        //charController.enabled = false;
        //Debug.Log("Zone2 position change");
        transform.position = zone3.transform.position;
        transform.rotation = zone3.rotation;
    }

    public void Zone4Mirage()
    {
        //zonePanel.gameObject.SetActive(true);
        //AllOff();
        //images4.gameObject.SetActive(true);
        //charController.enabled = false;
        //Debug.Log("Zone2 position change");
        transform.position = zone4.transform.position;
        transform.rotation = zone4.rotation;
    }

    public void Zone5Mirage()
    {
        //zonePanel.gameObject.SetActive(true);
        //AllOff();
        //images5.gameObject.SetActive(true);
        //charController.enabled = false;
        Debug.Log("Zone2 position change");
        transform.position = zone5.transform.position;
        transform.rotation = zone5.rotation;
    }

    //public void Zone6Mirage()
    //{

    //    zonePanel.gameObject.SetActive(true);
    //    AllOff();
    //    images6.gameObject.SetActive(true);
    //    charController.enabled = false;
    //    Debug.Log("Zone2 position change");
    //    transform.position = zone6.transform.position;
    //    transform.rotation = zone6.rotation;
    //}

    //public void Zone7Mirage()
    //{
    //    zonePanel.gameObject.SetActive(true);
    //    AllOff();
    //    images7.gameObject.SetActive(true);
    //    charController.enabled = false;
    //    Debug.Log("Zone2 position change");
    //    transform.position = zone7.transform.position;
    //    transform.rotation = zone7.rotation;
    //}

    //public void Zone8Mirage()
    //{
    //    zonePanel.gameObject.SetActive(true);
    //    AllOff();
    //    images8.gameObject.SetActive(true);
    //    charController.enabled = false;
    //    Debug.Log("Zone2 position change");
    //    transform.position = zone8.transform.position;
    //    transform.rotation = zone8.rotation;
    //}

    //public void Zone9Mirage()
    //{
    //    zonePanel.gameObject.SetActive(true);
    //    AllOff();
    //    images9.gameObject.SetActive(true);
    //    charController.enabled = false;
    //    Debug.Log("Zone2 position change");
    //    transform.position = zone9.transform.position;
    //    transform.rotation = zone9.rotation;
    //}

    //public void Zone10Mirage()
    //{
    //    zonePanel.gameObject.SetActive(true);
    //    AllOff();
    //    images10.gameObject.SetActive(true);
    //    charController.enabled = false;
    //    Debug.Log("Zone2 position change");
    //    transform.position = zone10.transform.position;
    //    transform.rotation = zone10.rotation;
    //}

    //public void Zone11Mirage()
    //{
    //    zonePanel.gameObject.SetActive(true);
    //    AllOff();
    //    images11.gameObject.SetActive(true);
    //    charController.enabled = false;
    //    Debug.Log("Zone2 position change");
    //    transform.position = zone11.transform.position;
    //    transform.rotation = zone11.rotation;
    //}
}
