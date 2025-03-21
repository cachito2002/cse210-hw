using System;

namespace employee_demo
{
    public class Employee
    {
        protected string _name;
        protected string _idNumber;

        public Employee()
        {     
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetIdNumber()
        {
            return _idNumber;
        }

        public void SetIdNumber(string idNumber)
        {
            _idNumber = idNumber;
        }

        public virtual float GetPay()
        {
            return -1;
        }
    }
}