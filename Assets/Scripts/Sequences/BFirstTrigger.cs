using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BFirstTrigger : MonoBehaviour
{
    public GameObject ThePlayer;
    public CharacterController characterController;// Reference to your CharController_Motor script
    public GameObject TextBox;
    public GameObject TheMarker;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            characterController.enabled = false;
            StartCoroutine(ScenePlayer());
        }
    }

    IEnumerator ScenePlayer()
    {
        TextBox.GetComponent<Text>().text = "Looks like a weapon on that table.";
        yield return new WaitForSeconds(2.5f);
        TextBox.GetComponent<Text>().text = "";
        characterController.enabled = true;
        TheMarker.SetActive(true);
    }
}
