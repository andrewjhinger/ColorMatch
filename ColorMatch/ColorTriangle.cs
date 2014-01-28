using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColorMatch
{
    public struct ColorTriangle
    {
        // In ColorMatrix, first row consists of primary colors
        // second row consists of complementary colors
        // Color complements are in different rows same column
        // Mix results of any two colors in same row is color not
        // selected but in other row
        private static Color[][] _colorMatrix =
        { 
            new Color[]{Color.Blue, Color.Red, Color.Yellow},       // Primary colors
            new Color[]{Color.Orange, Color.Green, Color.Purple}    // Complementary colors
        };
        // Return primary color array
        public static Color[] PrimaryColors()
        {
            return _colorMatrix[0];
        }
        // Return complementary color array
        public static Color[] ComplementaryColors()
        {
            return _colorMatrix[1];
        }
        // Return complementary color
        public static Color GetComplement(Color searchColor)
        {
            Color complement = Color.Black;
            // Find color
            for (int row = 0; row < _colorMatrix.Length; row++)
            {
                // Determine column
                int col = Array.IndexOf(_colorMatrix[row], searchColor);
                // Color found, return same column color but from other row
                if (col >= 0)
                    complement = _colorMatrix[(row == 0 ? 1 : 0)][col];
            }
            return complement;
        }
        // Return complement of specified colors
        public static Color GetMixResult(Color colorOne, Color colorTwo)
        {
            Color mixResult = Color.Black;
            for (int row = 0; row < _colorMatrix.Length; row++)
            {
                int colColorOne = Array.IndexOf(_colorMatrix[row], colorOne);
                int colColorTwo = Array.IndexOf(_colorMatrix[row], colorTwo);
                if (colColorOne >= 0 && colColorTwo >= 0)
                    mixResult = _colorMatrix[(row == 0 ? 1 : 0)][(3 - colColorOne - colColorTwo)];
            }
            return mixResult;
        }
    }
}