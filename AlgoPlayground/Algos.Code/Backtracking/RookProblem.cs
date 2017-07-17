using Algos.Code.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Code.Backtracking
{
    public class RookProblem
    {
        int rooksCount;
        int size;
        int[,] arr;
        int[,] rooks;

        public RookProblem(int size, int count)
        {
            this.size = size;
            rooksCount = count;
            arr = new int[size, size];
            rooks = new int[size + 1, 2]; //2 means index 0 for column and index 1 for row
        }

        public void Solve()
        {
            int currentRook = 1;
            bool shouldContinue = true;

            while (shouldContinue)
            {
                currentRook = FindPlace(currentRook, 0, 0);

                if (currentRook == rooksCount)
                {
                    //we found one solution, print array
                    arr.WriteToConsole(0, size, 0, size);
                }

                //we've reached the end of the array                
                var movedRook = MoveForward(currentRook);

                if (movedRook == -1)
                {
                    break;
                }

                currentRook = movedRook;
            }
        }

        private int FindPlace(int currentRook, int startCol, int startRow)
        {
            int lastSet = currentRook - 1;
            for (int i = startCol; i < size; i++)
            {
                for (int j = startRow; j < size; j++)
                {
                    if (CanPlaceAt(i, j))
                    {
                        lastSet = currentRook;

                        arr[i, j] = currentRook;
                        rooks[currentRook, 0] = i;
                        rooks[currentRook, 1] = j;
                        currentRook++;
                    }
                }
            }

            return lastSet;
        }

        private int MoveForward(int currentRook)
        {
            if (currentRook == 1 && rooks[currentRook, 0] == size - 1 && rooks[currentRook, 1] == size - 1)
            {
                return -1;
            }

            for (int i = currentRook; i >= 1; i--)
            {
                var col = rooks[i, 0];
                var row = rooks[i, 1];
                arr[rooks[i, 0], rooks[i, 1]] = 0;
                rooks[i, 0] = 0;
                rooks[i, 1] = 0;

                if (col < size - 1)
                {
                    var findPlaceResult = FindPlace(i, col + 1, row);
                    return findPlaceResult;
                }
                else // equal to size - 1
                {
                    if (row < size - 1)
                    {
                        rooks[i, 0] = 0;
                        rooks[i, 1]++;

                        var findPlaceResult = FindPlace(i, col, row + 1);
                        return findPlaceResult;
                    }
                    else //rook is in right bottom corner
                    {
                        //so do nothing, we've cleared place already
                    }
                }
            }

            return -1; //that means we've get to the bottom corner with first rook            
        }

        private bool CanPlaceAt(int x, int y)
        {
            for (int k = 0; k < size; k++)
            {
                if (arr[k, y] != 0 || arr[x, k] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

}
