namespace Assignment6ValidSudoku;

public class collectRow
{
    public static List<List<char>> RowResult(List<List<char>> board)
    {
        List<List<char>> result = new List<List<char>>();
        foreach (List<char> line in board)
        {
            List<char> numbers = new List<char>();
            foreach (char number in line)
            {
                if (char.IsDigit(number))
                {
                    numbers.Add(number);
                }
            }
            result.Add(numbers);
        }
        return result;
    }
}