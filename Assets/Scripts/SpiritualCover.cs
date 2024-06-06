using MalbersAnimations;
using MalbersAnimations.Controller;
using MalbersAnimations.Scriptables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritualCover : MonoBehaviour
{
    [SerializeField] public GameObject _bushMesh;
    [SerializeField] public GameObject _wolfMesh;
    private bool _bushIsActive = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            Debug.Log("HONK!");
            if (_bushIsActive)
            {
                _wolfMesh.SetActive(true);
                _bushMesh.SetActive(false);
                _bushIsActive = false;

                gameObject.GetComponent<TransformHook>().SetEnable(true);
                gameObject.GetComponent<MAnimal>().SetEnable(true);
            }
            else if (!_bushIsActive)
            {
                _wolfMesh.SetActive(false);
                _bushMesh.SetActive(true);
                _bushIsActive = true;

                gameObject.GetComponent<TransformHook>().SetEnable(false);
                gameObject.GetComponent<MAnimal>().SetEnable(false);
            }
        }
    }
}
