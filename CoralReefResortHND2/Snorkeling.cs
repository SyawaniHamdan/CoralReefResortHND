using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralReefResortHND2
{
    class Snorkeling
    {
        //declaration variable
        private string _package;
        private int _totalQuantityWeekday;
        private int _totalQuantityWeekend;
        private int _quantity;
        private double _totalprice;
        private string _roomType;

        public string Package
        {
            get { return _package; }
            set { _package = value; }
        }

        public int TotalQuantityWeekday
        {
            get { return _totalQuantityWeekday; }
            set { _totalQuantityWeekday = value; }
        }
        public int TotalQuantityWeekend
        {
            get { return _totalQuantityWeekend; }
            set { _totalQuantityWeekend = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public double Totalprice
        {
            get { return _totalprice; }
            set { _totalprice = value; }
        }
        public string RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }
        
        public Snorkeling()
        { }
        public Snorkeling(string newRoomType, int newTotalQuantityWeekday, int newTotalQuantityWeekend, int newQuantity, double newTotalprice, string newPackage)
        {
            _roomType = newRoomType;
            _totalQuantityWeekday = newTotalQuantityWeekday;
            _totalQuantityWeekend = newTotalQuantityWeekend;
            _quantity = newQuantity;
            _totalprice = newTotalprice;
            _package = newPackage;
        }
        //this method is for calculate the price multiply with the quantity that have been input by user of each room type for weekday package 
        public void SetRoomPriceWeekday() 
        {            
                switch (_roomType)
                {
                    case "Twin":
                        _totalprice = _totalprice + 390.00 * _quantity;
                        _totalQuantityWeekday = _totalQuantityWeekday + _quantity;
                        break;
                    case "Triple":
                        _totalprice = _totalprice + 320.00 * _quantity;
                        _totalQuantityWeekday = _totalQuantityWeekday + _quantity;
                        break;
                    case "Quad":
                        _totalprice = _totalprice + 270.00 * _quantity;
                        _totalQuantityWeekday = _totalQuantityWeekday + _quantity;
                        break;
                }
        }
        //this method is for calculate the price multiply with the quantity that have been input by user of each room type for weekend package 
        public void SetRoomPriceWeekend()
        {
            switch (_roomType)
            {
                case "Twin":
                    _totalprice = _totalprice + 410.00 * _quantity;
                    _totalQuantityWeekend = _totalQuantityWeekend + _quantity;
                    break;
                case "Triple":
                    _totalprice = _totalprice + 350.00 * _quantity;
                    _totalQuantityWeekend = _totalQuantityWeekend + _quantity;
                    break;
                case "Quad":
                    _totalprice = _totalprice + 290.00 * _quantity;
                    _totalQuantityWeekend = _totalQuantityWeekend + _quantity;
                    break;
            }
        }
    }
}
