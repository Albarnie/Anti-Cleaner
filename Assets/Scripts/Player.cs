using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    

    public int currentItem;
    public GameObject[] items = new GameObject[3];
    public bool usingItem;
    public Transform pivot;

    float rotation;
    float lastRot;
    public float rotDelta;

    private void Awake()
    {
        SetReferences();
    }

    void SetReferences ()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        lastRot = rotation;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = mousePos - pivot.position;
        rotation = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        pivot.rotation = Quaternion.Slerp(pivot.rotation, Quaternion.Euler(0, 0, rotation), Time.deltaTime * 10);

        rotDelta = rotation - lastRot;
        if (Input.GetMouseButton(0))
        {
            Use();
        }
        else if (usingItem)
        {
            foreach(GameObject obj in items)
            {
                obj.SetActive(false);
            }
            usingItem = false;
        }
    }

    void Use ()
    {
        if (!usingItem)
        {
            usingItem = true;
            items[currentItem].SetActive(true);
        }

        switch (currentItem)
        {
            //Vaccum cleaner
            case 0:

                break;

            //Sledgehammer
            case 1:

                break;

            //Mop
            case 2:

                break;

            //None
            default:

                break;
        }
    }

}
