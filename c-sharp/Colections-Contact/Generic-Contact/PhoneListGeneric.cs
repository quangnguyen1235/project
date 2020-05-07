using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Contact
{
    public class PhoneListGeneric<T> where T: class
    {
        public T[]phoneListGeneric = new T[0];
        private int numOfPhone => phoneListGeneric.Length;
        public PhoneListGeneric()
        {

        }
        public void InsertPhoneNumber(T value)
        {
            Array.Resize(ref phoneListGeneric, numOfPhone + 1);
            phoneListGeneric[numOfPhone - 1] = value;
        }
        public void RemovePhoneNumber(int index)
        {
            if (index >= 0 && index < numOfPhone)
            {
                for (int i = index; i < numOfPhone-1; i++)
                {
                    phoneListGeneric[i] = phoneListGeneric[i - 1];
                }
            }
        }
        public void RemovePhoneNumber(T value)
        {
            int pos = Check(value);
            RemovePhoneNumber(pos);
        }
        public void SearchPhoneNumber(T value)
        {
            int pos = Check(value);
            SearchPhoneNumber(pos);
        }
        
        public void UpdatePhoneNumber(T oldValue, T newValue)
        {
            int pos = Check(oldValue);
            UpdatePhoneNumber(pos, newValue);
        }
        public void Soft(T value)
        {

        }
        private void SearchPhoneNumber(int index)
        {
            if (index >= 0 && index < numOfPhone)
            {
                phoneListGeneric[index].ToString();
            }
        }
        private void UpdatePhoneNumber(int index, T value)
        {
            if (index >= 0 && index < numOfPhone)
            {
                phoneListGeneric[index] = value;
            }
        } 
        private int Check(T value)
        {
            for (int i = 0; i < numOfPhone; i++)
            {
                if (phoneListGeneric[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
