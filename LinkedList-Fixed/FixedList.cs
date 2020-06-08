using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList_Fixed
{
    class FixedList<T> : LinkedList<T> {

        private T[] array;

        public FixedList()
        {
            this.array = new T[0];
        }

        public FixedList(T[] array)
        {
            this.array = array;
        }

        public void addItem(T item)
        {
            //Temp Array Instiantization
            T[] temparray = new T[array.Length + 1];
            //Adds all the values from the old array to the new array
            for(int i = 0; i < array.Length; i++)
            {
                //Sets the coresponding values from the array to temparray
                temparray[i] = array[i];
            }
            //Assigns the item that's being added
            temparray[array.Length] = item;
            //Assigns the array to the temparray
            array = temparray;
        }
        public void addItems(T[] items)
        {
            //Temp Array Instiantization
            T[] temparray = new T[array.Length + items.Length];
            //Adds all the values from the old array to the new array
            for (int i = 0; i < array.Length; i++)
            {
                //Sets the coresponding values from the array to temparray
                temparray[i] = array[i];
            }
            //Counter placeholder
            int counter = 0;
            //Loops through every value in items and adds it to temparray
            for(int i = array.Length; i < items.Length+array.Length; i++)
            {
                //Temparray slot = items
                temparray[i] = items[counter++];
                
            }
            //Assigns the array to the temparray
            array = temparray;
        }

        public int sumOfList()
        {           
            //If the array has no length
            if (array.Length <= 0)
                return -1;

            //If the Array is not an int
            if(!(array[0] is Int32))            
                return -1;
            //Instantiates sum
            int sum = 0;
            //Instantiates a casted temp array
            int[] temparray = (int[])(object) array;
            //Lambda adding all values to sum
            Array.ForEach(temparray, n => sum += n);            
            //Returns sum
            return sum;
        }

        public void removeItem(T item)
        {
           
        }

        public int findValue(T value)
        {
            //Loops through the array
            for (int i = 0; i < array.Length; i++)
            {
                //If it contains the value
                if (array[i].Equals(value))
                    //Returns
                    return i;
            }
            //If the value is not found, -1 is reqturned
            return -1;
        }

        public void addValue(T value, int index)
        {
            //Instantiates a new temp array
            T[] temparray = new T[array.Length + 1];
            //Loops through every indicy in temparray
            bool added = false;
            for(int i = 0; i < temparray.Length; i++)
            {
                //If i == to the index to be set, the value is = to the args value
                if (i == index) {
                    //Temp array = value
                    temparray[i] = value;
                    //Added equals true
                    added = true;
                    //Continues
                    continue;
                }
                //Added adds the other charatcers back into the array
                //If false
                if(!added)
                    temparray[i] = array[i];
                //If true
                if (added)
                    temparray[i] = array[i-1];
            }
            //Sets the main array to the temp array
            array = temparray;
        }

        public T[] getFixedList()
        {
            return array;
        }


    }
}
