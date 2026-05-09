using System.Collections;

public class NQueenSolution
{
    public static List<List<string>> SolveNQueens(int n)
    {
        List<List<string>> results = new List<List<string>>();
        List<List<string>> board = new List<List<string>>();

        // Fill the board with empty cells
        for (int i = 0; i < n; i++)
        {
            List<string> row = new List<string>();
            for (int j = 0; j < n; j++)
            {
                row.Add(".");
            }
            board.Add(row);
        }
        
        SolveNQueensHelper(0, board, results);
        return results;
    }

    private static bool SolveNQueensHelper(int column, List<List<string>> board, List<List<string>> results)
    {
        if(column >= board.Count)
        {
            if(isValidBoard(board))
            {
                // Found a valid solution, add it to results    
                List<string> solution = new List<string>();
                foreach (var r in board)
                {
                    solution.Add(string.Join("", r));
                }
                results.Add(solution);

                return true;
            }

            return false;
        }

        for(int i = 0; i < board.Count; i++)
        {
            if(IsSafe(board, i, column))
            {
                // Place the queen
                board[i][column] = "Q";

                // Recur to place the next queen
                SolveNQueensHelper(column + 1, board, results);

                // Backtrack and remove the queen
                board[i][column] = ".";
            }
        }

        return true;
    }

    private static bool IsSafe(List<List<string>> board, int row, int col)
    {
        // Check this row
        for (int j = 0; j < col; j++)
        {
            if (board[row][j] == "Q") return false;
        }

        // check the column
        for (int i = 0; i < row; i++)
        {
            if (board[i][col] == "Q") return false;
        }

        // check diagonal
        for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
        {
            if (board[i][j] == "Q") return false;
        }

        return true;
    }

    private static bool isValidBoard(List<List<string>> board)
    {
        int n = board.Count;

        // Check rows and columns
        for (int i = 0; i < n; i++)
        {
            int queenCountRow = 0;
            int queenCountCol = 0;
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == "Q") queenCountRow++;
                if (board[j][i] == "Q") queenCountCol++;
            }
            if (queenCountRow > 1 || queenCountCol > 1) return false;
        }

        // Check diagonals
        for (int d = -n + 1; d < n; d++)
        {
            int queenCountDiag1 = 0;
            int queenCountDiag2 = 0;
            for (int i = 0; i < n; i++)
            {
                int j1 = i + d;
                int j2 = n - 1 - i - d;
                if (j1 >= 0 && j1 < n && board[i][j1] == "Q") queenCountDiag1++;
                if (j2 >= 0 && j2 < n && board[i][j2] == "Q") queenCountDiag2++;
            }
            if (queenCountDiag1 > 1 || queenCountDiag2 > 1) return false;
        }

        return true;
    }
}