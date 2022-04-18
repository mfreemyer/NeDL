
int[,,] test = new int [5, 10, 2];
for (int rowIndex = 0; rowIndex < 5; rowIndex++)
{
    for (int colIndex = 0; colIndex < 10; colIndex++)
    {
        for (int rowDepth = 0; rowDepth <2; rowDepth++)
        {
            test[rowIndex,colIndex,rowDepth] = rowIndex*colIndex*rowDepth;
            Console.WriteLine("Row: " + rowIndex + "  col: " + colIndex + "  depth: " + rowDepth + "  contents: " + test[rowIndex,colIndex,rowDepth]);
        }

    }
}
