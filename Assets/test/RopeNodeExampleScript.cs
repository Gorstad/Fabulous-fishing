using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeNodeExampleScript : MonoBehaviour
{
    public GameObject target, ropesample, lbond, rbond;

    private float step = 0.2f; //шаг веревки 
    private SpringJoint2D[] sj; //все компоненты пружины

    // Start is called before the first frame update
    void Start()
    {
        // Получаем все компоненты пружины
        sj = GetComponents<SpringJoint2D>();
        // Выключаем их (это нужно, чтобы корректно настроить связи).
        // Можно изначально держать их выключеными.
        sj[0].enabled = false;
        sj[1].enabled = false;

        // определяем вектор нашей цепи
        Vector3 tarvec = target.transform.position - transform.position;
        // проверяем, если дистанция до целевого объекта больше шага, то создаем звено
        if (tarvec.magnitude > step)
        {
            // создаем звено
            GameObject newrope = Instantiate(ropesample, transform.position +
                tarvec.normalized * step, Quaternion.identity);
            // получаем доступ к скрипту нового звена
            RopeNodeExampleScript newrope_rope = newrope.GetComponent<RopeNodeExampleScript>();
            // устанавливаем левую связь для нового звена
            newrope_rope.lbond = gameObject;
            // устанавливаем объект-цель для нового звена
            newrope_rope.target = target;
            // устанавливаем правую связь для текущего звена
            rbond = newrope;

        }
        else // если дистанция до целевого объекта меньше шага, то замыкаем цепь на нем
        {
            //замыкаем правую связь на объекте-цели
            rbond = target;
            //добавляем пружинную связь на объект цель
            SpringJoint2D ropeknot_sj = target.AddComponent<SpringJoint2D>();
            //эти параметры подбираются экспериментально по вкусу для своей игры
            ropeknot_sj.frequency = 25;
            ropeknot_sj.dampingRatio = 0;
            //присоединяем к этой связи наше звено
            ropeknot_sj.connectedBody = GetComponent<Rigidbody2D>();
        }
        
        //присоединяем к пружинам левое и правое тело
        sj[0].connectedBody = lbond.GetComponent<Rigidbody2D>();
        sj[1].connectedBody = rbond.GetComponent<Rigidbody2D>();
        //активируем пружинные модули
        sj[0].enabled = true;
        sj[1].enabled = true;
    }
}
