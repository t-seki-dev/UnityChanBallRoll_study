using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UnityChan;
    public AudioSource gameBGM;
    public AudioSource goalBGM;

    public GameObject retryButton;

    void Start()
    {
        retryButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        UnityChan.transform.LookAt(Camera.main.transform);
        UnityChan.GetComponent<Animator>().SetTrigger("Goal");

        gameBGM.Stop();
        goalBGM.Play();

        retryButton.SetActive(true);
    }

    public void RetryStage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
