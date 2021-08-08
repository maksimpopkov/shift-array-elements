using System;

namespace ShiftArrayElements
{
    public static class Shifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using <see cref="iterations"/> array for getting directions and iterations (see README.md for detailed instructions).
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="iterations">An array with iterations.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">iterations array is null.</exception>
        public static int[] Shift(int[] source, int[] iterations)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (iterations == null)
            {
                throw new ArgumentNullException(nameof(iterations));
            }

            for (int i = 0; i < iterations.Length; i++)
            {
                for (int j = 0; j < iterations[i]; j++)
                {
                    if (i % 2 == 0)
                    {
                        int tmp = source[0];
                        Array.Copy(source, 1, source, 0, source.Length - 1);
                        source[source.Length - 1] = tmp;
                    }
                    else
                    {
                        int tmp = source[source.Length - 1];
                        Array.Copy(source, 0, source, 1, source.Length - 1);
                        source[0] = tmp;
                    }
                }
            }

            return source;
        }
    }
}
