using System;
using Unity.VisualScripting;
using UnityEngine;

public class sheepSpawning : MonoBehaviour
{
    [Header("Sheep Object References")]

    [SerializeField] private GameObject sheep1;
    [SerializeField] private GameObject sheep2;
    [SerializeField] private GameObject sheep3;
    [SerializeField] private GameObject sheep4;
    [SerializeField] private GameObject sheep5;
    [SerializeField] private GameObject sheep6;
    [SerializeField] private GameObject sheep7;
    [SerializeField] private GameObject sheep8;
    [SerializeField] private GameObject sheep9;
    [SerializeField] private GameObject sheep10;
    [SerializeField] private GameObject sheep11;
    [SerializeField] private GameObject sheep12;

    [Header("Sheep Position References")]

    [SerializeField] private GameObject blankSheep1pos;
    [SerializeField] private GameObject blankSheep2pos;
    [SerializeField] private GameObject blankSheep3pos;
    [SerializeField] private GameObject blankSheep4pos;
    [SerializeField] private GameObject blankSheep5pos;
    [SerializeField] private GameObject blankSheep6pos;
    [SerializeField] private GameObject blankSheep7pos;
    [SerializeField] private GameObject blankSheep8pos;
    [SerializeField] private GameObject blankSheep9pos;
    [SerializeField] private GameObject blankSheep10pos;
    [SerializeField] private GameObject blankSheep11pos;
    [SerializeField] private GameObject blankSheep12pos;

    [Header("Dead Sheep Position References")]

    [SerializeField] private GameObject deadSheep1;
    [SerializeField] private GameObject deadSheep2;
    [SerializeField] private GameObject deadSheep3;
    [SerializeField] private GameObject deadSheep4;
    [SerializeField] private GameObject deadSheep5;
    [SerializeField] private GameObject deadSheep6;
    [SerializeField] private GameObject deadSheep7;
    [SerializeField] private GameObject deadSheep8;
    [SerializeField] private GameObject deadSheep9;
    [SerializeField] private GameObject deadSheep10;
    [SerializeField] private GameObject deadSheep11;
    [SerializeField] private GameObject deadSheep12;



    [Header("Sheep boolean Checks")]
    public bool sheepOneIsActive;
    public bool sheepTwoIsActive;
    public bool sheepThreeIsActive;
    public bool sheepFourIsActive;
    public bool sheepFiveIsActive;
    public bool sheepSixIsActive;
    public bool sheepSevenIsActive;
    public bool sheepEightIsActive;
    public bool sheepNineIsActive;
    public bool sheepTenIsActive;
    public bool sheepElevenIsActive;
    public bool sheepTweleveIsActive;

    [Header("Sheep boolean Checks")]
    public bool deadSheepOneIsActive;
    public bool deadSheepTwoIsActive;
    public bool deadSheepThreeIsActive;
    public bool deadSheepFourIsActive;
    public bool deadSheepFiveIsActive;
    public bool deadSheepSixIsActive;
    public bool deadSheepSevenIsActive;
    public bool deadSheepEightIsActive;
    public bool deadSheepNineIsActive;
    public bool deadSheepTenIsActive;
    public bool deadSheepElevenIsActive;
    public bool deadSheepTweleveIsActive;





    [Header("Sheep Value Positions")]

    public int sheepCount;
    public float speed = 10f;

    [Header("Script References")]

    [SerializeField] private MoneyManager moneyManager;

    private void Start()
    {
        sheepOneIsActive = true;
        sheepTwoIsActive = false;
        sheepThreeIsActive = false;
        sheepFourIsActive = false;
        sheepFiveIsActive = false;
        sheepSixIsActive = false;
        sheepSevenIsActive = false;
        sheepEightIsActive = false;
        sheepNineIsActive = false;
        sheepTenIsActive = false;
        sheepElevenIsActive = false;    
        sheepTweleveIsActive = false;

        
    }




    private void Update()
    {

        // if sheep are active statements 



       if (sheepOneIsActive == true)
        {
            sheep1.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepTwoIsActive == true)
        {
            sheep2.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepThreeIsActive == true)
        {
            sheep3.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepFourIsActive == true)
        {
            sheep4.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepFiveIsActive == true)
        {
            sheep5.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepSixIsActive == true)
        {
            sheep6.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepSevenIsActive == true)
        {
            sheep7.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepEightIsActive == true)
        {
            sheep8.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepNineIsActive == true)
        {
            sheep9.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepTenIsActive == true)
        {
            sheep10.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepElevenIsActive == true)
        {
            sheep11.GetComponent<sheepInfomation>().enabled = true;
        }

        if (sheepTweleveIsActive == true)
        {
            sheep12.GetComponent<sheepInfomation>().enabled = true;
        }



        // if sheep are inactive statements



        if (sheepOneIsActive == false)
        {
            sheep1.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepTwoIsActive == false)
        {
            sheep2.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepThreeIsActive == false)
        {
            sheep3.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepFourIsActive == false)
        {
            sheep4.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepFiveIsActive == false)
        {
            sheep5.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepSixIsActive == false)
        {
            sheep6.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepSevenIsActive == false)
        {
            sheep7.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepEightIsActive == false)
        {
            sheep8.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepNineIsActive == false)
        {
            sheep9.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepTenIsActive == false)
        {
            sheep10.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepElevenIsActive == false)
        {
            sheep11.GetComponent<sheepInfomation>().enabled = false;
        }

        if (sheepTweleveIsActive == false)
        {
            sheep12.GetComponent<sheepInfomation>().enabled = false;
        }
    }







}
