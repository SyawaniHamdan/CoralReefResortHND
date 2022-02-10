using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralReefResortHND2
{
    class Diving
    {
        //declarattion variable
        private string _package;
        private int _quantityDay;
        private int _quantityNight;
        private int _quantity;
        private double _totalprice;
        private string _divType;
        private string _equipment;
        public string DivType
        {
            get { return _divType; }
            set { _divType = value; }
        }
        public int QuantityDay
        {
            get { return _quantityDay; }
            set { _quantityDay = value; }
        }
        public int QuantityNight
        {
            get { return _quantityNight; }
            set { _quantityNight = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public string Equipment
        {
            get { return _equipment; }
            set { _equipment = value; }
        }
        public string Package
        {
            get { return _package; }
            set { _package = value; }
        }

        public double Totalprice
        {
            get { return _totalprice; }
            set { _totalprice = value; }
        }


        public Diving()
        { }
        public Diving(string newPackage, int newQuantityDay, int newQuantityNight, int newQuantity, double newTotalprice, string newDivType, string newEquipment)
        {
            _package = newPackage;
            _quantityDay = newQuantityDay;
            _quantityNight = newQuantityNight;
            _quantity = newQuantity;
            _totalprice = newTotalprice;
            _divType = newDivType;
            _equipment = newEquipment;
            
        }
        //this method is for calculate the price multiply with the quantity that have been input by user of each diving tpe type for day package 
        public void SetDivPriceDay()
        {
            switch (_divType)
            {
                case "Shore":
                     _totalprice = _totalprice + 55.00 * _quantity;
                     _quantityDay = _quantityDay + _quantity;                    
                    break;
                case "Boat":
                     _totalprice = _totalprice + 95.00 * _quantity;
                     _quantityDay = _quantityDay + _quantity; 
                    break;
            }
        }
        //this method is for calculate the price multiply with the quantity that have been input by user of each diving tpe type for night package
        public void SetDivPriceNight()
        {
            switch (_divType)
            {
                case "Shore":
                     _totalprice = _totalprice + 80.00 * _quantity;
                     _quantityNight = _quantityNight + _quantity; 
                    break;
                case "Boat":
                     _totalprice = _totalprice + 130.00 * _quantity;
                     _quantityNight = _quantityNight + _quantity; 
                    break;
            }
        }
        //this method is for calculate the price when user select yes or no for the equipment rental
        public double GetEquipment()
        {  
            if (_equipment == "Yes")
            {
                _totalprice =  _totalprice + 200;
            }
            else
            {
                _totalprice = _totalprice + 0;
            }
            return _totalprice;
        }
    }
}
