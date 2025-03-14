using System;

namespace employee_demo
{
    public class HourlyEmployee : Employee
    {
        private float _payRate = 0;
        private int _hoursWorked = 0;

        private float GetPayRate()
        {
            return _payRate;
        }

        public void SetPayRate(float payRate)
        {
            _payRate = payRate;
        }

        public int GetHoursWorked()
        {
            return _hoursWorked;
        }

        public void SetHoursWorked(int hoursWorked)
        {
            _hoursWorked = hoursWorked;
        }
        public override float GetPay()
        {
           return _hoursWorked * _payRate; 
        }
    }
}
