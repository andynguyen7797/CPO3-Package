using System;

namespace CPO3_Remaker
{
    public class SapXep
    {


        public static void Sapxep_Min_To_Max(ref string[] list_object,ref string[] list_value, ref byte[] tag)
        {
            int count = list_object.Length;

            // convert list_value to double

            double[] list_value_double = new double[count];


            for(int i = 0; i < count; i++)
            {
                list_value_double[i] = Convert.ToDouble(list_value[i]);
            }

            // compare and swap

            string swap_value_object;
            string swap_value_of_object;
            byte swap_tag_value;

            for (int i = 0; i < count; i++)
            {
                for(int j = count - 1; j > i; j--)
                {
                    if(list_value_double[j-1] > list_value_double[j])
                    {
                        // swap object
                        swap_value_object = list_object[j-1];
                        list_object[j-1] = list_object[j];
                        list_object[j] = swap_value_object;

                        //swap value of object
                        swap_value_of_object = list_value[j-1];
                        list_value[j-1] = list_value[j];
                        list_value[j] = swap_value_of_object;

                        // swap tag value
                        swap_tag_value = tag[j - 1];
                        tag[j - 1] = tag[j];
                        tag[j] = swap_tag_value;
                    }
                }
            }
        }

        public static void Sapxep_Max_To_Min(ref string[] list_object, ref string[] list_value, ref byte[] tag)
        {
            int count = list_object.Length;

            // convert list_value to double

            int[] list_value_int = new int[count];


            for (int i = 0; i < count; i++)
            {
                list_value_int[i] = Convert.ToInt32(list_value[i]);
            }

            // compare and swap

            string swap_value_object;
            string swap_value_of_object;
            byte swap_tag_value;

            for (int i = 0; i < count; i++) 
            {
                for (int j = count - 1; j > i; j--) 
                {
                    if (list_value_int[j - 1] < list_value_int[j]) 
                    {
                        // swap object
                        swap_value_object = list_object[j - 1]; 
                        list_object[j - 1] = list_object[j]; 
                        list_object[j] = swap_value_object; 

                        //swap value of object
                        swap_value_of_object = list_value[j - 1];
                        list_value[j - 1] = list_value[j];
                        list_value[j] = swap_value_of_object;

                        // swap tag value
                        swap_tag_value = tag[j - 1];
                        tag[j - 1] = tag[j];
                        tag[j] = swap_tag_value;
                    }
                }
            }
        }
    }
}
