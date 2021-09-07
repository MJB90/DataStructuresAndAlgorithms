using System;

namespace DataStructuresAndAlgorithms.TicTacToe
{
    class TicTacToe
    {
		/*This class calculates whether O or X has won in the current state
		 Input: arr--> state of tic tac toe
		 Output: '.'--> No winner
				 'X'--> X won
				 'O'--> O won
				 'I'--> Invalid ( 2 winners )
		 */
		public static char whoWon(char[,] arr)
		{
			//Local variables
			char won = '.';

			//Check all the elements in first row for winner
			if (arr[0,0] == arr[0,1] && arr[0,1] == arr[0,2] && arr[0,0] != '.')
			{
				won = arr[0,0];
			}
			//Check all the elements in second row for winner
			if (arr[1,0] == arr[1,1] && arr[1,1] == arr[1,2] && arr[1,0] != '.')
			{
				if (won != arr[1,0] && won != '.') return 'I';
				won = arr[1,0];

			}
			//Check all the elements in third row for winner
			if (arr[2,0] == arr[2,1] && arr[2,1] == arr[2,2] && arr[2,0] != '.')
			{
				if (won != arr[2,0] && won != '.') return 'I';
				won = arr[2,0];
			}
			//Check all the elements in first column for winner
			if (arr[0,0] == arr[1,0] && arr[1,0] == arr[2,0] && arr[0,0] != '.')
			{
				if (won != arr[0,0] && won != '.') return 'I';
				won = arr[0,0];
			}
			//Check all the elements in second column for winner
			if (arr[0,1] == arr[1,1] && arr[1,1] == arr[2,1] && arr[0,1] != '.')
			{
				if (won != arr[0,1] && won != '.') return 'I';
				won = arr[0,1];
			}
			//Check all the elements in third column for winner
			if (arr[0,2] == arr[1,2] && arr[1,2] == arr[2,2] && arr[2,2] != '.')
			{
				if (won != arr[0,2] && won != '.') return 'I';
				won = arr[0,2];
			}
			//Check all the elements in right diagonal for winner
			if (arr[0,0] == arr[1,1] && arr[1,1] == arr[2,2] && arr[0,0] != '.')
			{
				if (won != arr[0,0] && won != '.') return 'I';
				won = arr[0,0];
			}
			//Check all the elements in left diagonal for winner
			if (arr[0,2] == arr[1,1] && arr[1,1] == arr[2,0] && arr[0,2] != '.')
			{
				if (won != arr[0,2] && won != '.') return 'I';
				won = arr[0,2];
			}
			return won;

		}
		/*This method prints the current state of tic tac toe
		 Input: arr--> state of tic tac toe
		 Output: state of the tic tac toe board
		 */
		public static void OutputState(char[,] arr)
        {
			//Local variables
			int i, j, numX = 0, numO = 0;
			char won = whoWon(arr);
			string winner = "";
			winner +=won;

			//Calcualte the number of X and O
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
					if (arr[i, j] == 'X') numX++;
					else if (arr[i, j] == 'O') numO++;
                }
            }

			//If the state has more O's than X's , this state is invalid as X started first 
			if (numO > numX || won == 'I') Console.WriteLine("Wait, what?");
			//For O to win, the number of O must be equal to X as O started second
			else if (won == 'O' && numX == numO)
			{
				Console.WriteLine(winner + " won.");
			}
			//For X to win, the number of X must be greater than O as X started first
			else if (won == 'X' && numX > numO)
			{
				Console.WriteLine(winner + " won.");
			}
			//if there is a winner without satisfying above conditions then they kept playing even after a winner is declared
			//This is invalid
			else if (won != '.')
			{
				Console.WriteLine("Wait, what?");
			}
			//if there is no winner and all the places are filled then it is a draw
			else if (numX + numO == 9)
			{
				Console.WriteLine("It's a draw.");
			}
			//if there is no winner and there are empty cells and number of X is equal to number of O then it is X's turn 
			else if (numX == numO)
			{
				Console.WriteLine("X's turn.");
			}
			//if there is no winner and there are empty cells and number of X is equal to number of O + 1 then it is O's turn
			else if (numX == numO + 1) Console.WriteLine("O's turn.");
			//otherwise it is invalid
			else Console.WriteLine("Wait, what?");
		}
        public static void Main()
        {
			/*            char[,] state1 =
						{
							{'O','.','X' },
							{'.','O','X' },
							{'.','.','X' }
						};
			*/
			char[,] state1 = new char[3,3];
			string l1 = Console.ReadLine();
			string l2 = Console.ReadLine();
			string l3 = Console.ReadLine();

			for(int i = 0; i < 3; i++)
            {
				state1[0, i] = l1[i];
				state1[1, i] = l2[i];
				state1[2, i] = l3[i];
			}
			OutputState(state1);
		}
    }
}
