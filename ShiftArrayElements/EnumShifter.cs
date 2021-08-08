using System;

namespace ShiftArrayElements
{
    public static class EnumShifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using directions from <see cref="directions"/> array, one element shift per each direction array element.
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="directions">An array with directions.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">directions array is null.</exception>
        /// <exception cref="InvalidOperationException">direction array contains an element that is not <see cref="Direction.Left"/> or <see cref="Direction.Right"/>.</exception>
        public static int[] Shift(int[] source, Direction[] directions)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (directions == null)
            {
                throw new ArgumentNullException(nameof(directions));
            }

            for (int i = 0; i < directions.Length; i++)
            {
                switch (directions[i])
                {
                    case Direction.Left:
                        {
                            int temp = source[0];
                            for (int j = 1; j < source.Length; j++)
                            {
                                source[j - 1] = source[j];
                            }

                            source[source.Length - 1] = temp;
                            break;
                        }

                    case Direction.Right:
                        {
                            int temp = source[source.Length - 1];
                            for (int j = source.Length - 1; j != 0; j--)
                            {
                                source[j] = source[j - 1];
                            }

                            source[0] = temp;
                            break;
                        }

                    default:
                        throw new InvalidOperationException($"Incorrect {directions} enum value.");
                }
            }

            return source;
        }
    }
}
