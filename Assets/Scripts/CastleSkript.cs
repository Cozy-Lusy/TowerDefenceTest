﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CastleSkript : MonoBehaviour
{
    public int hpCastle = 100;
    public int damage = 10;

    public TextMeshProUGUI hpText;
    void Update()
    {
        hpText.text = hpCastle.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        //Если враг доходит до нашего замка вычитаем damage из жизней замка и уничтожаем врагов
        if (other.CompareTag("Enemy"))
        {
            hpCastle -= damage; 
            Destroy(other.gameObject);
            Destroy(other.GetComponent<EnemySkript>().hpEnemy);
        }
    }
}

//Добавить проверку если HP замка ниже или равно 0, то заканчивать игру.