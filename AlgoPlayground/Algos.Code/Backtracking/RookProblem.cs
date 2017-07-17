using Algos.Code.Extensions;
using System;
using System.Collections.Generic;

namespace Algos.Code.Backtracking
{
    public class RookProblem
    {
        private int size;
        private int count;
        private int[,] arr;

        private int[,] rooks;
        private Stack<int> stack = new Stack<int>();

        public RookProblem(int size, int count)
        {
            this.size = size;
            this.count = count;
            arr = new int[size, size];
            rooks = new int[size + 1, 2];
            stack.Push(1);
        }

        public void Solve()
        {
            int solutionsFound = 0;
            int rook = 0;
            int startCol = 0;
            int startRow = 0;

            while (true)
            {
                rook = stack.Pop();

                if (SetRookIfPossible(rook, startCol, startRow) && rook < count)
                {
                    rook++;
                    stack.Push(rook);
                    startCol = 0;
                    startRow = 0;
                    continue;
                }

                if (stack.Count == 0 && rook == size)
                {
                    arr.WriteToConsole(0, size, 0, size);                    
                    solutionsFound++;
                    Console.WriteLine(solutionsFound);
                }

                bool moveFew;
                arr[rooks[rook, 0], rooks[rook, 1]] = 0;
                rooks[rook, 0] = 0;
                rooks[rook, 1] = 0;

                do
                {
                    moveFew = false;
                    rook--;
                    stack.Push(rook);
                    int row = rooks[rook, 0];
                    int col = rooks[rook, 1];

                    rooks[rook, 0] = 0;
                    rooks[rook, 1] = 0;

                    arr[row, col] = 0;

                    if (col < size - 1)
                    {
                        startCol = col + 1;
                        startRow = row;
                    }
                    else
                    {
                        if (row < size - 1)
                        {
                            startCol = 0;
                            startRow = row + 1;
                        }
                        else
                        {
                            moveFew = true;
                            int onTheLastPosition = stack.Pop();

                            if (onTheLastPosition == 1)
                            {
                                Console.WriteLine(solutionsFound);
                                return;
                            }
                        }
                    }
                } while (moveFew);
            }
        }

        private bool SetRookIfPossible(int rook, int startCol, int startRow)
        {
            for (int row = startRow; row < size; row++)
            {
                for (int col = startCol; col < size; col++)
                {
                    if (CheckCell(row, col))
                    {
                        arr[row, col] = rook;
                        rooks[rook, 0] = row;
                        rooks[rook, 1] = col;
                        return true;
                    }
                }
            }

            return false;
        }

        private bool CheckCell(int row, int col)
        {
            for (int k = 0; k < size; k++)
            {
                if (arr[row, k] != 0 || arr[k, col] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
