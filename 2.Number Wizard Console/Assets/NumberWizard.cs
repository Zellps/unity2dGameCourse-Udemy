using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {

        StartGame();
        max = 1000;
        min = 1;
        guess = 500;
           
    }

    void StartGame()
    {

        Debug.Log("Bem-vindo ao Mestre dos Números, seu FDP"); // poderia usar print(""); mas o Debug.Log é melhor.
        Debug.Log("Pense em um número, e não me diga...");
        Debug.Log("O maior número que pode ser escolhido é: " + max);
        Debug.Log("O menor número que pode ser escolhido é: " + min);
        Debug.Log("Me diga se o seu número é maior ou menor que " + guess);
        Debug.Log("Seta pra cima = Maior, Seta pra baixo = Menor, Enter = Acertou");
        max = max + 1;

        
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { 
           
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();

        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Que bruxaria é essa!!!");
            StartGame();
        }

               
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("É maior ou menor que " + guess);
    }

}
