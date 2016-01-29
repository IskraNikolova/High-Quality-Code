namespace RotatingWalkInMatrix
{
    using System;
    using System.Text;

    public class Matrix
    {
        private readonly Cell[] targetCells;

        private int currentTargetCellIndex;

        public Matrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Size " + "cannot be null");
            }

            this.Field = new int[size, size];
            this.targetCells = new[]
              {
                new Cell(1, 1),
                new Cell(1, 0),
                new Cell(1, -1),
                new Cell(0, -1),
                new Cell(-1, -1),
                new Cell(-1, 0),
                new Cell(-1, 1),
                new Cell(0, 1)
                                  };
            this.currentTargetCellIndex = 0;
            this.FillMatrix();
        }

        public int[,] Field { get; }

        public override string ToString()
        {
            var printedMatrix = new StringBuilder();
            for (int row = 0; row < this.Field.GetLength(0); row++)
            {
                for (int column = 0; column < this.Field.GetLength(0); column++)
                {
                    printedMatrix.AppendFormat("{0,3}", this.Field[row, column]);
                }

                printedMatrix.AppendLine();
            }

            return printedMatrix.ToString();
        }

        private Cell FindFirstEmptyCell()
        {
            Cell result = new Cell(0, 0);

            for (int row = 0; row < this.Field.GetLength(0); row++)
            {
                for (int column = 0; column < this.Field.GetLength(0); column++)
                {
                    if (this.Field[row, column] == 0)
                    {
                        this.currentTargetCellIndex = 0;
                        result.X = row;
                        result.Y = column;
                        return result;
                    }
                }
            }

            return null;
        }

        private Cell Move(Cell cell)
        {
            for (int i = this.currentTargetCellIndex; i < this.targetCells.Length + this.currentTargetCellIndex; i++)
            {
                Cell nextCell = cell + this.targetCells[i % this.targetCells.Length];
                if (this.IsValidDestination(nextCell))
                {
                    this.currentTargetCellIndex = i % this.targetCells.Length;
                    return nextCell;
                }
            }

            return null;
        }

        private bool IsValidDestination(Cell cellToCheck)
        {
            return cellToCheck.X >= 0 && 
                cellToCheck.X < this.Field.GetLength(0) && 
                cellToCheck.Y >= 0 && 
                cellToCheck.Y < this.Field.GetLength(0) && 
                this.Field[cellToCheck.X, cellToCheck.Y] == 0;
        }

        private void FillMatrix()
        {
            var currentCell = new Cell(0, 0);
            var currentCellValue = 1;

            while (currentCell != null)
            {
                this.Field[currentCell.X, currentCell.Y] = currentCellValue;
                currentCell = this.Move(currentCell) ?? this.FindFirstEmptyCell();

                currentCellValue++;
            }
        }
    }
}
