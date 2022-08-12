namespace Matrics 
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = { { 8, 6, 3, 5 },
                        { 3, 4, 7, 3 },
                        { 4, 1, 3, 5 },
                        { 8, 3, 5, 7 } };

            Console.WriteLine(Matrix(mat, 4));

            // Method Determines the cofactor of matrix  
            static void Cofactor(int[,] mat, int[,] temp,
                                    int p, int q, int n)
            {
                int i = 0, j = 0;



                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (row != p && col != q)
                        {
                            temp[i, j++] = mat[row, col];

                            // mpves to new row
                            if (j == n - 1)
                            {
                                j = 0;
                                i++;
                            }
                        }
                    }
                }
            }

            //method to calculate determinant
            static int Matrix(int[,] mat, int n)
            {
                int d = 0;


                if (n == 1)
                    return mat[0, 0];

                // To store cofactors
                int[,] temp = new int[4, 4];

                // To store sign multiplier
                int sign = 1;

                // Iterate through the first row
                for (int f = 0; f < n; f++)
                {

                    Cofactor(mat, temp, 0, f, n);
                    d += sign * mat[0, f]
                         * Matrix(temp, n - 1);

                    // alternates sign

                    sign = -sign;
                }

                return d;
            }


        }
    }
}



























