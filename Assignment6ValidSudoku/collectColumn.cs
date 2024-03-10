namespace Assignment6ValidSudoku;

public class collectColumn
{
    public static List<List<char>> ColumnResult(List<List<char>> board)
    {
        List<List<char>> result = new List<List<char>>();
        for (int i = 0; i < board.Count; i++)
        {
            List<char> numbers = new List<char>();
            foreach (List<char> line in board)
            {
                if (char.IsDigit(line[i]))
                {
                    numbers.Add(line[i]);
                }
            }
            result.Add(numbers);
        }
        return result;
    }
}