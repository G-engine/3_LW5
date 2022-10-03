using System.Collections;

namespace task1;

public class MyMatrix : IEnumerable
{
    private int[,]? matrix;
    private int n1;
    private int n2;
    private int x;
    private int y;

    public MyMatrix(int x, int y, int number1, int number2)
    {
        matrix = new int[x, y];
        this.x = x;
        this.y = y;
        n1 = number1;
        n2 = number2;
        Random rnd = new Random();
        
        for(int i = 0; i < x; ++i)
            for (int j = 0; j < y; ++j)
            {
                matrix[i, j] = rnd.Next(n1, n2 + 1);
            }
    }
    public IEnumerator GetEnumerator() => matrix.GetEnumerator();
    public void Fill()
    {
        Random rnd = new Random();
        for(int i = 0; i < x; ++i)
            for (int j = 0; j < y; ++j)
            {
                matrix[i, j] = rnd.Next(n1, n2 + 1);
            }
    }

    public void ChangeSize(int x, int y)
    {
        Random rnd = new Random();
        int[,] newMatrix = new int[x, y];
        for(int i = 0; i < x; ++i)
            for (int j = 0; j < y; ++j)
            {
                if (i < this.x && j < this.y)
                    newMatrix[i, j] = matrix[i, j];
                else 
                    newMatrix[i,j] = rnd.Next(n1, n2 + 1);
            }

        this.x = x;
        this.y = y;
        
        matrix = newMatrix;
    }

    public void ShowPartialy(uint firstRow, uint lastRow, uint firstColumn, uint lastColumn)
    {
        if (firstRow <= lastRow && firstColumn <= lastColumn && lastRow < x && lastColumn < y)
        {
            for (uint i = firstRow; i <= lastRow; ++i)
            {
                for (uint j = firstColumn; j <= lastColumn; ++j)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
                
        }
    }

    public void Show()
    {
        for (int i = 0; i < x; ++i)
        {
            for (int j = 0; j < y; ++j)
                Console.Write($"{matrix[i,j]} ");
            Console.WriteLine();
        }
    }

    public int this[int index1, int index2]
    {
        get
        {
            if (index1 < 0 || index1 >= x || index2 < 0 || index2 >= y)
                return 0;
            return matrix[index1, index2];
        }
        set 
        {
            if (index1 < 0 || index1 >= x || index2 < 0 || index2 >= y) {}
            else matrix[index1, index2] = value;
        }
    }
}