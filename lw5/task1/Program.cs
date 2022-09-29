using task1;

MyMatrix matrix = new MyMatrix(10, 5, 0, 9);
matrix.Show();
Console.WriteLine();

matrix.Fill();
matrix.Show();
Console.WriteLine();

matrix.ChangeSize(4, 8);
matrix.Show();
Console.WriteLine();

foreach (var m in matrix)
{
    Console.Write(m);
}
Console.WriteLine();

matrix.ShowPartialy(0, 0, 0, 2);