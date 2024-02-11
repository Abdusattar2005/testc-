using System;

class Program
{
    static void Main()
    {
        DrawChessboard();
    }

    static void DrawChessboard()
    {
        int boardSize = 8;

        for (int row = 0; row < boardSize; row++)
        {
            for (int col = 0; col < boardSize; col++)
            {
                char cellSymbol = (row + col) % 2 == 0 ? '█' : ' ';

                Console.Write(cellSymbol);
            }

            Console.WriteLine(); 
        }
    }
}
