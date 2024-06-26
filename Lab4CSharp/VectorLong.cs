﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4CSharp
{
    using System;

    class VectorLong
    {
        protected long[] IntArray;
        protected uint size;
        protected int codeError;
        protected static uint num_vl;

        // Конструктори
        public VectorLong()
        {
            IntArray = new long[1];
            size = 1;
            num_vl++;
        }

        public VectorLong(uint size)
        {
            IntArray = new long[size];
            this.size = size;
            num_vl++;
        }

        public VectorLong(uint size, long initValue)
        {
            IntArray = new long[size];
            this.size = size;
            for (int i = 0; i < size; i++)
            {
                IntArray[i] = initValue;
            }
            num_vl++;
        }

        // Деструктор
        ~VectorLong()
        {
            Console.WriteLine("Destructor called");
        }

        // Методи
        public void Input()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i}: ");
                IntArray[i] = long.Parse(Console.ReadLine());
            }
        }

        public void Output()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Element {i}: {IntArray[i]}");
            }
        }

        public void SetValue(long value)
        {
            for (int i = 0; i < size; i++)
            {
                IntArray[i] = value;
            }
        }

        public static uint GetNumVectors()
        {
            return num_vl;
        }

        // Властивості
        public uint Size
        {
            get { return size; }
        }

        public int CodeError
        {
            get { return codeError; }
            set { codeError = value; }
        }

        // Індексатор
        public long this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                {
                    codeError = -1;
                    return 0;
                }
                else
                {
                    codeError = 0;
                    return IntArray[index];
                }
            }
            set
            {
                if (index < 0 || index >= size)
                {
                    codeError = -1;
                }
                else
                {
                    codeError = 0;
                    IntArray[index] = value;
                }
            }
        }

        // Перевантаження операторів
        public static VectorLong operator ++(VectorLong vec)
        {
            for (int i = 0; i < vec.size; i++)
            {
                vec.IntArray[i]++;
            }
            return vec;
        }

        public static VectorLong operator --(VectorLong vec)
        {
            for (int i = 0; i < vec.size; i++)
            {
                vec.IntArray[i]--;
            }
            return vec;
        }

        public static bool operator true(VectorLong vec)
        {
            if (vec.size == 0)
            {
                return false;
            }

            for (int i = 0; i < vec.size; i++)
            {
                if (vec[i] == 0)
                    return false;
            }

            return true;
        }

        public static bool operator false(VectorLong vec)
        {
            if (vec.size == 0)
            {
                return true;
            }

            for (int i = 0; i < vec.size; i++)
            {
                if (vec[i] == 0)
                    return true;
            }

            return false;
        }

        public static bool operator !(VectorLong vec)
        {
            if (vec.size == 0)
            {
                return true;
            }

            for (int i = 0; i < vec.size; i++)
            {
                if (vec[i] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static VectorLong operator ~(VectorLong vec)
        {
            VectorLong newVector = new VectorLong(vec.size);
            for (int i = 0; i < vec.size; i++)
            {
                newVector[i] = ~vec[i];
            }

            return newVector;
        }

        public static VectorLong operator +(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;
                result[i] = val1 + val2;
            }

            return result;
        }

        public static VectorLong operator -(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;
                result[i] = val1 - val2;
            }

            return result;
        }

        public static VectorLong operator *(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;
                result[i] = val1 * val2;
            }

            return result;
        }

        public static VectorLong operator /(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;

                if (val2 != 0)
                {
                    result[i] = val1 / val2;
                } else
                {
                    result[i] = 0;
                }
            }

            return result;
        }

        public static VectorLong operator %(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;

                if (val2 != 0)
                {
                    result[i] = val1 % val2;
                } else
                {
                    result[i] = 0;
                }
            }

            return result;
        }

        public static VectorLong operator |(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;
                result[i] = val1 | val2;
            }

            return result;
        }

        public static VectorLong operator &(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;
                result[i] = val1 & val2;
            }

            return result;
        }

        public static VectorLong operator ^(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;
                result[i] = val1 ^ val2;
            }

            return result;
        }

        public static VectorLong operator <<(VectorLong vec1, int value)
        {
            VectorLong result = new VectorLong(vec1.size);

            for (int i = 0; i < vec1.size; i++)
            {
                result[i] = vec1[i] << value;
            }

            return result;
        }

        public static VectorLong operator >>(VectorLong vec1, int value)
        {
            VectorLong result = new VectorLong(vec1.size);

            for (int i = 0; i < vec1.size; i++)
            {
                result[i] = vec1[i] >> value;
            }

            return result;
        }

        public static bool operator ==(VectorLong vec1, VectorLong vec2)
        {
            if (vec1.size != vec2.size) return false;

            for (int i = 0; i < vec1.size; i++)
            {
                if (vec1[i] != vec2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(VectorLong vec1, VectorLong vec2)
        {
            return !(vec1 == vec2);
        }

        public static bool operator >(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;
                if (val1 < val2)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator >=(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;
                if (val1 <= val2)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator <(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;
                if (val1 > val2)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator <=(VectorLong vec1, VectorLong vec2)
        {
            uint maxSize = Math.Max(vec1.size, vec2.size);
            VectorLong result = new VectorLong(maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                long val1 = (i < vec1.size) ? vec1[i] : 0;
                long val2 = (i < vec2.size) ? vec2[i] : 0;
                if (val1 >= val2)
                {
                    return false;
                }
            }

            return true;
        }


        public static VectorLong operator +(VectorLong vec, long value)
        {
            VectorLong vectorValue = new VectorLong(vec.size, value);
            return vectorValue + vec;
        }

        public static VectorLong operator -(VectorLong vec, long value)
        {
            VectorLong vectorValue = new VectorLong(vec.size, value);
            return vec - vectorValue;
        }

        public static VectorLong operator *(VectorLong vec, long value)
        {
            VectorLong vectorValue = new VectorLong(vec.size, value);
            return vec * vectorValue;
        }

        public static VectorLong operator /(VectorLong vec, long value)
        {
            VectorLong vectorValue = new VectorLong(vec.size, value);
            return vec / vectorValue;
        }

        public static VectorLong operator %(VectorLong vec, long value)
        {
            VectorLong vectorValue = new VectorLong(vec.size, value);
            return vec % vectorValue;
        }

        public static VectorLong operator |(VectorLong vec, long value)
        {
            VectorLong vectorValue = new VectorLong(vec.size, value);
            return vec | vectorValue;
        }

        public static VectorLong operator ^(VectorLong vec, long value)
        {
            VectorLong vectorValue = new VectorLong(vec.size, value);
            return vec ^ vectorValue;
        }

        public static VectorLong operator &(VectorLong vec, int value)
        {
            VectorLong result = new VectorLong(vec.size);

            for (int i = 0; i < vec.size; i++)
            {
                result[i] = vec[i] & value;
            }

            return result;
        }

        public void toString()
        {
            this.Output();
        }
    }
}
