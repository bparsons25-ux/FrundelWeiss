using System;
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

    [SerializeField] private Transform sheep1Pos;
    [SerializeField] private Transform sheep2Pos;
    [SerializeField] private Transform sheep3Pos;
    [SerializeField] private Transform sheep4Pos;
    [SerializeField] private Transform sheep5Pos;
    [SerializeField] private Transform sheep6Pos;
    [SerializeField] private Transform sheep7Pos;
    [SerializeField] private Transform sheep8Pos;
    [SerializeField] private Transform sheep9Pos;
    [SerializeField] private Transform sheep10Pos;
    [SerializeField] private Transform sheep11Pos;
    [SerializeField] private Transform sheep12Pos;

    [Header("Dead Sheep Position References")]

    [SerializeField] private Transform deadSheep1Pos;
    [SerializeField] private Transform deadSheep2Pos;
    [SerializeField] private Transform deadSheep3Pos;
    [SerializeField] private Transform deadSheep4Pos;
    [SerializeField] private Transform deadSheep5Pos;
    [SerializeField] private Transform deadSheep6Pos;
    [SerializeField] private Transform deadSheep7Pos;
    [SerializeField] private Transform deadSheep8Pos;
    [SerializeField] private Transform deadSheep9Pos;
    [SerializeField] private Transform deadSheep10Pos;
    [SerializeField] private Transform deadSheep11Pos;
    [SerializeField] private Transform deadSheep12Pos;

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
        if (sheepOneIsActive == true)
        {
            Vector3 oneSpawn = sheep1Pos.transform.position;
            Vector3 onePos = Vector3.MoveTowards(transform.position, sheep1Pos.transform.position, speed * Time.deltaTime);
            transform.position = onePos;
        }

        if (sheepTwoIsActive == true)
        {
            Vector3 twoSpawn = sheep2Pos.transform.position;
            Vector3 twoPos = Vector3.MoveTowards(transform.position, sheep2Pos.transform.position, speed * Time.deltaTime);
            transform.position = twoPos;
        }

        if (sheepThreeIsActive == true)
        {
            Vector3 threeSpawn = sheep3Pos.transform.position;
            Vector3 threePos = Vector3.MoveTowards(transform.position, sheep3Pos.transform.position, speed * Time.deltaTime);
            transform.position = threePos;
        }

        if (sheepFourIsActive == true)
        {
            Vector3 fourSpawn = sheep4Pos.transform.position;
            Vector3 fourPos = Vector3.MoveTowards(transform.position, sheep4Pos.transform.position, speed * Time.deltaTime);
            transform.position = fourPos;
        }

        if (sheepFiveIsActive == true)
        {
            Vector3 fiveSpawn = sheep5Pos.transform.position;
            Vector3 fivePos = Vector3.MoveTowards(transform.position, sheep5Pos.transform.position, speed * Time.deltaTime);
            transform.position = fivePos;
        }

        if (sheepSixIsActive == true)
        {
            Vector3 sixSpawn = sheep6Pos.transform.position;
            Vector3 sixPos = Vector3.MoveTowards(transform.position, sheep6Pos.transform.position, speed * Time.deltaTime);
            transform.position = sixPos;
        }

        if (sheepSevenIsActive == true)
        {
            Vector3 sevenSpawn = sheep7Pos.transform.position;
            Vector3 sevenPos = Vector3.MoveTowards(transform.position, sheep7Pos.transform.position, speed * Time.deltaTime);
            transform.position = sevenPos;
        }

        if (sheepEightIsActive == true)
        {
            Vector3 eightSpawn = sheep8Pos.transform.position;
            Vector3 eightPos = Vector3.MoveTowards(transform.position, sheep8Pos.transform.position, speed * Time.deltaTime);
            transform.position = eightPos;
        }

        if (sheepNineIsActive == true)
        {
            Vector3 nineSpawn = sheep9Pos.transform.position;
            Vector3 ninePos = Vector3.MoveTowards(transform.position, sheep9Pos.transform.position, speed * Time.deltaTime);
            transform.position = ninePos;
        }

        if (sheepTenIsActive == true)
        {
            Vector3 tenSpawn = sheep10Pos.transform.position;
            Vector3 tenPos = Vector3.MoveTowards(transform.position, sheep10Pos.transform.position, speed * Time.deltaTime);
            transform.position = tenPos;
        }

        if (sheepElevenIsActive == true)
        {
            Vector3 elevenSpawn = sheep11Pos.transform.position;
            Vector3 elevenPos = Vector3.MoveTowards(transform.position, sheep11Pos.transform.position, speed * Time.deltaTime);
            transform.position = elevenPos;
        }

        if (sheepTweleveIsActive == true)
        {
            Vector3 tweleveSpawn = sheep12Pos.transform.position;
            Vector3 twelevePos = Vector3.MoveTowards(transform.position, sheep12Pos.transform.position, speed * Time.deltaTime);
            transform.position = twelevePos;
        }









































    }



}
