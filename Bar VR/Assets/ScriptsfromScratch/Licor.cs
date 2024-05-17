using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Licor : MonoBehaviour
{
    public GameObject death; //GameObject of death mix

    public GameObject darkgreen; //GameObject of the result of Ron+Abstin

    public GameObject darkblue; //GameObject of the result of Ron+Blue

    public GameObject redwine; //GameObject of the result of Ron+Cran

    public GameObject limegreen; //GameObject of the result of Tequila+Abstin

    public GameObject green; //GameObject of the result of Tequila+Blue

    public GameObject orange; //GameObject of the result of Tequila+Cran

    public GameObject lightblue; //GameObject of the result of Vodka+Blue

    public GameObject lightgreen; //GameObject of the result of Vodka+Abstin

    public GameObject pink; //GameObject of the result of Vodka+Cran

    public GameObject goldengreen; //GameObject of the result of Vhisky+Abstin

    public GameObject goldenblue; //GameObject of the result of Whisky+Blue

    public GameObject goldenred; //GameObject of the result of Whisky+Cran

    public GameObject cyan; //GameObject of the result of Abstin+Blue

    public GameObject yellowbrown; //GameObject of the result of Abstin+Cran

    public GameObject purple; //GameObject of the result of Blue+Cran

    public GameObject glass; //GameObject of the glass
    
    public float liquidone; //Float that stores the value of the first liquid

    public float liquidtwo; //Float that stores the value of the second liquid

    public float drink; //Float that stores the value of the mix

    public float bottle; //Float that stores the value of the bottle grabbed

    public float GrabRange = 0.5f;
    public LayerMask LicorLayer; // Configura esta capa para tus enemigos

    public float order; //float that stores the value of the order of the client
    
    
    // Start is called before the first frame update
    void Start()
    {
        death.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (drink == 4.3 || drink == 6.4 || drink == 8.5 || drink == 10.7 || drink == 10.6)
        {
            death.SetActive(true);
        }

        if (liquidtwo >= 1)
        {
            Brevage();
        }
    }

    public void Brevage()
    {
        if (liquidone >= 1 && liquidtwo >=1)
        {
            drink = liquidone + liquidtwo;
        }

        if (drink.Equals(3.1f))
        {
            darkgreen.SetActive(true);
        }
        else if (drink.Equals(5.1f))
        {
            darkblue.SetActive(true);
        }
        else if (drink.Equals(5.2f))
        {
            lightgreen.SetActive(true);
        }
        else if (drink.Equals(6))
        {
            cyan.SetActive(true);
        }
        else if (drink.Equals(7.1f))
        {
            redwine.SetActive(true);
        }
        else if (drink.Equals(7.2f))
        {
            lightblue.SetActive(true);
        }
        else if (drink.Equals(7.3f))
        {
            limegreen.SetActive(true);
        }
        else if (drink.Equals(8))
        {
            yellowbrown.SetActive(true);
        }
        else if (drink.Equals(9.2f))
        {
            pink.SetActive(true);
        }
        else if (drink.Equals(9.3f))
        {
            green.SetActive(true);
        }
        else if (drink.Equals(9.4f))
        {
            goldengreen.SetActive(true);
        }
        else if (drink.Equals(10))
        {
            purple.SetActive(true);
        }
        else if (drink.Equals(11.3f))
        {
            orange.SetActive(true);
        }
        else if (drink.Equals(11.4f))
        {
            goldenblue.SetActive(true);
        }
        else if (drink.Equals(13.4f))
        {
            goldenred.SetActive(true);
        }
    }
    
    public void LicorCheck()
    {
        Collider[] ServeLicor = Physics.OverlapSphere(transform.position, GrabRange, LicorLayer);

        foreach (Collider Bottle in ServeLicor)
        {
            switch (tag)
            {
                case "Ron":
                    bottle = 1.1f;
                    break;
                case "Vodka":
                    bottle = 3.2f;
                    break;
                case "Tequila":
                    bottle = 5.3f;
                    break;
                case "Whisky":
                    bottle = 7.4f;
                    break;
                case "Abstin":
                    bottle = 2;
                    break;
                case "Blue":
                    bottle = 4;
                    break;
                case "Cranberry":
                    bottle = 6;
                    break;
            }

            if (liquidone.Equals(0))
            {
                liquidone = bottle;
            }
            else
            {
                liquidtwo = bottle;
            }

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Death")
        {
            death.SetActive(false);
            drink = 0;
            liquidone = 0;
            liquidtwo = 0;
        }
        else if (other.tag == "Drinkable")
        {
            CheckDrink();
        }
    }

    public void CheckDrink()
    {
        if (order == drink)
        {
            Destroy(glass);
            
            liquidone = 0;
            liquidtwo = 0;
            drink = 0;

            if (darkgreen.activeSelf)
            {
                darkgreen.SetActive(false);
            }
            else if (darkblue.activeSelf)
            {
                darkblue.SetActive(false); 
            }
            else if (redwine.activeSelf)
            {
                redwine.SetActive(false); 
            }
            else if (limegreen.activeSelf)
            {
                limegreen.SetActive(false);
            }
            else if (green.activeSelf)
            {
                green.SetActive(false);
            }
            else if (orange.activeSelf)
            {
                orange.SetActive(false);
            }
            else if (lightblue.activeSelf)
            {
                lightblue.SetActive(false); 
            }
            else if (lightgreen.activeSelf)
            {
                lightgreen.SetActive(false); 
            }
            else if (pink.activeSelf)
            {
                pink.SetActive(false); 
            }
            else if (goldengreen.activeSelf)
            {
                goldengreen.SetActive(false); 
            }
            else if (goldenblue.activeSelf)
            {
                goldenblue.SetActive(false); 
            }
            else if (goldenred.activeSelf)
            {
                goldenred.SetActive(false);  
            }
            else if (cyan.activeSelf)
            {
                cyan.SetActive(false); 
            }
            else if (yellowbrown.activeSelf)
            {
                yellowbrown.SetActive(false); 
            }
            else if (purple.activeSelf)
            {
                purple.SetActive(false); 
            }
             
            
        }
    }
}
