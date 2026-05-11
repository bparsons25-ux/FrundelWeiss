using UnityEngine;
using System.Collections;

public class sheepDay7 : MonoBehaviour
{
    [SerializeField] private GameObject transition;
    [SerializeField] private GameObject bloodSplatter;
    [SerializeField] private ObjectiveCounter ObjectiveCounter;
    [SerializeField] private GameObject OrganHarvest1;
    [SerializeField] private GameObject sheepConvo;
    [SerializeField] private GameObject sheep1;



    private float transitionTime = 5f;

    private void Start()
    {
        transition.gameObject.SetActive(true);
        OrganHarvest1.gameObject.SetActive(false);
        sheepConvo.gameObject.SetActive(false);
    }

    public void OrganMethod()
    {
        
        StartCoroutine(Organtrans());
    }

    IEnumerator Organtrans()
    {

        transition.gameObject.SetActive(true);
        bloodSplatter.gameObject.SetActive(true);
        yield return new WaitForSeconds(transitionTime);
        bloodSplatter.gameObject.SetActive(false);
        transition.gameObject.SetActive(false);
        OrganHarvest1.gameObject.SetActive(true);
        sheepConvo.gameObject.SetActive(false);
        OrganHarvest1.GetComponent<OrganHarvestingMode>().StartHarvesting();

    }


}
