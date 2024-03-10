namespace Assignment6ValidSudoku;

class Program
{
    static void Main(string[] args)
    {
        List<List<char>> board =
        [
            ['5', '3', '.', '.', '7', '.', '.', '.', '.'],
            ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
            ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
            ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
            ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
            ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
            ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9']
        ];

        List<List<char>> checkRow = collectRow.RowResult(board);
        List<List<char>> checkColumn = collectColumn.ColumnResult(board);

        bool invalidSudoku = false;
        
        foreach (List<char> chars in checkRow)
        {
            if (chars.Any(x => chars.Count(y => y == x) > 1))
            {
                invalidSudoku = true;
                break;
            }
        }
        
        foreach (List<char> chars in checkColumn)
        {
            if (chars.Any(x => chars.Count(y => y == x) > 1))
            {
                invalidSudoku = true;
                break;
            }
        }
        
        Console.WriteLine(invalidSudoku ? "This board is invalid :(" : "This board is valid :)");
    }
}