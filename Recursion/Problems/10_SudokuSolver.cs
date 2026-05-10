using System.Net;

public class SudokuSolverSolution {
    public void SolveSudoku(char[][] board) {
        Solve(board, 0, 0);
    }

    private static bool Solve(char[][] board, int row, int col) {
       for(int i = 0 ; i < board.Length; i++){
            for(int j = 0 ; j < board[0].Length; j++){
                if(board[i][j] == '.'){
                    for(char num = '1'; num <= '9'; num++)
                    {
                        if(board[i][j] == '.')
                        {
                            if(IsValid(board, i, j, num)){
                                board[i][j] = num; // Place the number

                                if(Solve(board, row, col)){
                                    return true; // Continue to solve the next cell
                                }
                                board[i][j] = '.'; // Backtrack
                            }
                        }
                    }
                    return false; // No valid number found, trigger backtracking
                }
            }
        }
        return true; // Solved
    }

    private static bool IsValid(char[][] board, int row, int col, char num) {
        // Check row and column
        for (int i = 0; i < 9; i++) {
            if (board[row][i] == num || board[i][col] == num) {
                return false;
            }
        }

        // Check 3x3 box
        int boxRowStart = (row / 3) * 3;
        int boxColStart = (col / 3) * 3;
        for (int i = boxRowStart; i < boxRowStart + 3; i++) {
            for (int j = boxColStart; j < boxColStart + 3; j++) {
                if (board[i][j] == num) {
                    return false;
                }
            }
        }

        return true; // Valid placement
    }
}