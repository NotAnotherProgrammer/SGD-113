using Unity.VisualScripting;
using UnityEngine;


public class RPSManagerFreeman2 : MonoBehaviour
{
    public string myMessage;

      enum Choice
    {
        Rock,
        Paper,
        Scissors,
    }

    int playerScore = 0;
    int computerScore = 0; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(myMessage = "Welcome to ROCK, PAPER, SCISSORS. Where its MAN VS MACHINE!!");
        Debug.Log(myMessage = "[R] = ROCK");
        Debug.Log(myMessage = "[P] = PAPER");
        Debug.Log(myMessage = "[S] = Scissors");
        Debug.Log(myMessage = "PAPER COVERS ROCK, ROCK SMASHES SCISSORS, SCISSORS CUT ROCK");
        Debug.Log(myMessage = "MAY THE BEST MAN OR MACHINE WIN!!");
        
    }

        void NumberInput()
    {
         if(Input.GetKeyUp(KeyCode.R))
        {
            Choice playerChoice = Choice.Rock;
            Choice computerChoice = (Choice)Random.Range(0,3);

             int randomNumber = Random.Range(0,3);
            
            switch(randomNumber)
            {
                case 1:
                    computerChoice = Choice.Rock;
                    break;
                
                case 2:
                    computerChoice = Choice.Paper;
                    break;
                
                case 3:
                    computerChoice = Choice.Scissors;
                    break;

                default:
                    Debug.Log("Invalid Data");
                    break;
            }

           
            Debug.Log("Player chose " + playerChoice);
            Debug.Log("Computer chose " + computerChoice);

            if(playerChoice == computerChoice)
            {
                Debug.Log("ITS A TIE!");
            }
            
            else if (computerChoice == Choice.Paper)
            {
                computerChoice ++;
                Debug.Log("MACHINE WINS!");
            }
            else
            {
                playerScore ++;
                Debug.Log("HUMAN WINS!");
            }

            Debug.Log("HUMAN: " + playerScore + " - MACHINE: " + computerScore);

        }
         if(Input.GetKeyUp(KeyCode.P))
        {
            Choice playerChoice = Choice.Paper;
            Choice computerChoice = (Choice)Random.Range(0,3);

             int randomNumber = Random.Range(0,3);
            
            switch(randomNumber)
            {
                case 1:
                    computerChoice = Choice.Rock;
                    break;
                
                case 2:
                    computerChoice = Choice.Paper;
                    break;
                
                case 3:
                    computerChoice = Choice.Scissors;
                    break;

                default:
                    break;
            }

            Debug.Log("Player chose " + playerChoice);
            Debug.Log("Computer chose " + computerChoice);

            if(playerChoice == computerChoice)
            {
                Debug.Log("ITS A TIE!");
            }
            
            else if (computerChoice == Choice.Scissors)
            {
                computerChoice ++;
                Debug.Log("MACHINE WINS!");
            }
            else
            {
                playerScore ++;
                Debug.Log("HUMAN WINS!");
            }

            Debug.Log("HUMAN: " + playerScore + " - MACHINE: " + computerScore);
        }
         if(Input.GetKeyUp(KeyCode.S))
        {
            Choice playerChoice = Choice.Scissors;
            Choice computerChoice = (Choice)Random.Range(0,3);

             int randomNumber = Random.Range(0,3);
            
            switch(randomNumber)
            {
                case 1:
                    computerChoice = Choice.Rock;
                    break;
                
                case 2:
                    computerChoice = Choice.Paper;
                    break;
                
                case 3:
                    computerChoice = Choice.Scissors;
                    break;

                default:
                    break;
            }

            Debug.Log("Player chose " + playerChoice);
            Debug.Log("Computer chose " + computerChoice);

             if(playerChoice == computerChoice)
            {
                Debug.Log("ITS A TIE!");
            }
            
            else if (computerChoice == Choice.Rock)
            {
                computerChoice ++;
                Debug.Log("MACHINE WINS!");
            }
            else
            {
                playerScore ++;
                Debug.Log("HUMAN WINS!");
            }

            Debug.Log("HUMAN: " + playerScore + " - MACHINE: " + computerScore);
        }
    }

    // Update is called once per frame
    void Update()
    {
        NumberInput();
    }
}
