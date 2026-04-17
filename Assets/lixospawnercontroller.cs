using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class lixospawnercontroller : MonoBehaviour
{
    public float maximumX;
    public float fixedY;
    public float fixedZ;
    public float timer;
    public GameObject Lixo;
    public int MaxPoints;
    public int points = 0;

    public TMP_Text pointsText;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }


    void Update()
    {
        
    }

    IEnumerator SpawnRoutine()
    {
        while (points < MaxPoints)
        {
            Instantiate(Lixo,
                new Vector3(Random.Range(-maximumX, maximumX + 1),
                fixedY,
                fixedZ),
                Quaternion.identity);
        
            yield return new WaitForSeconds(timer);
        }
    }
    public void AddToPoints(int value)
    {
        points += value;
        pointsText.text = "Points: "+points.ToString();
    }
    
}